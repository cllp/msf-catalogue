using System;
using System.Collections.Generic;
using System.Text;

namespace MSF.LogisticsPlatform.BusinessLayer.Models
{
    public class FilterGroup
    {
        public string FilterGroupDescription { get; set; }

        public List<FilterItem> FilterItemsGroup { get; set; }

        public class FilterItem
        {
            public string Filter { get; set; }
            public string FilterCriteria { get; set; }
            public bool IsChecked { get; set; }
        }

    }
}
