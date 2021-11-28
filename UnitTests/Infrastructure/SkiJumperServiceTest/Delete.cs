using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Zawodnicy.Core.Domain;
using Zawodnicy.Core.Repositories;

namespace UnitTests.Infrastructure.SkiJumperServiceTest
{
    [TestClass]
    public class Delete : Template
    {
        protected override Mock<ISkiJumperRepository> createMock()
        {
            var mock = new Mock<ISkiJumperRepository>();
            mock.Setup(repo => repo.DelAsync(It.IsAny<SkiJumper>()))
                .Callback<SkiJumper>(j => DB.Remove(j));
            mock.Setup(repo => repo.GetAsync(It.IsAny<int>()))
                .Returns<int>(async id => DB.Find(j => j.Id == id));

            return mock;
        }

        [TestMethod]
        public async Task should_delete_user()
        {
            //given
            this.addAllToDB();
            var userToDeleteId = 2;
            
            //when
            Service.DeleteJkiJumper(userToDeleteId);
            
            //then
            Assert.IsTrue(DB.Find(j => j.Id == userToDeleteId) == null);
        }
        
        [TestMethod]
        public async Task should_not_delete_not_existing_jumper()
        {
            //given
            this.addAllToDB();
            var userToDeleteId = 4;
            
            //when
            Service.DeleteJkiJumper(userToDeleteId);
            
            //then
            Assert.IsTrue(DB.Count == 3);
        }
    }
}