using AutoMapper;
using CleanArchitecture.Application.Features.Streamers.Commands.CreateStreamer;
using CleanArchitecture.Application.Features.Videos.Queries.GetVideosList;
using CleanArchitecture.Domain;

namespace CleanArchitecture.Application.Mappings
{
    internal class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Video, VideosVM>();
            CreateMap<CreaterStreamerCommand, Streamer>();
        }
    }
}
