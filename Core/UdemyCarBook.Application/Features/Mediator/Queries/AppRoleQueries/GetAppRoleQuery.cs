﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Results.AppRoleResults;
using UdemyCarBook.Application.Features.Mediator.Results.AppUserResults;

namespace UdemyCarBook.Application.Features.Mediator.Queries.AppRoleQueries
{
    public class GetAppRoleQuery : IRequest<List<GetAppRoleQueryResult>>
    {
    }
}
