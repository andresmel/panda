using Laboratorio.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio.Domain
{
    public class Categoria : BaseDomainModel
    {
        public string? Nombre { get; set; }
        public string ?Descripcion { get; set; }
        public ICollection<Video>? Videos { get; set; }
    }
}
