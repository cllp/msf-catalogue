using System;
using System.Collections.Generic;
using System.Text;

namespace MSF.LogisticsPlatform.Domain.Entities
{
    public class ProductDetail
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int OverallRating { get; set; }
        public string EstimatedLifespan { get; set; }
        public string Mobility { get; set; }
        public string QualityOfService { get; set; }
        public string Pricing { get; set; }
        public string SuplyComments { get; set; }
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
