using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zawodnicy.Core.Domain;
using Zawodnicy.Infrastructure.Repositories;

namespace Zawodnicy.Core.Repositories
{
    public class SkiJumperRepository : ISkiJumperRepository
    {
        private AppDbContext _appDbContext;

        public SkiJumperRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task AddAsync(SkiJumper entity)
        {
            try
            {
                _appDbContext.SkiJumper.Add(entity);
                _appDbContext.SaveChanges();
                await Task.CompletedTask;
            }
            catch (Exception ex)
            {
                await Task.FromException(ex);
            }
        }
        
        public async Task UpdateAsync(SkiJumper entity)
        {
            try
            {
                var z = _appDbContext.SkiJumper.FirstOrDefault(x => x.Id == entity.Id);
                z.Name = entity.Name;
                z.Country = entity.Country;
                z.Height = entity.Height;
                z.Surname = entity.Surname;
                z.Weight = entity.Weight;
                z.BornDate = entity.BornDate;
                _appDbContext.SaveChanges();

                await Task.CompletedTask;
            }
            catch (Exception ex)
            {
                await Task.FromException(ex);
            }
        }
        
        public async Task DelAsync(SkiJumper entity)
        {
            try
            {
                _appDbContext.Remove(_appDbContext.SkiJumper.FirstOrDefault(x=> x.Id == entity.Id));
                _appDbContext.SaveChanges();
                await Task.CompletedTask;
            }
            catch (Exception ex)
            {
                await Task.FromException(ex);
            }
        }
        
        public async Task<SkiJumper> GetAsync(int id)
        {
            return _appDbContext.SkiJumper.FirstOrDefault(t => t.Id == id);
        }
        
        public async Task<IEnumerable<SkiJumper>> BrowseAllAsync()
        {
            return await Task.FromResult(_appDbContext.SkiJumper);
        }
        
        public async Task<IEnumerable<SkiJumper>> BrowseAllAsyncBy(string country, string name)
        {
            return await Task.FromResult(_appDbContext.SkiJumper
                .Where(j => j.Country.Equals(country) || j.Name.Equals(name)));
        }
    }
}