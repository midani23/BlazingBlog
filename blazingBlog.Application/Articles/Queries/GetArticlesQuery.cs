using blazingBlog.Domain.Articles;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blazingBlog.Application.Articles.Queries
{
    public class GetArticlesQuery : IRequest<List<Article>>
    {
    }
}
