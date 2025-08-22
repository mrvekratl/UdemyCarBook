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
using UdemyCarBook.Application.Interfaces.AppUserInterfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.AppUserHandlers
{
    public class GetAppUserQueryHandler : IRequestHandler<GetAppUserQuery, List<GetAppUserQueryResult>>
    {
        private readonly IAppUserRepository _repository;

        public GetAppUserQueryHandler(IAppUserRepository repository)
        {
            _repository = repository;
        }

        public async  Task<List<GetAppUserQueryResult>> Handle(GetAppUserQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            values = _repository.GetAllWithAppRoleName();
            return values.Select(x => new GetAppUserQueryResult
            {
                AppUserId = x.AppUserId,
                AppRoleId = x.AppRoleId,
                Email = x.Email,
                Name = x.Name,
                Password = x.Password,
                Surname = x.Surname,
                Username = x.Username,
                AppRoleName = x.AppRole.AppRoleName
            }).ToList();
        }
    }
}
