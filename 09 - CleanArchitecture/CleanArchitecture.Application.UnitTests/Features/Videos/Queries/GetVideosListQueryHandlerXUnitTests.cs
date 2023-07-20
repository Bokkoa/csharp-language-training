using AutoMapper;
using CleanArchitecture.Application.UnitTests.Mock;
using CleanArchitecture.Application.Mappings;
using Moq;
using Xunit;
using CleanArchitecture.Application.Features.Videos.Queries.GetVideosList;
using Shouldly;
using CleanArchitecture.Infrastructure.Repositories;

namespace CleanArchitecture.Application.UnitTests.Features.Videos.Queries
{
    public class GetVideosListQueryHandlerXUnitTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<UnitOfWork> _unitOfWork;

        public GetVideosListQueryHandlerXUnitTests()
        {
            _unitOfWork = MockUnitOfWork.GetUnitOfWork();
            var mapperConfig = new MapperConfiguration(c =>
            {
                c.AddProfile<MappingProfile>();
            });

            _mapper = mapperConfig.CreateMapper();

            MockVideoRepository.AddDataVideoRepository(_unitOfWork.Object.StreamerDbContext);
        }

        [Fact]
        public async Task GetVideoListTest()
        {
            var handler = new GetVideosListQueryHandler(_unitOfWork.Object, _mapper);
            var request = new GetVideosListQuery("Bokkoa");
            var result = await handler.Handle(request, CancellationToken.None);

            result.ShouldBeOfType<List<VideosVM>>();
            result.Count.ShouldBe(1);
        }
    }
}
