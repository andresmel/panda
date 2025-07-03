using Laboratorio.Application.Contracts.Persistence;
using Laboratorio.Domain;
using Laboratorio.Infrastructure.Persistence;

namespace Laboratorio.Infrastructure.Repositories
{
    public class StreamerRepository : RepositoryBase<Streamer>, IStreamerRepository
    {
        public StreamerRepository(ApplicationDbContext context) : base(context)
        { }
    }
}
