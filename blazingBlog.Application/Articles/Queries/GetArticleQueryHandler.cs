using blazingBlog.Application.Common.Interfaces;
using blazingBlog.Domain.Articles;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blazingBlog.Application.Articles.Queries
{
    internal class GetArticleQueryHandler(IArticlesRepository articlesRepository) : IRequestHandler<GetArticlesQuery, List<Article>>
    {
        private readonly IArticlesRepository _articlesRepository = articlesRepository;
        public Task<List<Article>> Handle(GetArticlesQuery request, CancellationToken cancellationToken)
        {
            var articles = _articlesRepository.ListAsync();
            return articles;
        }
    }
}
