using MediatR;

namespace Laboratorio.Application.Features.Videos.Commands.CreateVideo
{
    public class CreateVideoCommand : IRequest<int>
    {
        public string Nombre { get; set; } = string.Empty;

        public string StreamerId { get; set; } = string.Empty;

        public string Duracion { get; set; } = string.Empty;

        public string CategoriaId { get; set; } = string.Empty;

    }
}