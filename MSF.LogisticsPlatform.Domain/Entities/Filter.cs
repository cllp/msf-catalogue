using System;
using System.Collections.Generic;
using System.Text;

namespace MSF.LogisticsPlatform.Domain.Entities
{
    public class Filter
    {
        public int FilterId { get; set; }
        public string FilterDescription { get; set; }
        public List<FilterItem> FilterItem { get; set; }
    }
}
