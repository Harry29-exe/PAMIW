using System.Collections.Generic;

namespace Zawodnicy.Core.Repositories
{
    public interface ICrudRepository<TKey, TEntity>
    {
        TEntity FindById(TKey key);

        IEnumerable<TEntity> FindAll();

        TEntity Save(TEntity entity);

        TEntity Update(TEntity entity, TKey id);

        void Delete(TKey key);
    }
}