using System.Collections.Generic;
using System.Threading.Tasks;
using Zawodnicy.Core.Domain;

namespace Zawodnicy.Core.Repositories
{
    public interface ISkiJumperRepository : ICrudRepository<long, SkiJumper>
    {
        public Task<IEnumerable<SkiJumper>> BrowseAllAsyncBy(string country, string name);
    }
}