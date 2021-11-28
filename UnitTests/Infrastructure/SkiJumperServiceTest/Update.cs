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
            // mock.Setup(repo => repo.AddAsync(It.IsAny<SkiJumper>()))
            //     .Callback<SkiJumper>(e =>
            //     {
            //         e.Id = DB.Count + 1;
            //         DB.Add(e);
            //     });

            return mock;
        }

        [TestMethod]
        public void should_update_jumper_country()
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
            Service.EditSkiJumper(update, (int) u1.Id);
            
            //then
            var testUser = Utils.CreateJumper1();
            testUser.Country = newCountry;
            Assert.IsTrue(testUser.Equals(DB[0]));
        }
        
        [TestMethod]
        public void should_update_jumper_when_many_jumpers_in_db()
        {
            //given
            var u1 = Utils.CreateJumper1();
            var u2 = Utils.CreateJumper2();
            var u3 = Utils.CreateJumper3();
            DB.Add(u1);
            var newCountry = "us";
            
            //when
            var update = new UpdateSkiJumper()
            {
                Country = newCountry
            };
            Service.EditSkiJumper(update, (int) u2.Id);
            
            //then
            var testUser = Utils.CreateJumper2();
            testUser.Country = newCountry;
            Assert.IsTrue(testUser.Equals(DB[1]));
        }
        
    }
}