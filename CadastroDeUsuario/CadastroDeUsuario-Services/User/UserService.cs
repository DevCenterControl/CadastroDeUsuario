using Azure.Core;
using CadastroDeUsuario_Domain.Entities.User;
using CadastroDeUsuario_DTO.Request.Auth;
using CadastroDeUsuario_DTO.Request.User;
using CadastroDeUsuario_DTO.Response.Auth;
using CadastroDeUsuario_DTO.Response.User;
using CadastroDeUsuario_DTO.UserDTO;
using CadastroDeUsuario_Infra.DBContext;
using CadastroDeUsuario_Infra.Repository.Interfaces;
using CadastroDeUsuario_Services.Auth;
using CadastroDeUsuario_Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CadastroDeUsuario_Services.User
{
    public class UserService : IUserService
    {
        #region Fields
        private readonly IBaseRepository<UserDomain> _baseRepository;
        private readonly JwtService _jwtService;
        private readonly ApplicationDbContext _dbContext;

        #endregion

        #region Constructor
        public UserService(
                IBaseRepository<UserDomain> baseRepository,
                JwtService jwtService,
                ApplicationDbContext dbContext)
        {
            _baseRepository = baseRepository;
            _jwtService = jwtService;
            _dbContext = dbContext;
        }
        #endregion

        #region Methods
        public async Task<CreatUserResponseDto> CreateUser(CreateUserRequestDTO request)
        { // Adicionar veirifcaação de so adicionar usuario se email e cpf nao eestiver cadastrado, possibilitar enviar um codigo de verificação para o email informado evitando duplicidade.
            if (!string.IsNullOrEmpty(request.Email))
            {
                ValidateEmailRequestDTO(request.Email);
            }
            if (!string.IsNullOrEmpty(request.Cpf))
            {
                ValidateCPFRequestDTO(request.Cpf);
            }
            else
            {
                throw new Exception("Campo e-mail e CPF deve ser preenchido.");
            }

            ValidatePasswordRequestDTO(request.Password);

            var existingUser = await _baseRepository.Find(x => x.Email == request.Email || x.Cpf == request.Cpf);

            if (existingUser != null)
            {
                throw new Exception("Usuário com este e-mail ou CPF já existe.");
            }
            else
            {
                var user = new UserDomain
                {
                    Nome = request.Nome,
                    Email = request.Email,
                    Password = request.Password,
                    Endereco = request.Endereco,
                    Cpf = request.Cpf
                };

                await _baseRepository.Insert(user);
            }

            return new CreatUserResponseDto
            {
                CreatedAt = DateTime.UtcNow,
                IsCreated = true
            };
        }

        public async Task<List<UserDTO>> GetUsersByName(string name)
        {
            var users = await _dbContext.Users
                .Where(u => u.Nome.Contains(name))
                .Select(u => new UserDTO
                {
                    Id = u.Id,
                    Name = u.Nome,
                    Email = u.Email,
                    Cpf = u.Cpf,
                })
                .ToListAsync();

            return users;
        }

        public async Task<UserDTO> DeleteUser(string cpf)
        {

            if (string.IsNullOrEmpty(cpf))
                throw new ArgumentException("O CPF não pode ser nulo ou vazio.");
            else
            {
                ValidateCPFRequestDTO(cpf);
            }


            var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Cpf == cpf);


            if (user == null)
                throw new KeyNotFoundException("Usuário não encontrado com o CPF especificado.");


            _dbContext.Users.Remove(user);
            await _dbContext.SaveChangesAsync();


            throw new Exception($"Usuario {cpf} deletado com sucesso.");
        }

        public async Task<UpdateUserResponseDTO> UpdateUser(UpdateUserRequestDTO request)
        {
          
            var user = await _baseRepository.Find(x => x.Cpf == request.Cpf);

            //var user = await _baseRepository.Find(x => x.Cpf == request.Cpf);

            if (user == null)
                throw new Exception("Usuário não localizado.");

            
            user.Nome = request.Nome ?? user.Nome;
            user.Email = request.Email ?? user.Email;
            user.Endereco = request.Endereco ?? user.Endereco;
            user.UpdatedDate = DateTime.Now;

            await _baseRepository.Update(user);

            return new UpdateUserResponseDTO
            {
                Nome = user.Nome,
                Email = user.Email,
                Endereco = user.Endereco,
                UpdatedAt = user.UpdatedDate
            };
        }


        #region private methods
        private void ValidateEmailRequestDTO(string email)
        {

            string[] provedoresPermitidos = { "@gmail.com", "@outlook.com", "@hotmail.com", "@yahoo.com" };

            var isPermitted = provedoresPermitidos.Any(provedor => email.EndsWith(provedor, StringComparison.OrdinalIgnoreCase));

            if (!isPermitted)
            {
                throw new Exception("O email deve ter um provedor permitido: @gmail.com, @outlook.com, @hotmail.com ou @yahoo.com.");
            }

            if (email.Length < 12)
            {
                throw new Exception("E-mail deve conter no minimo 12 caracteres.");
            }
        }

        private void ValidatePasswordRequestDTO(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                throw new Exception("A senha é obrigatória.");
            }

            if (password.Contains(" "))
            {
                throw new Exception("A senha nao pode conter um espaço em branco.");
            }

            if (!Regex.IsMatch(password, @"[A-Z]"))
            {
                throw new Exception("A senha deve conter uma letra maiuscula.");
            }

            if (!Regex.IsMatch(password, @"[a-z]"))
            {
                throw new Exception("A senha deve conter uma letra minuscula.");
            }

            if (!Regex.IsMatch(password, @"[0-9]"))
            {
                throw new Exception("A senha deve conter um numero.");
            }

            if (!Regex.IsMatch(password, @"[\W_]"))
            {
                throw new Exception("A senha deve conter um caracter especial.");
            }

        }

        private void ValidateCPFRequestDTO(string CPF)
        {

            if (Regex.IsMatch(CPF, @"[\W_]"))
            {
                throw new Exception("CPF nao deve conter pontos ou espaços.");
            }

            if (!Regex.IsMatch(CPF, @"^[0-9X]{11}$"))
            {
                throw new Exception("CPF so pode conter a letra X e 11 digitos.");
            }

        }

        #endregion

        #endregion
    }
}
