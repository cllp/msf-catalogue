using System;
using System.Collections.Generic;
using System.Text;

namespace MSF.LogisticsPlatform.BusinessLayer.Models
{
    public class ProductDTO
    {
        //public int ProductId { get; set; }

        //public string StockAvailability { get; set; }
        //public string NameOfAssessor { get; set; }
        //public string SupplierName { get; set; }
        // public string ProductName { get; set; }
        //public string FileExtension { get; set; }
        // public string FileDescription { get; set; }
        //public int OverallRating { get; set; }
        //public string ImageUrl { get; set; }

        //Kong Vu här är din properties
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductPicture { get; set; }
        public int ProductRating { get; set; }
    }
}
