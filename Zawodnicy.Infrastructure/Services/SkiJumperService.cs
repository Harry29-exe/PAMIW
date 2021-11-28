using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zawodnicy.Core.Domain;
using Zawodnicy.Core.Repositories;
using Zawodnicy.Infrastructure.Commands;
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

            return jumpers.Select(SkiJumperDTO.from);
        }

        public async Task<SkiJumperDTO> GetSkiJumper(int id)
        {
            var jumper = await _skiJumperRepository.GetAsync(id);
            if (jumper == null)
            {
                return null;
            }
            var dto = SkiJumperDTO.from(jumper);
            return dto;
        }

        public async Task<IEnumerable<SkiJumperDTO>> GetSkiJumpers(string country, string name)
        {
            var jumpers = await _skiJumperRepository.BrowseAllAsyncBy(country, name);
            return jumpers.Select(SkiJumperDTO.from);
        }

        public async Task AddSkiJumper(CreateSkiJumper request)
        {
            await _skiJumperRepository.AddAsync(
                new SkiJumper()
                {
                    Country = request.Country,
                    Name = request.Name,
                    Surname = request.Surname
                });
        }

        public async Task EditSkiJumper(UpdateSkiJumper request, int id)
        {
            var jumper = await _skiJumperRepository.GetAsync(id);
            if(request.Name != null) jumper.Name = request.Name;
            if(request.Surname != null) jumper.Surname = request.Surname;
            if(request.Country != null) jumper.Country = request.Country;
            await _skiJumperRepository.UpdateAsync(jumper);
        }

        public async Task DeleteJkiJumper(int id)
        {
            var jumper = await _skiJumperRepository.GetAsync(id);
            await _skiJumperRepository.DelAsync(jumper);
        }
    }
}