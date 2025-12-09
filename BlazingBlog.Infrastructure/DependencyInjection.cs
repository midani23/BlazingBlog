using blazingBlog.Application.Articles;
using blazingBlog.Application.Common.Interfaces;
using BlazingBlog.Infrastructure.Articles.Persistence;
using BlazingBlog.Infrastructure.Common.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazingBlog.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IArticlesRepository, ArticleRepository>();

            return services;
        }
    }
}
