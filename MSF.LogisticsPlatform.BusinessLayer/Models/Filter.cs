using System;
using System.Collections.Generic;
using System.Text;

namespace MSF.LogisticsPlatform.BusinessLayer.Models
{
    public class Filter
    {
        private readonly IList<FilterGroup> _filterGroups;
       
        public Filter()
        {
            _filterGroups = new List<FilterGroup>();
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

        public IList<FilterGroup> FilterGroups
        {
            get

            {
                return _filterGroups;
            }
            private set { }
        }
    }
}
