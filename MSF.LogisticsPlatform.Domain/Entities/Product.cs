using System;
using System.Collections.Generic;
using System.Text;

namespace MSF.LogisticsPlatform.Domain.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductPicture { get; set; }
        public int ProductRating { get; set; }
        public string SupplierName { get; set; }
    }
}
