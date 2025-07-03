using Laboratorio.Domain.Common;

namespace Laboratorio.Domain
{
    public class Director : BaseDomainModel
    {
        public string ?Nombre { get; set; }

        public string ?Nacionalidad { get; set; }    

        public ICollection<Video> ?Videos { get; set; }
    }
}
