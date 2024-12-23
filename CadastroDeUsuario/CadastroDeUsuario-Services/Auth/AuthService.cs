using Azure.Core;
using CadastroDeUsuario_Domain.Entities.User;
using CadastroDeUsuario_DTO.Request.Auth;
using CadastroDeUsuario_DTO.Response.Auth;
using CadastroDeUsuario_Infra.Repository.Interfaces;
using CadastroDeUsuario_Services.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace CadastroDeUsuario_Services.Auth
{

    public class AuthService : IAuthService
    {
        #region Fields
        private readonly IBaseRepository<UserDomain> _baseRepository;
        private readonly JwtService _jwtService;
        #endregion

        #region Constructor
        public AuthService(
                IBaseRepository<UserDomain> baseRepository,
                JwtService jwtService)
        {
            _baseRepository = baseRepository;
            _jwtService = jwtService;
        }
        #endregion

        #region Methods

        public async Task<AuthLoginResponseDTO> Authenticate(AuthLoginRequestDTO request)
        {
            if (!string.IsNullOrEmpty(request.email))
            {
                ValidateEmailRequestDTO(request.email);
            }
            else if (!string.IsNullOrEmpty(request.CPF))
            {
                ValidateCPFRequestDTO(request.CPF);
            }
            else
            {
                throw new Exception("Campo e-mail ou CPF deve ser preenchido.");
            }

            ValidatePasswordRequestDTO(request.password);

            var user = await _baseRepository.Find(x => (x.Email == request.email || x.Cpf == request.CPF) && x.Password == request.password);

            if (user != null)
            {
                if (user.Idade < 18)
                {
                    throw new Exception("Usuário não permitido. Apenas maiores de 18 anos podem acessar.");
                }

                return new AuthLoginResponseDTO
                {
                    UserId = user.Id,
                    Code = HttpStatusCode.OK,
                    Login = user.Email != null ? user.Email : user.Cpf,
                    Photo = "perfil.png",
                    IsSuccess = true,
                    Token = _jwtService.GenerateToken(user.Id.ToString(), user.Email != null ? user.Email : user.Cpf)               
                };
            }
            else
            {
                throw new Exception("Usuario não localizado.");
            }
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

