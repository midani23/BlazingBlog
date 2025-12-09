using blazingBlog.Application.Common.Interfaces;
using blazingBlog.Domain.Articles;
using BlazingBlog.Infrastructure.Common.Persistance;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazingBlog.Infrastructure.Articles.Persistence
{
    internal class ArticleRepository(ApplicationDbContext dbContext) : IArticlesRepository
    {
        private readonly ApplicationDbContext _dbContext = dbContext;
        public Task AddArticleAsync(Article article)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Article?> GetByAdminIdAsync(Guid adminId)
        {
            throw new NotImplementedException();
        }

        public Task<Article?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Article>> ListAsync()
        {
            return await _dbContext.Articles.ToListAsync();
        }

        public Task RemoveSubscriptionAsync(Article article)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Article article)
        {
            throw new NotImplementedException();
        }
    }
}
