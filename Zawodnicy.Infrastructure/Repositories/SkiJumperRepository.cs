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
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(SkiJumper entity)
        {
            throw new System.NotImplementedException();
        }

        public Task DelAsync(SkiJumper entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<SkiJumper> GetAsync(long id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<SkiJumper>> BrowseAllAsync()
        {
            return await Task.FromResult(_skiJumperMock);
        }
    }
}