using System;
using System.Collections.Generic;
using System.Text;

namespace MSF.LogisticsPlatform.BusinessLayer.Models
{
    /* 
     * FilterGroup model class for all filters layouy.This class will be used by API. 
     * This model has a name of the filter group and filter of items as list that includes: filter name, filter criteria
     * and a isChecked state as boolean to check if the filter layout is checked or not.
     */
    public class FilterGroup
    {
        public string FilterGroupDescription { get; set; } // Name of the group that this filter belong to.
        public List<FilterItem> FilterItemsGroup { get; set; }//List including more info about the filter.
        public class FilterItem
        {
            public string Filter { get; set; }//Filter specific name
            public string FilterCriteria { get; set; }//More details about the filter
            public bool IsChecked { get; set; } //Setting this to true means the filter is checked.
        }

    }
}
