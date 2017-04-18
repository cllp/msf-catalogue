using MSF.LogisticsPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MSF.LogisticsPlatform.BusinessLayer.Models
{
    public class FilterView
    {
        public int FilterId { get; set; }
        public string FilterDescription{ get; set; }
        public List<FilterItem> FilterItem { get; set; }
    }
}
