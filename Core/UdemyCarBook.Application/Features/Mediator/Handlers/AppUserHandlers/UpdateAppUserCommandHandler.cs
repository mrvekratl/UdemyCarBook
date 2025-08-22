using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Commands.AppUserCommands;
using UdemyCarBook.Application.Features.Mediator.Commands.AuthorCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.AppUserHandlers
{
    public class UpdateAppUserCommandHandler : IRequestHandler<UpdateAppUserCommand>
    {
        private readonly IRepository<AppUser> _repository;
        public UpdateAppUserCommandHandler(IRepository<AppUser> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateAppUserCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.AppUserId);
            values.Name = request.Name;
            values.Surname = request.Surname;
            values.Email = request.Email;
            values.Username = request.Username;
            values.Password = request.Password;
            values.AppRoleId = request.AppRoleId;
            await _repository.UpdateAsync(values);
        }
    }
}
