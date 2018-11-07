using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Views.InputMethods;
using Android.Widget;
using AutoComplete_in_ListView.Controls;
using AutoComplete_in_ListView.Droid.Renderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(AutoCompleteEntry), typeof(AutoCompleteEntryRenderer))]

namespace AutoComplete_in_ListView.Droid.Renderer
{
    public class AutoCompleteEntryRenderer : Xamarin.Forms.Platform.Android.AppCompat.ViewRenderer<AutoCompleteEntry, AutoCompleteTextView>
    {
        private readonly Context _context;
        private bool _didShownDropDown;

        public AutoCompleteEntryRenderer(Context context) : base(context)
        {
            _context = context;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<AutoCompleteEntry> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                SetNativeControl(new AutoCompleteTextView(_context));
            }

            if (e.NewElement != null)
            {
                Control.ImeOptions = ImeAction.Done;
                Control.SetSingleLine(true);
                Control.SetLines(1);

                if (!string.IsNullOrWhiteSpace(e.NewElement.Text))
                    Control.Text = e.NewElement.Text;

                if (!string.IsNullOrEmpty(e.NewElement.Placeholder))
                    Control.Hint = e.NewElement.Placeholder;

                Control.Adapter = new ArrayAdapter<string>(_context, Android.Resource.Layout.SimpleDropDownItem1Line, e.NewElement.Suggestions);

                Control.FocusChange += AutoCompleteTextView_FocusChange;
                Control.TextChanged += AutoCompleteTextView_TextChanged;
            }

            if (e.OldElement != null)
            {
                Control.FocusChange -= AutoCompleteTextView_FocusChange;
                Control.TextChanged -= AutoCompleteTextView_TextChanged;
            }
        }

        private void AutoCompleteTextView_FocusChange(object sender, FocusChangeEventArgs e)
        {
            if (sender is AutoCompleteTextView && e.HasFocus && !_didShownDropDown && Control.Text.Length == 0)
            {
                _didShownDropDown = true;
                Control.ShowDropDown();
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName != "Suggestions")
                return;

            var autoCompleteEntry = sender as AutoCompleteEntry;

            Control.Adapter = new ArrayAdapter<string>(_context, Android.Resource.Layout.SimpleDropDownItem1Line, autoCompleteEntry?.Suggestions);
        }

        private void AutoCompleteTextView_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            var autoCompleteTextView = sender as AutoCompleteTextView;

            Element.Text = autoCompleteTextView?.Text;

            if (Control.Text.Length == 0)
                _didShownDropDown = false;
        }
    }
}