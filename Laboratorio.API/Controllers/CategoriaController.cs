using Laboratorio.Application.Features.Categorias.Commands.CreateCategoria;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Laboratorio.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CategoriaController : ControllerBase
    {
        private IMediator _mediator;

        public CategoriaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "CreateCategoria")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreateCategoria([FromBody] CreateCategoriaCommand command)
        {
            return await _mediator.Send(command);
        }

    }
}
