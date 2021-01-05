using SocialMediaApp.Models;
using SocialMediaApp.ViewModels;
using SocialMediaApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SocialMediaApp.Views
{
    public partial class MyItemsPage : ContentPage
    {
        ItemsViewModel _viewModel;

        public MyItemsPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new ItemsViewModel(false);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}