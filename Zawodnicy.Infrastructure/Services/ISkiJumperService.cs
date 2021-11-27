using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Zawodnicy.Core.Domain;
using Zawodnicy.Infrastructure.DTO;

namespace Zawodnicy.Infrastructure.Services
{
    public interface ISkiJumperService
    {
        Task<IEnumerable<SkiJumperDTO>> BrowseAll();
    }
}