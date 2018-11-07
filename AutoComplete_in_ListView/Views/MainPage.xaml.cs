using System;
using Xamarin.Forms;
using AutoComplete_in_ListView.ViewModels;

namespace AutoComplete_in_ListView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new MainPageViewModel(Navigation);
        }
    }
}
