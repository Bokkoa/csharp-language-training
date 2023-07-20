using AutoMapper;
using CleanArchitecture.Application.Contracts.Persistence;
using MediatR;

namespace CleanArchitecture.Application.Features.Videos.Queries.GetVideosList
{
    public class GetVideosListQueryHandler : IRequestHandler<GetVideosListQuery, List<VideosVM>>
    {
        //private readonly IVideoRepository _videoRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetVideosListQueryHandler( /* IVideoRepository videoRepository */ IUnitOfWork unitOfWork , IMapper mapper)
        {
            //_videoRepository = videoRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<VideosVM>> Handle(GetVideosListQuery request, CancellationToken cancellationToken)
        {
            //var videoList = await _videoRepository.GetVideoByUsername(request._Username);
            var videoList = await _unitOfWork.VideoRepository.GetVideoByUsername(request._Username);
            return _mapper.Map<List<VideosVM>>(videoList);
        }
    }
}
