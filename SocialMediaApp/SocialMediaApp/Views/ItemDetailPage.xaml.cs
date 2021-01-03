using SocialMediaApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace SocialMediaApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}