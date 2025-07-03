using Laboratorio.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio.Application.Contracts.Persistence
{
    public interface IDirectorRepository:IAsyncRepository<Director>
    {
        
    }
}
