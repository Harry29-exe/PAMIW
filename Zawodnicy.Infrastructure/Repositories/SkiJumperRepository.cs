using System.Collections.Generic;
using System.Threading.Tasks;
using Zawodnicy.Core.Domain;

namespace Zawodnicy.Core.Repositories
{
    public class SkiJumperRepository : ICrudRepository<long, SkiJumper>
    {
        public Task AddAsync(SkiJumper entity)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(SkiJumper entity)
        {
            throw new System.NotImplementedException();
        }

        public Task DelAsync(SkiJumper entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<SkiJumper> GetAsync(long id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<SkiJumper>> BrowseAllAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}