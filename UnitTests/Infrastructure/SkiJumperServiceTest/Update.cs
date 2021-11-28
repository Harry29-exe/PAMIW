using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Zawodnicy.Core.Domain;
using Zawodnicy.Core.Repositories;
using Zawodnicy.Infrastructure.Commands;

namespace UnitTests.Infrastructure.SkiJumperServiceTest
{
    [TestClass]
    public class Update : Template
    {
        protected override Mock<ISkiJumperRepository> createMock()
        {
            var mock = new Mock<ISkiJumperRepository>();
            mock.Setup(repo =>
                    repo.UpdateAsync(It.IsAny<SkiJumper>()))
                .Callback<SkiJumper>(enity =>
                {
                    var index = DB.FindIndex(j => j.Id == enity.Id);
                    DB.RemoveAt(index);
                    DB.Add(enity);
                });
            mock.Setup(repo => repo.GetAsync(It.IsAny<int>()))
                .Returns<int>(async (id) => DB[id-1]);

            return mock;
        }

        [TestMethod]
        public async Task should_update_jumper_country()
        {
            //given
            var u1 = Utils.CreateJumper1();
            DB.Add(u1);
            var newCountry = "us";
            
            //when
            var update = new UpdateSkiJumper()
            {
                Country = newCountry
            };
            await Service.EditSkiJumper(update, u1.Id);
            
            //then
            var testUser = Utils.CreateJumper1();
            testUser.Country = newCountry;
            Assert.IsTrue(testUser.Equals(DB[0]));
        }
        
        [TestMethod]
        public async Task should_update_jumper_when_many_jumpers_in_db()
        {
            //given
            var u1 = Utils.CreateJumper1();
            var u2 = Utils.CreateJumper2();
            var u3 = Utils.CreateJumper3();
            DB.Add(u1);
            DB.Add(u2);
            DB.Add(u3);
            var newCountry = "us";
            
            //when
            var update = new UpdateSkiJumper()
            {
                Country = newCountry
            };
            await Service.EditSkiJumper(update, u2.Id);
            
            //then
            var testUser = Utils.CreateJumper2();
            testUser.Country = newCountry;
            Assert.IsTrue(testUser.Equals(DB.Find(j => j.Id == u2.Id)));
        }
        
    }
}