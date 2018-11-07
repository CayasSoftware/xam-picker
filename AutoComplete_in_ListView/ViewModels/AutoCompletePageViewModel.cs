using System.Collections.Generic;
using AutoComplete_in_ListView.Models;

namespace AutoComplete_in_ListView.ViewModels
{
    public class AutoCompletePageViewModel : BaseViewModel
    {
        private List<RlcParameterItem> _availableRlcParameter;

        public List<RlcParameterItem> AvailableRlcParameter
        {
            get => _availableRlcParameter;
            set => SetProperty(ref _availableRlcParameter, value);
        }

        public AutoCompletePageViewModel()
        {
            AvailableRlcParameter = CreateRlcParameterItem();
        }

        private List<RlcParameterItem> CreateRlcParameterItem()
        {
            return new List<RlcParameterItem>
            {
                new RlcParameterItem()
                {
                    Description = "Entry",
                    Value = string.Empty,
                    ParamType = "S"
                },
                new RlcParameterItem()
                {
                    Description = "AutoComplete",
                    Value = string.Empty,
                    ParamType = "V",
                    SelectionList =  new List<string>{"Apple", "Canon", "Cisco", "IBM", "Infragistics", "Microsoft", "Novel", "Norton"}
                }
            };
        }
    }
}
