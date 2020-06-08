using DigitalWorld.Common;
using DigitalWorld.DAL.Model;
using DigitalWorld.DAL.Repositories.Intrefaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWorld.DAL.Repositories
{
    public abstract class BaseRepository : IRepository
    {
        public Task<int> Count<TEntity>(Func<TEntity, bool> predicate = null) where TEntity : BaseEntity
        {
            throw new NotImplementedException();
        }

        public virtual async Task Create<TEntity>(TEntity item, Action<TEntity, DigitalWorldContext> preprocessor = null) where TEntity : BaseEntity
        {
            item.ThrowIfNull();
        }

        public Task CreateBatch<TEntity>(IEnumerable<TEntity> items, Action<IEnumerable<TEntity>, DigitalWorldContext> preprocessor = null) where TEntity : BaseEntity
        {
            throw new NotImplementedException();
        }

        public Task Delete<TEntity>(TEntity item) where TEntity : BaseEntity
        {
            throw new NotImplementedException();
        }

        public Task DeleteBatch<TEntity>(IEnumerable<TEntity> items) where TEntity : BaseEntity
        {
            throw new NotImplementedException();
        }

        public Task<bool> Exists<TEntity>(Func<TEntity, bool> predicate) where TEntity : BaseEntity
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> FindById<TEntity>(long id) where TEntity : BaseEntity
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> GetAll<TEntity>(params Expression<Func<TEntity, object>>[] includes) where TEntity : BaseEntity
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> Search<TEntity>(Func<TEntity, bool> predicate, params Expression<Func<TEntity, object>>[] includes) where TEntity : BaseEntity
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> Search<TEntity>(Func<TEntity, bool> predicate, int pageSize, int pageNumber, params Expression<Func<TEntity, object>>[] includes) where TEntity : BaseEntity
        {
            throw new NotImplementedException();
        }

        public Task Update<TEntity>(TEntity item, bool ignoreVersion = false) where TEntity : BaseEntity
        {
            throw new NotImplementedException();
        }
    }
}
