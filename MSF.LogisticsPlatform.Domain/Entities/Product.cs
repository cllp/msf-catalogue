using System;
using System.Collections.Generic;
using System.Text;

namespace MSF.LogisticsPlatform.Domain.Entities
{
    /* This is a Product Entitiy which will include info about the product 
     * from multiple tables using Stored Procedure in DB.
     * This entity is mapped to product model in Business layer.
     */
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductPicture { get; set; }
        public int ProductRating { get; set; }    
    }
}
