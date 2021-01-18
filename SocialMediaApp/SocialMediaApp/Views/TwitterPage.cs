using System.IO;
using System.Net;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SocialMediaApp.Views
{
    public class TwitterPage : ContentPage
    {

        public TwitterPage()
        {

            ShowPage();

        }

        public async void ShowPage()
        {
            var browser = new WebView
            {
                Source = "https://twitter.com/search?q=%23collegescholarships"
            };

            Content = browser;

        }

    }
}