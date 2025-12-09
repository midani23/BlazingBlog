using blazingBlog.Domain.Articles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blazingBlog.Application.Common.Interfaces
{
    public interface IArticlesRepository
    {
        Task AddArticleAsync(Article article);
        Task<bool> ExistsAsync(Guid id);
        Task<Article?> GetByAdminIdAsync(Guid adminId);
        Task<Article?> GetByIdAsync(Guid id);
        Task<List<Article>> ListAsync();
        Task RemoveSubscriptionAsync(Article article);
        Task UpdateAsync(Article article);
    }
}
