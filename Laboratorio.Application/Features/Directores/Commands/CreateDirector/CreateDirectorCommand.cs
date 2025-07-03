using MediatR;

namespace Laboratorio.Application.Features.Director.Commands.CreateDirector
{
    public class CreateDirectorCommand : IRequest<int>
    {
        public string Nombre { get; set; } = string.Empty;

        public string Nacionalidad { get; set; } = string.Empty;

    }
}
