using Laboratorio.Domain.Common;

namespace Laboratorio.Domain
{
    public class Video : BaseDomainModel
    {

        public string? Nombre { get; set; }

        public int StreamerId { get; set; }

        public int Duracion { get; set; }

        public virtual Streamer? Streamer { get; set; }

    }
}
