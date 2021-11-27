using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Zawodnicy.Core.Domain;
using Zawodnicy.Core.Repositories;
using Zawodnicy.Infrastructure.Services;

namespace UnitTests.Infrastructure.SkiJumperServiceTest
{
    public abstract class Template
    {
        protected ISkiJumperRepository Repo;
        protected ISkiJumperService Service;
        protected List<SkiJumper> DB;
        
        protected abstract Mock<ISkiJumperRepository> createMock();

        [TestInitialize]
        public void initRepoDB()
        {
            DB = new List<SkiJumper>();
            var mock = createMock();
            Repo = mock.Object;
            Service = new SkiJumperService(Repo);
        }
        
    }
    
    
    
}