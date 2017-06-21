using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Refit;

namespace ArticleViewer
{
    public class NewsService
    {
        private String articlesBaseURL = "https://newsapi.org";
        private IGoogleNewsApi newsApi;

        public NewsService()
        {
            newsApi = RestService.For<IGoogleNewsApi>(articlesBaseURL);
        }

        public async Task<NewsResponse> getTopGoogleNews()
        {
            return await newsApi.getTopGoogleNews();
        }
    }
}
