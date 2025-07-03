using Laboratorio.Application.Contracts.Persistence;
using Laboratorio.Domain;
using Laboratorio.Infrastructure.Persistence;



namespace Laboratorio.Infrastructure.Repositories
{
    public class DirectorRepository: RepositoryBase<Director>, IDirectorRepository
    {
        public DirectorRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
   
}