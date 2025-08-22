using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Queries.AppUserQueries;
using UdemyCarBook.Application.Features.Mediator.Queries.AuthorQueries;
using UdemyCarBook.Application.Features.Mediator.Results.AppUserResults;
using UdemyCarBook.Application.Features.Mediator.Results.AuthorResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.AppUserHandlers
{
    public class GetAppUserByIdQueryHandler : IRequestHandler<GetAppUserByIdQuery, GetAppUserByIdQueryResult>
    {
        private readonly IRepository<AppUser> _repository;

        public GetAppUserByIdQueryHandler(IRepository<AppUser> repository)
        {
            _repository = repository;
        }
        public async Task<GetAppUserByIdQueryResult> Handle(GetAppUserByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetAppUserByIdQueryResult
            {
                Name = values.Name,
                AppRoleId = values.AppRoleId,
                Email = values.Email,
                AppUserId = values.AppUserId,
                Username = values.Username,
                Surname = values.Surname,
                Password = values.Password

            };
        }
    }
}
