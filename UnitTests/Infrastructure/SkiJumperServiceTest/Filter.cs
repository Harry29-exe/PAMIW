using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Zawodnicy.Core.Repositories;
using Zawodnicy.Infrastructure.DTO;

namespace UnitTests.Infrastructure.SkiJumperServiceTest
{
    [TestClass]
    public class Filter : Template
    {
        protected override Mock<ISkiJumperRepository> createMock()
        {
            var mock = new Mock<ISkiJumperRepository>();
            mock.Setup(repo => 
                    repo.BrowseAllAsyncBy(It.IsAny<string>(), It.IsAny<string>()))
                .Returns<string, string>(async (c, n) =>
                    DB.FindAll(j => j.Country.Equals(c) || j.Name.Equals(n)
                ));

            return mock;
        }

        [TestMethod]
        public async Task should_find_all_matching()
        {
            //given
            this.addAllToDB();
            
            //when
            var results = await Service.GetSkiJumpers("pol", "Adam");
            var resultList = new List<SkiJumperDTO>(results);
            
            //then
            Assert.IsTrue(resultList.Count == 2);
        }
        
        [TestMethod]
        public async Task should_find_all_matching2()
        {
            //given
            this.addAllToDB();
            
            //when
            var results = await Service.GetSkiJumpers("", "Adam");
            var resultList = new List<SkiJumperDTO>(results);
            
            //then
            Assert.IsTrue(resultList.Count == 1);
        }
    }
}