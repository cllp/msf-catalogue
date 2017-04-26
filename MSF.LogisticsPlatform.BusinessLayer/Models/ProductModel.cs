using MSF.LogisticsPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MSF.LogisticsPlatform.BusinessLayer.Models
{
    /*
     * Product model which will hold some information ex. id, name, picture and rating of the product.
     * This model is mapped through automapper to the product class in the domain layer (i.e. Entitied.Product).
     */
    public class ProductModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductPicture { get; set; }
        public int ProductRating { get; set; }
    }
}
