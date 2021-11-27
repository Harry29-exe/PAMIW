using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Zawodnicy.Core.Domain;
using Zawodnicy.Infrastructure.Commands;
using Zawodnicy.Infrastructure.DTO;

namespace Zawodnicy.Infrastructure.Services
{
    public interface ISkiJumperService
    {
        Task<IEnumerable<SkiJumperDTO>> BrowseAll();

        Task<SkiJumperDTO> GetSkiJumper(int id);

        Task<IEnumerable<SkiJumperDTO>>  GetSkiJumpers(string country, string name);

        Task AddSkiJumper(CreateSkiJumper request);

        Task EditSkiJumper(UpdateSkiJumper request, int id);

        Task DeleteJkiJumper(int id);
        
    }
}