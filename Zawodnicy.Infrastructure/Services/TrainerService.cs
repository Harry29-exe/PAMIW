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
    public class TrainerService : ITrainerService
    {
        private TrainerRepository _trainerRepository;

        public TrainerService(TrainerRepository trainerRepository)
        {
            _trainerRepository = trainerRepository;
        }

        public async Task<TrainerDTO> get(long id)
        {
            var t = await _trainerRepository.GetAsync(id);
            return TrainerDTO.@from(t);
        }

        public async Task<IEnumerable<TrainerDTO>> getAll()
        {
            var z = await _trainerRepository.BrowseAllAsync();
            return z.Select(t => TrainerDTO.@from(t));
        }

        public async Task delete(long id)
        {
            var t = await _trainerRepository.GetAsync(id);
            await _trainerRepository.DelAsync(t);
        }

        public async Task create(CreateTrainer ct)
        {
            var t = new Trainer()
            {
                Name = ct.Name,
                Surname = ct.Name
            };
            await _trainerRepository.AddAsync(t);
        }

        public async Task update(UpdateTrainer ut, long id)
        {
            var t = new Trainer()
            {
                Id = id,
                Name = ut.Name,
                Surname = ut.Surname,
                Birthday = ut.Birthday
            };
            await _trainerRepository.UpdateAsync(t);
        }
    }
}