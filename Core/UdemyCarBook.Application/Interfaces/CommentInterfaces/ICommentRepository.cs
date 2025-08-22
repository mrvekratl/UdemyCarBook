﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.RepositoryPattern;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Interfaces.CommentInterfaces
{
    public interface ICommentRepository : IGenericRepository<Comment>
    {
        List<Comment> GetAllWithBlog();
    }
}
