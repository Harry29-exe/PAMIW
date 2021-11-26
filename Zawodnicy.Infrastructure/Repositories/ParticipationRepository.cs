using System.Collections.Generic;
using System.Threading.Tasks;
using Zawodnicy.Core.Domain;

namespace Zawodnicy.Core.Repositories
{
    public class ParticipationRepository : ICrudRepository<long, Participation>
    {
        public Task AddAsync(Participation entity)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(Participation entity)
        {
            throw new System.NotImplementedException();
        }

        public Task DelAsync(Participation entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<Participation> GetAsync(long id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Participation>> BrowseAllAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}