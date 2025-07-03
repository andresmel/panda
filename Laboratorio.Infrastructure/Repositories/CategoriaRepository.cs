using Laboratorio.Application.Contracts.Persistence;
using Laboratorio.Domain;
using Laboratorio.Infrastructure.Persistence;



namespace Laboratorio.Infrastructure.Repositories
{
    public class CategoriaRepository : RepositoryBase<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(ApplicationDbContext context) : base(context)
        {
        }

       
    }
}
