using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Refit;

namespace ArticleViewer
{
    interface IGoogleNewsApi
    {
        [Get("/v1/articles/?source=google-news&sortBy=top&apiKey=410405dccc5543b1b2012a30be0383ad")]
        Task<NewsResponse> getTopGoogleNews();
    }
}
