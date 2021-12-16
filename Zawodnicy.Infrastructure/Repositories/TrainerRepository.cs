using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zawodnicy.Core.Domain;
using Zawodnicy.Infrastructure.Repositories;

namespace Zawodnicy.Core.Repositories
{
    public class TrainerRepository : ICrudRepository<long, Trainer>
    {
        private AppDbContext _appDbContext;

        public TrainerRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task AddAsync(Trainer entity)
        {
            try
            {
                _appDbContext.Trainer.Add(entity);
                _appDbContext.SaveChanges();
                await Task.CompletedTask;
            }
            catch (Exception ex)
            {
                await Task.FromException(ex);
            }

        }

        public async Task UpdateAsync(Trainer entity)
        {
            try
            {
                var t = _appDbContext.Trainer.FirstOrDefault(t => t.Id == entity.Id);
                t.Birthday = entity.Birthday;
                t.Name = entity.Name;
                t.Surname = entity.Surname;
                _appDbContext.SaveChanges();
                
                await Task.CompletedTask;
            }
            catch (Exception ex)
            {
                await Task.FromException(ex);
            }
        }

        public async Task DelAsync(Trainer entity)
        {
            try
            {
                var t = _appDbContext.Trainer
                    .FirstOrDefault(t => t.Id == entity.Id);
                _appDbContext.Trainer.Remove(t);
                
                await Task.CompletedTask;
            }
            catch (Exception ex)
            {
                await Task.FromException(ex);
            }
        }

        public async Task<Trainer> GetAsync(long id)
        {
            return _appDbContext.Trainer.FirstOrDefault(t => t.Id == id);
        }

        public async Task<IEnumerable<Trainer>> BrowseAllAsync()
        {
            return _appDbContext.Trainer;
        }
    }
}