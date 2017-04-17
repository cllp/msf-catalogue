using System;
using System.Collections.Generic;
using System.Text;

namespace MSF.LogisticsPlatform.Domain.Entities
{
    public class productDetails
    {
        public int ProductID { get; set; }
        public String ProductName { get; set; }
        public String SupplierName { get; set; }
        public String EstimatedLifespan { get; set; }
        public float Pricing { get; set; }
        public String SuplyComments { get; set; }
        public float EstimatedSetupHours { get; set; }
        public float Cleanability { get; set; }
        public float RequiredPeople { get; set; }
        public float TrustworthinessRating { get; set; }
        public float MobilityRating { get; set; }
        public float BuildingPerformenceRating { get; set; }
        public float InstallationRating { get; set; }
        public float SupplyRating { get; set; }
    }

}
