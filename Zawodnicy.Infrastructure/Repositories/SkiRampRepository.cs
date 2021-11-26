using System.Collections.Generic;
using System.Threading.Tasks;
using Zawodnicy.Core.Domain;

namespace Zawodnicy.Core.Repositories
{
    public class SkiRampRepository : ICrudRepository<long, SkiRamp>
    {
        public Task AddAsync(SkiRamp entity)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(SkiRamp entity)
        {
            throw new System.NotImplementedException();
        }

        public Task DelAsync(SkiRamp entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<SkiRamp> GetAsync(long id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<SkiRamp>> BrowseAllAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}