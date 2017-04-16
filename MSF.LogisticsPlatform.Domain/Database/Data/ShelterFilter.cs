using System;
using System.Collections.Generic;
using System.Text;

namespace MSF.LogisticsPlatform.Domain.Database.Data
{
    public struct ShelterFilter
    {
        public bool BASIC;
        public bool TRANSITIONAL;
        public bool WAREHOUSE;
        public bool PREFABRICATED;

        public bool FamilySize;
        public bool POLYVALENTSize;
        public bool MediumSize;
        public bool LargeSize;

        public bool ThermalPerformLow;
        public bool ThermalPerformMedium;
        public bool ThermalPerformHigh;

        public bool CostEffectiveLow;
        public bool CostEffectiveMedium;
        public bool CostEffectiveHigh;

        public bool SetupTimeLow;
        public bool SetupTimeMedium;
        public bool SetupTimeHigh;

        public bool FlooringProvided;
        public bool TransportedByPlane;
        public bool TransportedByTruck;
        public bool TransportedBypickup;
    }
}
