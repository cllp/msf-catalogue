using System;
using System.Collections.Generic;

namespace MSF.LogisticsPlatform.BusinessLayer.Models
{
    public class Filter
    {
        private List<FilterGroup> _filterGroups;
        public List<FilterGroup> FilterGroups { get; private set; }

        public Filter()
        {            
            FilterGroups = new List<FilterGroup>();
        }

        public Filter(string filterJson)
        {
            // Do more stuffs

            _filterGroups = new List<FilterGroup>();
            
            // Parse filterJson and create the FilterGroup's.
        }

        public string FilterAsJson()
        {
            // Do more stuffs (parse the collection from FilterGroups to Json).
            return "";
        }
    }
}
