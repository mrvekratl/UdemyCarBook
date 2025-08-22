using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Queries.CommentQueries;
using UdemyCarBook.Application.Features.Mediator.Results.CommentResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Application.Interfaces.CommentInterfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.CommentHandlers
{
    public class GetAllCommentListWithBlogTitleQueryHandler : IRequestHandler<GetAllCommentListWithBlogTitleQuery, List<GetAllCommentListWithBlogTitleResult>>
    {
        private readonly ICommentRepository _repository;

        public GetAllCommentListWithBlogTitleQueryHandler(ICommentRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetAllCommentListWithBlogTitleResult>> Handle(GetAllCommentListWithBlogTitleQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetAllWithBlog();

            return values.Select(x => new GetAllCommentListWithBlogTitleResult
            {
                BlogTitle = x.Blog.Title,
                CommentID = x.CommentID,
                CreatedDate = x.CreatedDate,
                Description = x.Description,
                Name = x.Name
            }).ToList();

        }
    }
}
