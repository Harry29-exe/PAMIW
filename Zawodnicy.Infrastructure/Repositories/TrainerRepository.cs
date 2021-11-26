using System.Collections.Generic;
using System.Threading.Tasks;
using Zawodnicy.Core.Domain;

namespace Zawodnicy.Core.Repositories
{
    public class TrainerRepository : ICrudRepository<long, Trainer>
    {
        public Task AddAsync(Trainer entity)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(Trainer entity)
        {
            throw new System.NotImplementedException();
        }

        public Task DelAsync(Trainer entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<Trainer> GetAsync(long id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Trainer>> BrowseAllAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}