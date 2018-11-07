using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AutoComplete_in_ListView.Controls
{
    public class AutoCompleteEntry : Entry
    {
        public static readonly BindableProperty SuggestionsProperty = BindableProperty.Create(nameof(Suggestions), typeof(List<string>), typeof(AutoCompleteEntry), new List<string>(), BindingMode.TwoWay, propertyChanged: OnSuggestionsChanged);

        public List<string> Suggestions { get; set; }

        private static void OnSuggestionsChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (AutoCompleteEntry)bindable;

            control.Suggestions = (List<string>)newValue;
        }
    }
}
