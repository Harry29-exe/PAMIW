using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Zawodnicy.Core.Domain;
using Zawodnicy.Core.Repositories;
using Zawodnicy.Infrastructure.Commands;
using Zawodnicy.Infrastructure.Services;

namespace UnitTests.Infrastructure.SkiJumperServiceTest
{
    [TestClass]
    public class Create : Template
    {
        protected override Mock<ISkiJumperRepository> createMock()
        {
            var mock = new Mock<ISkiJumperRepository>();
            mock.Setup(repo => 
                    repo.AddAsync(It.IsAny<SkiJumper>()))
                .Callback<SkiJumper>(jumper => DB.Add(jumper));

            return mock;
        }

        [TestMethod]
        public void should_crete_new_user_with_empty_db()
        {
            //given
            var user = new CreateSkiJumper()
            {
                Country = "pl",
                Name = "Alex",
                Surname = "Smith"
            };
            
            //when
            Service.AddSkiJumper(user);
            
            //then
            Assert.IsTrue(DB.Count == 1);
            var userIdDb = DB[0];
            Assert.IsTrue(
                userIdDb.Country.Equals(user.Country) &&
                userIdDb.Name.Equals(user.Name) &&
                userIdDb.Surname.Equals(user.Surname)
                );
        }
        
        [TestMethod]
        public void should_crete_new_user()
        {
            //given
            DB.Add(
                Utils.CreateJumper1()
                );
            var user = new CreateSkiJumper()
            {
                Country = "pl",
                Name = "Alex",
                Surname = "Smith"
            };
            
            //when
            Service.AddSkiJumper(user);
            
            //then
            Assert.IsTrue(DB.Count == 2);
            Assert.IsTrue(
                Utils.CreateJumper1().Equals(DB[0])
                );
            
            var userIdDb = DB[1];
            Assert.IsTrue(
                userIdDb.Country.Equals(user.Country) &&
                userIdDb.Name.Equals(user.Name) &&
                userIdDb.Surname.Equals(user.Surname)
            );
        }
        
    }
}