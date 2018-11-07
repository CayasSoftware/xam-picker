using System;
using System.Collections.Generic;
using AutoComplete_in_ListView.Models;

namespace AutoComplete_in_ListView.ViewModels
{
    public class PickerPageViewModel : BaseViewModel
    {
        private List<RlcParameterItem> _availableRlcParameter;

        public List<RlcParameterItem> AvailableRlcParameter
        {
            get => _availableRlcParameter;
            set => SetProperty(ref _availableRlcParameter, value);
        }

        public PickerPageViewModel()
        {
            AvailableRlcParameter = CreateRlcParameterItem();
        }

        private List<RlcParameterItem> CreateRlcParameterItem()
        {
            return new List<RlcParameterItem>
            {
                new RlcParameterItem()
                {
                    Description = "Picker",
                    Value = string.Empty,
                    ParamType = "A",
                    SelectionList =  new List<string>{"Male", "Female"}
                },
                new RlcParameterItem()
                {
                    Description = "Entry",
                    Value = string.Empty,
                    ParamType = "S"
                }
            };
        }
    }
}
