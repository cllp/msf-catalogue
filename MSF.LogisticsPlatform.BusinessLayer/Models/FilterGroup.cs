using System;
using System.Collections.Generic;
using System.Text;

namespace MSF.LogisticsPlatform.BusinessLayer.Models
{
    public class FilterGroup
    {
        public int FilterGroupId { get; set; }
        public string FilterGroupDescription { get; set; }

        public List<FilterItem> FilterItemsGroup { get; set; }

        public class FilterItem
        {
            public int ItemSer { get; set; }
            public string Filter { get; set; }
            public string FilterCriteria { get; set; }
            public bool IsChecked { get; set; }
        }


        


        //public bool GetFilterItemValueById(FilterItemGroup item)
        //{
        //    //if (_values.ContainsKey(id))
        //    //    return _values[id];

        //    if (FilterItemGroups.Contains(item))
        //        return item
        //    throw new ArgumentOutOfRangeException();
        //}

        //public void AddFilterItem(string id, bool value)
        //{
        //    if (_values.ContainsKey(id))
        //        throw new ArgumentException(string.Format("id '{0}' already in collection!", id));

        //    _values.Add(id, value);
        //}

        //public IEnumerable<string> GetAllIds()
        //{
        //    return _values.Keys;
        //}
    }
}
