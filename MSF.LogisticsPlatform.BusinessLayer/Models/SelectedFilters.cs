using System;
using System.Collections.Generic;
using System.Text;
namespace MSF.LogisticsPlatform.BusinessLayer.Models
{
    public class SelectedFilters
    {
        public string ProductCategory
        {
            get; set;
        }
        public IList<FilterItem> FilterGroups { get; set; }
        public class FilterItem
        {
            public int ProductGroupId { get; set; }
            public string FilterCriteria { get; set; }
        }
    }
}