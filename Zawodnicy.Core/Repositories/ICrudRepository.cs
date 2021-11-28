using System.Collections.Generic;
using System.Threading.Tasks;

namespace Zawodnicy.Core.Repositories
{
    public interface ICrudRepository<TKey, TEntity>
    {
        Task AddAsync(TEntity entity);

        Task UpdateAsync(TEntity entity);

        Task DelAsync(TEntity entity);

        Task<TEntity> GetAsync(TKey id);

        Task<IEnumerable<TEntity>> BrowseAllAsync();
    }
}