using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Results.CommentResults;
using UdemyCarBook.Application.Features.Mediator.Results.FeatureResults;

namespace UdemyCarBook.Application.Features.Mediator.Queries.CommentQueries
{
    public class GetAllCommentListWithBlogTitleQuery: IRequest<List<GetAllCommentListWithBlogTitleResult>>
    {
    }
}
