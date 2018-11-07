using AutoComplete_in_ListView.ViewModels;
using Xamarin.Forms;

namespace AutoComplete_in_ListView
{
    public partial class AutoCompletePage : ContentPage
    {
        public AutoCompletePage()
        {
            InitializeComponent();

            BindingContext = new AutoCompletePageViewModel();
        }
    }
}
