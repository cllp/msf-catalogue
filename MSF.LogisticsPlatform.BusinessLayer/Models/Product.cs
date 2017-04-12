using MSF.LogisticsPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MSF.LogisticsPlatform.BusinessLayer.Models
{
    public class Product
    {
        public string ProductName { get; set; }
        public string ImageName { get; set; }
    }
}
