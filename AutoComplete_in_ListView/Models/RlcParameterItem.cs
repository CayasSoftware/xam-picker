using System;
using System.Collections.Generic;

namespace AutoComplete_in_ListView.Models
{
    public class RlcParameterItem
    {
        public string Description { get; set; }

        public string Value { get; set; }

        public string ParamType { get; set; }

        public DateTime Date { get; set; }

        public TimeSpan Time { get; set; }

        public List<string> SelectionList { get; set; }
    }
}
