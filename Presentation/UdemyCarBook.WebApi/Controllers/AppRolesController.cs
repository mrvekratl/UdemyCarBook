using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Queries.AppRoleQueries;
using UdemyCarBook.Application.Features.Mediator.Queries.AuthorQueries;

namespace UdemyCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppRolesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AppRolesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> AppRoleList()
        {
            var values = await _mediator.Send(new GetAppRoleQuery());
            return Ok(values);
        }

    }
}
