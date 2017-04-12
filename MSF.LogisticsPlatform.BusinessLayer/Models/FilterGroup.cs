using System;
using System.Collections.Generic;
using System.Text;

namespace MSF.LogisticsPlatform.BusinessLayer.Models
{
    public class FilterGroup
    {
        private Dictionary<string, bool> _values;

        public FilterGroup(int groupId, string groupDescription)
        {
            FilterGroupId = groupId;
            FilterGroupDescription = groupDescription;
            _values = new Dictionary<string, bool>();
        }

        public int FilterGroupId { get; set; }
        public string FilterGroupDescription { get; set; }

        public bool GetFilterItemValueById(string id)
        {
            if (_values.ContainsKey(id))
                return _values[id];

            throw new ArgumentOutOfRangeException();
        }

        public void AddFilterItem(string id, bool value)
        {
            if (_values.ContainsKey(id))
                throw new ArgumentException(string.Format("id '{0}' already in collection!", id));

            _values.Add(id, value);
        }

        public IEnumerable<string> GetAllIds()
        {
            return _values.Keys;
        }
    }
}
