using System.Collections.Generic;
using System.Threading.Tasks;
using Zawodnicy.Core.Domain;

namespace Zawodnicy.Core.Repositories
{
    public class CityRepository : ICrudRepository<long, City>
    {
        public Task AddAsync(City entity)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(City entity)
        {
            throw new System.NotImplementedException();
        }

        public Task DelAsync(City entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<City> GetAsync(long id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<City>> BrowseAllAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}