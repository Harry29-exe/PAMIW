using System.Collections.Generic;
using System.Threading.Tasks;
using Zawodnicy.Core.Domain;

namespace Zawodnicy.Core.Repositories
{
    public class CompetitionRepository : ICrudRepository<long, Competition>
    {
        public Task AddAsync(Competition entity)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(Competition entity)
        {
            throw new System.NotImplementedException();
        }

        public Task DelAsync(Competition entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<Competition> GetAsync(long id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Competition>> BrowseAllAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}