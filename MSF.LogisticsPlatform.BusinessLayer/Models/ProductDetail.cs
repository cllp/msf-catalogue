using MSF.LogisticsPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MSF.LogisticsPlatform.BusinessLayer.Models
{
    public class ProductDetail
    {
        public int ProductID { get; set; }
        public String ProductName { get; set; }
        public String SupplierName { get; set; }
        public String EstimatedLifespan { get; set; }
        public string Mobility { get; set; }
        public string QualityOfService { get; set; }
        public string Pricing { get; set; }
        public String SuplyComments { get; set; }
        public float EstimatedSetupHours { get; set; }
        public float Cleanability { get; set; }
        public float RequiredPeople { get; set; }
        public int TrustworthinessRating { get; set; }
        public int MobilityRating { get; set; }
        public int BuildingPerformenceRating { get; set; }
        public int InstallationRating { get; set; }
        public int SupplyRating { get; set; }
    }
}
