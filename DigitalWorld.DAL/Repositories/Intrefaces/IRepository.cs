using DigitalWorld.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWorld.DAL.Repositories.Intrefaces
{
    public interface IRepository<TEntity> : IRepository
       where TEntity : BaseEntity
    {
    }
    public interface IRepository
    {
        Task Create<TEntity>(TEntity item, Action<TEntity, DigitalWorldContext> preprocessor = null) where TEntity : BaseEntity;
        Task CreateBatch<TEntity>(IEnumerable<TEntity> items, Action<IEnumerable<TEntity>, DigitalWorldContext> preprocessor = null) where TEntity : BaseEntity;
        Task<TEntity> FindById<TEntity>(long id) where TEntity : BaseEntity;
        Task<IEnumerable<TEntity>> GetAll<TEntity>(params Expression<Func<TEntity, object>>[] includes) where TEntity : BaseEntity;
        Task<IEnumerable<TEntity>> Search<TEntity>(Func<TEntity, bool> predicate, params Expression<Func<TEntity, object>>[] includes) where TEntity : BaseEntity;
        Task<IEnumerable<TEntity>> Search<TEntity>(Func<TEntity, bool> predicate, int pageSize, int pageNumber, params Expression<Func<TEntity, object>>[] includes) where TEntity : BaseEntity;
        Task<int> Count<TEntity>(Func<TEntity, bool> predicate = null) where TEntity : BaseEntity;
        Task Delete<TEntity>(TEntity item) where TEntity : BaseEntity;
        Task DeleteBatch<TEntity>(IEnumerable<TEntity> items) where TEntity : BaseEntity;
        Task Update<TEntity>(TEntity item, bool ignoreVersion = false) where TEntity : BaseEntity;
        Task<bool> Exists<TEntity>(Func<TEntity, bool> predicate) where TEntity : BaseEntity;
    }
}
