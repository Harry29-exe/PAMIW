using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Zawodnicy.Core.Domain;

namespace Zawodnicy.Core.Repositories
{
    public class SkiJumperRepository : ISkiJumperRepository
    {
        public static List<SkiJumper> _skiJumperMock = new List<SkiJumper>();
        
        public SkiJumperRepository() {
            _skiJumperMock.Add(new SkiJumper()
            {
                Id = 1,
                Name = "Alan",
                Surname = "G",
                Country = "pol",
                Weight = 170
            });

            _skiJumperMock.Add(new SkiJumper()
            {
                Id = 2,
                Name = "Adam",
                Surname = "P",
                Country = "ger",
                Weight = 172
            });

            _skiJumperMock.Add(new SkiJumper()
            {
                Id = 3,
                Name = "Martin",
                Surname = "S",
                Country = "fin",
                Weight = 172
            });
        }

        public Task AddAsync(SkiJumper entity)
        {
            _skiJumperMock.Add(entity);

            return Task.CompletedTask;
        }

        public Task UpdateAsync(SkiJumper entity)
        {
            var index = _skiJumperMock.IndexOf(entity);
            if (index < 0)
            {
                throw new ArgumentException();
            }
            _skiJumperMock.RemoveAt(index);
            _skiJumperMock.Add(entity);
            
            return Task.CompletedTask;
        }

        public Task DelAsync(SkiJumper entity)
        {
            _skiJumperMock.Remove(entity);
            
            return Task.CompletedTask;
        }

        public Task<SkiJumper> GetAsync(long id)
        {
            return Task.FromResult(_skiJumperMock.Find(jumper => jumper.Id == id));
        }

        public async Task<IEnumerable<SkiJumper>> BrowseAllAsync()
        {
            return await Task.FromResult(_skiJumperMock);
        }
    }
}