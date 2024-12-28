using CadastroDeUsuario_Domain.Entities.Base;
using System.Linq.Expressions;

namespace CadastroDeUsuario_Infra.Repository.Interfaces
{
    public interface IBaseRepository<TDomain> where TDomain : BaseDomain
    {
        Task<TDomain> Find(Expression<Func<TDomain, bool>> whereByExpression);
        Task<List<TDomain>> FindAll(Expression<Func<TDomain, bool>> whereByExpression);
        Task Insert(TDomain entity);
        Task Update(TDomain entity);
        Task<List<TDomain>> GetAllUsers();
        Task Delete(TDomain entity);
        Task DeleteAllUsers();  

        Task<List<TDomain>> GetAllMaterias();
        

        
    }
}
