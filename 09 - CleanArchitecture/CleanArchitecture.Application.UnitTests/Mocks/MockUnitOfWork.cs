
using CleanArchitecture.Infrastructure.Persistence;
using CleanArchitecture.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace CleanArchitecture.Application.UnitTests.Mock
{
    public static class MockUnitOfWork
    {
        public static Mock<UnitOfWork> GetUnitOfWork(){

            // adding inmemory db settings
            Guid dbContextId = Guid.NewGuid();
            var options = new DbContextOptionsBuilder<StreamerDbContext>()
              .UseInMemoryDatabase(databaseName: $"StreamerDbContext-{Guid.NewGuid()}")
              .Options;

            // fake entity framework
            var streamerDbContextFake = new StreamerDbContext(options);
            
            // cleaning rows from dbcontext when use it for tests and assigned to the mock unit of work
            streamerDbContextFake.Database.EnsureDeleted();
            var mockUnitOfWork = new Mock<UnitOfWork>(streamerDbContextFake);


            return mockUnitOfWork;
        }
    }
}
