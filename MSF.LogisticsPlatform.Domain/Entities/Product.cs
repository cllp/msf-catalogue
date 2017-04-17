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
        public string NameOfAssessor { get; set; }
        public string StockAvailability { get; set; }
        public string ProductionCapacity { get; set; }
        //public int Status { get; set; }

        public string TimeToInstall { get; set; }

        public string AccomodationForNumberOfPeople { get; set; }
        public string LastingUpTo { get; set; }
        public string Comment { get; set; }
        public int RatingValue { get; set; }
        //public string imageUrl { get; set; }
        public List<AttributeClassification> attributeClassification { get; set; }

        // public List<Supplier> suppliers { get; set; }
        // public List<ProductFile> ProductFile { get; set; }


        public Product()
        {

            this.attributeClassification = new List<AttributeClassification>();
        }

    }
}
