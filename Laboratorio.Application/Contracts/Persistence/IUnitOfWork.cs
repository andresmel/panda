using Laboratorio.Domain.Common;

namespace Laboratorio.Application.Contracts.Persistence
{
    public interface IUnitOfWork : IDisposable
    {

        IStreamerRepository StreamerRepository { get; }
        IVideoRepository VideoRepository { get; }
        ICategoriaRepository CategoriaRepository { get; }

        IAsyncRepository<TEntity> Repository<TEntity>() where TEntity : BaseDomainModel;

        Task<int> Complete();
    }
}
