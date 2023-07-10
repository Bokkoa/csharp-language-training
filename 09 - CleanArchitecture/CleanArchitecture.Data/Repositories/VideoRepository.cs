
using CleanArchitecture.Application.Contracts.Persistence;
using CleanArchitecture.Domain;
using CleanArchitecture.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class VideoRepository : RepositoryBase<Video>, IVideoRepository
    {
        public VideoRepository(StreamerDbContext context): base(context) { }
 

        public async Task<Video> GetVideoByName(string videoName)
        {
            var video = await _context.Videos!.Where(v => v.Name == videoName).FirstOrDefaultAsync();
            return video;
        }

        public async Task<IEnumerable<Video>> GetVideoByUsername(string username)
        {
            var videos = await _context.Videos!.Where(v => v.CreatedBy == username).ToListAsync();
            return videos;
        }
  
    }
}
