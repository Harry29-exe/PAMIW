using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Zawodnicy.Core.Repositories;
using Zawodnicy.Infrastructure.DTO;

namespace UnitTests.Infrastructure.SkiJumperServiceTest
{
    [TestClass]
    public class Get : Template
    {
        protected override Mock<ISkiJumperRepository> createMock()
        {
            var mock = new Mock<ISkiJumperRepository>();
            mock.Setup(repo => repo.GetAsync(It.IsAny<int>()))
                .Returns<int>(async id => id > 0 && id < 4? DB[id - 1]: null);
            return mock;
        }

        [TestMethod]
        public async Task shouldGetUser()
        {
            //given
            this.addAllToDB();
            
            //when
            var jumper = await Service.GetSkiJumper(2);
            
            //then
            var shouldBeReturned = SkiJumperDTO.from(DB[1]);
            Assert.IsTrue(jumper.Equals(shouldBeReturned));
        } 
        
        [TestMethod]
        public async Task should_return_null()
        {
            //given
            this.addAllToDB();
            
            //when
            var jumper = await Service.GetSkiJumper(4);
            
            //then
            Assert.IsTrue(jumper == null);
        } 
        
        
    }
}