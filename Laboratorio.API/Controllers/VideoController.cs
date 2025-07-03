using Laboratorio.Application.Features.Categorias.Commands.CreateCategoria;
using Laboratorio.Application.Features.Videos.Commands.CreateVideo;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Laboratorio.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class VideoController : ControllerBase
    {
        private IMediator _mediator;

        public VideoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "CreateVideo")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreateVideo([FromBody] CreateVideoCommand command)
        {
            return await _mediator.Send(command);
        }

    }
}
