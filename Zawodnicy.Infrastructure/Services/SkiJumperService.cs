using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zawodnicy.Core.Repositories;
using Zawodnicy.Infrastructure.DTO;

namespace Zawodnicy.Infrastructure.Services
{
    public class SkiJumperService : ISkiJumperService
    {
        private readonly ISkiJumperRepository _skiJumperRepository;

        public SkiJumperService(ISkiJumperRepository skiJumperRepository)
        {
            this._skiJumperRepository = skiJumperRepository;
        }
        
        public async Task<IEnumerable<SkiJumperDTO>> BrowseAll()
        {
            var jumpers = await _skiJumperRepository.BrowseAllAsync();

            return jumpers.Select(x => new SkiJumperDTO()
            {
                Id = x.Id,
                Name = x.Name,
                Surname = x.Surname,
                Country = x.Country,
                BornDate = x.BornDate,
                Height = x.Height,
                Weight = x.Weight
            });
        }
    }
}