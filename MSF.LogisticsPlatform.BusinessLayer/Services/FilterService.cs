using System;
using System.Collections.Generic;
using System.Text;
using MSF.LogisticsPlatform.BusinessLayer.Models;
using MSF.LogisticsPlatform.Domain.Infrastucture;
using static MSF.LogisticsPlatform.BusinessLayer.Models.FilterGroup;

namespace MSF.LogisticsPlatform.BusinessLayer.Services
{
    public class FilterService : IFilterService
    {
        private readonly IDBConnectionFactory _dbConnectionFactory;
        public FilterService(IDBConnectionFactory dbConnectionFactory)
        {
            _dbConnectionFactory = dbConnectionFactory;
        }

        public List<FilterGroup> GetFilter(string category)
        {

            List<FilterGroup> FilterGroups = new List<FilterGroup>();

            FilterGroups.Add(
                new FilterGroup()
                {
                    FilterGroupDescription = "LIFESPAN OF INFRASTRUCTURE",
                    FilterItemsGroup = new List<FilterItem>()
                    {
                        new FilterItem(){  Filter = "BASIC shelter (3 mths < x < 6 mths)", FilterCriteria = "BASIC", IsChecked = false},
                        new FilterItem(){  Filter = "TRANSITIONAL shelter (x < 18 mths)", FilterCriteria = "TRANSITIONAL", IsChecked = false},
                        new FilterItem(){  Filter = "WAREHOUSE structure (x < 2y)", FilterCriteria = "WAREHOUSE", IsChecked = false},
                        new FilterItem(){  Filter = "PREFABRICATED structures (x < 5y)", FilterCriteria = "PREFABRICATED", IsChecked = false},
                    }
                }
            );
            FilterGroups.Add(
                new FilterGroup()
                {
                    FilterGroupDescription = "SIZE OF INFRASTRUCTURE",
                    FilterItemsGroup = new List<FilterItem>()
                    {
                        new FilterItem(){ Filter = "FAMILY size (10m² < x < 20m²)",FilterCriteria= "FamilySize", IsChecked= false },
                        new FilterItem(){  Filter = "POLYVALENT size(20m² < x < 50m²)", FilterCriteria = "POLYVALENTSize", IsChecked = false},
                        new FilterItem(){  Filter = "MEDIUM size (50m² < x < 150m²)", FilterCriteria= "MediumSize",IsChecked = false},
                        new FilterItem(){  Filter = "LARGE size (150m² < x)", FilterCriteria="LargeSize",IsChecked= false},
                    }
                }
            );
            FilterGroups.Add(
               new FilterGroup()
               {
                   FilterGroupDescription = "THERMAL VALUE",
                   FilterItemsGroup = new List<FilterItem>()
                   {
                       new FilterItem(){  Filter = "LOW",FilterCriteria= "ThermalPerformLow", IsChecked= false },
                       new FilterItem(){  Filter = "MEDIUM", FilterCriteria = "ThermalPerformMedium", IsChecked = false},
                       new FilterItem(){  Filter = "HIGH", FilterCriteria= "ThermalPerformHigh", IsChecked=false },
                    }
               }
            );

            FilterGroups.Add(
                new FilterGroup()
                {
                    FilterGroupDescription = "COST EFFECTIVENESS",
                    FilterItemsGroup = new List<FilterItem>()
                    {
                        new FilterItem(){  Filter = "LOW , (0 < x < 100 €/m²)",FilterCriteria="CostEffectiveLow", IsChecked= false },
                        new FilterItem(){  Filter = "MEDIUM, (100€/m² < x < 500 €/m²)", FilterCriteria = "CostEffectiveMedium", IsChecked = false},
                        new FilterItem(){  Filter = "HIGH (500 €/m² < x < 1000 €/m²)", FilterCriteria= "CostEffectiveHigh", IsChecked = false},
                    }
                }
            );
            FilterGroups.Add(
               new FilterGroup()
               {
                   FilterGroupDescription = "SET-UP TIME",
                   FilterItemsGroup = new List<FilterItem>()
                   {
                        new FilterItem(){  Filter = "LOW (0 < x < 5h)",FilterCriteria="SetupTimeLow", IsChecked= false },
                        new FilterItem(){ Filter = "MEDIUM (5h < x 2 days)", FilterCriteria = "SetupTimeMedium", IsChecked = false},
                        new FilterItem(){  Filter = "HIGH(2 days)", FilterCriteria= "SetupTimeHigh", IsChecked = false},
                   }
               }
           );
            FilterGroups.Add(
               new FilterGroup()
               {
                   FilterGroupDescription = "SPECIFIC FEATURES",
                   FilterItemsGroup = new List<FilterItem>()
                   {
                        new FilterItem(){ Filter = "FLOORING PROVIDED",FilterCriteria="FlooringProvided", IsChecked= false },
                        new FilterItem(){ Filter = "TRANSPORT BY PLANE", FilterCriteria = "TransportedByPlane", IsChecked = false},
                        new FilterItem(){ Filter = "TRANSPORT BY CONTAINER TRUCK", FilterCriteria= "TransportedByTruck", IsChecked=false },
                        new FilterItem(){ Filter = "TRANSPORT BY PICKUP",FilterCriteria="TransportedBypickup", IsChecked= false },
                   }
               }
           );

            return FilterGroups;
        }
    }
}
