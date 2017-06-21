using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace ArticleViewer.Droid
{
	[Activity (Label = "ArticleViewer.Android", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
        private NewsService news;

        protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
            news = new NewsService();

            button.Click += delegate {
                getNews();
            };
		}


        private async void getNews()
        {
            NewsResponse response = await news.getTopGoogleNews();

            foreach (Article a in response.articles)
            {
                Toast.MakeText(this, a.title, ToastLength.Short).Show();
            }
        }
    }
}


