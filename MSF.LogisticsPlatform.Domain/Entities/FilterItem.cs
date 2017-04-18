using System;
using System.Collections.Generic;
using System.Text;

namespace MSF.LogisticsPlatform.Domain.Entities
{
    public class FilterItem
    {
        public int ItemSer { get; set; }
        public string Filter { get; set; }
        public string FilterCriteria { get; set; }
    }
}
