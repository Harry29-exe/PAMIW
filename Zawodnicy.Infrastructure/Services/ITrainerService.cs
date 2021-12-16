using System.Collections.Generic;
using System.Threading.Tasks;
using Zawodnicy.Infrastructure.Commands;
using Zawodnicy.Infrastructure.DTO;

namespace Zawodnicy.Infrastructure.Services
{
    public interface ITrainerService
    {

        Task<TrainerDTO> get(long id);

        Task delete(long id);

        Task create(CreateTrainer ct);

        Task update(UpdateTrainer ut, long id);

        Task<IEnumerable<TrainerDTO>> getAll();

    }
}