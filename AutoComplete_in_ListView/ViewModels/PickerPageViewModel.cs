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
                },
                new RlcParameterItem()
                {
                    Description = "DatePicker dd.mm.yyyy date format",
                    //Value = new DateTime(2019,03,25).ToString(),
                    Value = "25.03.2019 00:00:00",
                    ParamType = "D"
                },
                new RlcParameterItem()
                {
                    Description = "DatePicker with searchable format",
                    //Value = DateTime.Today.ToString("s"),
                    Value="2019-03-25T00:00:00",
                    ParamType = "D"
                },
                new RlcParameterItem()
                {
                    Description = "DatePicker m/dd/yyyy format",
                    //Value = DateTime.Today.ToString(),
                    Value="3/25/2019 12:00:00 AM",
                    ParamType = "D"
                },
                new RlcParameterItem()
                {
                    Description = "DateTimePicker",
                    Date = DateTime.Now, //You need to use a local that returns something like dd.mm.yyyy e.g. German
                    Time = DateTime.Now.TimeOfDay.Add(TimeSpan.FromHours(2)),
                    ParamType = "DT"
                }
            };
        }
    }
}
