using Laboratorio.Application.Contracts.Persistence;
using Laboratorio.Domain.Common;
using Laboratorio.Infrastructure.Persistence;
using System.Collections;

namespace Laboratorio.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private Hashtable _repositories;
        private readonly ApplicationDbContext _context;

        private IVideoRepository _videoRepository;
        private IStreamerRepository _streamerRepository;
        private ICategoriaRepository _categoriaRepository;


        public IVideoRepository VideoRepository => _videoRepository ??= new VideoRepository(_context);

        public IStreamerRepository StreamerRepository => _streamerRepository ??= new StreamerRepository(_context);

        public ICategoriaRepository CategoriaRepository => _categoriaRepository ??= new CategoriaRepository(_context);

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public ApplicationDbContext applicationDbContext => _context;

        public async Task<int> Complete()
        {
            try
            {
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Err");
            }

        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public IAsyncRepository<TEntity> Repository<TEntity>() where TEntity : BaseDomainModel
        {
            if (_repositories == null)
            {
                _repositories = new Hashtable();
            }

            var type = typeof(TEntity).Name;

            if (!_repositories.ContainsKey(type))
            {
                var repositoryType = typeof(RepositoryBase<>);
                var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(TEntity)), _context);
                _repositories.Add(type, repositoryInstance);
            }

            return (IAsyncRepository<TEntity>)_repositories[type];
        }

    }
}
