using System;
using System.Collections.Generic;
using System.Text;

namespace MSF.LogisticsPlatform.Domain.Entities
{
   public class Product
    {
        public int Product_Id { get; set; }
        public string Product_Name { get; set; }
        public int Product_Supplier_Id { get; set; }
    }
}
