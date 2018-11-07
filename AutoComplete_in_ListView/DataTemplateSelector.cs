using System;
using AutoComplete_in_ListView.Models;
using Xamarin.Forms;

namespace AutoComplete_in_ListView
{
    internal class RlcDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DefaultEntryTemplate { get; set; }

        public DataTemplate PickerEntryTemplate { get; set; }

        public DataTemplate AutoCompleteDataTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var rlcParameterItem = item as RlcParameterItem;

            switch (rlcParameterItem?.ParamType)
            {
                case "A":
                    return PickerEntryTemplate;
                case "S":
                    return DefaultEntryTemplate;
                case "V":
                    return AutoCompleteDataTemplate;
                default:
                    return DefaultEntryTemplate;
            }
        }
    }
}
