using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Components;
using blazingBlog.Domain.Articles;
using blazingBlog.Application.Articles.Queries;

namespace blazingBlog.WebUI.Server.Components.Pages.Articles
{
    public partial class Articles
    {
        private List<Article> articles = new();

        [Inject]
        public ISender Sender { get; set; } = null!;

        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(1000);

            var result = await Sender.Send(new GetArticlesQuery());
            if (result is not null)
                articles = result;
        }
    }
}