using System;
using Xamarin.Forms;
using AutoComplete_in_ListView.ViewModels;

namespace AutoComplete_in_ListView
{
    public partial class PickerPage : ContentPage
    {
        public PickerPage()
        {
            InitializeComponent();

            BindingContext = new PickerPageViewModel();
        }
    }
}
