using Laboratorio.Domain;

namespace Laboratorio.Application.Contracts.Persistence
{
    public interface IVideoRepository : IAsyncRepository<Video>
    {
        Task<Video> GetVideoByNombre(string nombreVideo);
        Task<IEnumerable<Video>> GetVideoByStreamerId(int streamerId);
    }
}
