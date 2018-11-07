using System;
using Xamarin.Forms;

namespace AutoComplete_in_ListView.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        readonly INavigation _navigation;

        private Command _showAutoCompleteListCommand;
        private Command _showPickerListCommand;

        public Command ShowAutoCompleteListCommand
        {
            get
            {
                return _showAutoCompleteListCommand ?? (_showAutoCompleteListCommand = new Command(() => { _navigation.PushAsync(new AutoCompletePage()); }));
            }
        }

        public Command ShowPickerListCommand
        {
            get
            {
                return _showPickerListCommand ?? (_showPickerListCommand = new Command(() => { _navigation.PushAsync(new PickerPage()); }));
            }
        }

        public MainPageViewModel(INavigation navigation)
        {
            _navigation = navigation;
        }
    }
}
