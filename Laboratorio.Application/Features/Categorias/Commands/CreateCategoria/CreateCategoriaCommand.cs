using MediatR;

namespace Laboratorio.Application.Features.Categorias.Commands.CreateCategoria
{
    public class CreateCategoriaCommand : IRequest<int>
    {
        public string Nombre { get; set; } = string.Empty;

        public string De { get; set; } = string.Empty;

    }
}