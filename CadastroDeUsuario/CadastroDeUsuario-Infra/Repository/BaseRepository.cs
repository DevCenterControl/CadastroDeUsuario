using CadastroDeUsuario_Domain.Entities.Base;
using CadastroDeUsuario_Domain.Entities.User;
using CadastroDeUsuario_Infra.DBContext;
using CadastroDeUsuario_Infra.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CadastroDeUsuario_Infra.Repository
{
    public class BaseRepository<TDomain> : IBaseRepository<TDomain> where TDomain : BaseDomain
    {
        #region Fields
        protected readonly ApplicationDbContext _dbContext;
        #endregion

        #region Constructor
        public BaseRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }
        #endregion

        #region Methods


        public async Task<TDomain> Find(Expression<Func<TDomain, bool>> whereByExpression) =>
            await _dbContext.Set<TDomain>().FirstAsync();

        //public async Task<TDomain> Find(Expression<Func<TDomain, bool>> whereByExpression) =>
        //    await _dbContext.Set<TDomain>().Where(whereByExpression).Where(x => x.DeletedAt == null).FirstAsync();

        public async Task<List<TDomain>> FindList(Expression<Func<TDomain, bool>> whereByExpression) =>
            await _dbContext.Set<TDomain>().Where(whereByExpression).Where(x => x.DeletedAt == null).ToListAsync();

        public async Task Insert(TDomain entity)
        {
            await _dbContext.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Update(TDomain entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.Update(entity);
            await _dbContext.SaveChangesAsync();
        }

        #endregion
    }
}
