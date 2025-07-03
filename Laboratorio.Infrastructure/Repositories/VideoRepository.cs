using Laboratorio.Application.Contracts.Persistence;
using Laboratorio.Domain;
using Laboratorio.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Laboratorio.Infrastructure.Repositories
{
    public class VideoRepository : RepositoryBase<Video>, IVideoRepository
    {
        public VideoRepository(ApplicationDbContext context) : base(context)
        {
        }
        public async Task<Video> GetVideoByNombre(string nombreVideo)
        {
            return await _context.Videos!.Where(o => o.Nombre == nombreVideo).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Video>> GetVideoByStreamerId(int streamerId)
        {
            return await _context.Videos!.Where(v => v.StreamerId == streamerId).ToListAsync();
        }
    }
}
