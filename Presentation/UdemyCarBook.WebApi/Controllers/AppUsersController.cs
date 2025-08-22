using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Commands.AppUserCommands;
using UdemyCarBook.Application.Features.Mediator.Commands.AuthorCommands;
using UdemyCarBook.Application.Features.Mediator.Queries.AppUserQueries;
using UdemyCarBook.Application.Features.Mediator.Queries.AuthorQueries;

namespace UdemyCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AppUsersController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> AppUserList()
        {
            var values = await _mediator.Send(new GetAppUserQuery());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAppUser(int id)
        {
            var value = await _mediator.Send(new GetAppUserByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateAppUser(CreateAppUserCommand command)
        {
            await _mediator.Send(command);
            return Ok("Kullanıcı Başarıyla Eklendi.");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveAppUser(int id)
        {
            await _mediator.Send(new RemoveAppUserCommand(id));
            return Ok("Kullanıcı Başarıyla Silindi.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAppUser(UpdateAppUserCommand command)
        {
            await _mediator.Send(command);
            return Ok("Kullanıcı Başarıyla Güncellendi.");
        }
    }
}
