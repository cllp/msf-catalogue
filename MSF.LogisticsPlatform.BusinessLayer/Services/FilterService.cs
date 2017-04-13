using System;
using System.Collections.Generic;
using System.Text;
using MSF.LogisticsPlatform.BusinessLayer.Models;
using MSF.LogisticsPlatform.Domain.Infrastucture;

namespace MSF.LogisticsPlatform.BusinessLayer.Services
{
    public class FilterService : IFilterService
    {
        private readonly IDBConnectionFactory _dbConnectionFactory;
        public FilterService(IDBConnectionFactory dbConnectionFactory)
        {
            _dbConnectionFactory = dbConnectionFactory;

        }

        public Filter GetFilter(string category)
        {
            var filter = new Filter();

            var filterGroup1 = new FilterGroup(1,"LIFESPAN OF INFRASTRUCTURE");
            filterGroup1.AddFilterItem("BASIC shelter (3 mths < x < 6 mths)", false);
            filterGroup1.AddFilterItem("TRANSITIONAL shelter (x < 18 mths)", false);
            filterGroup1.AddFilterItem("WAREHOUSE structure (x < 2y)", false);
            filterGroup1.AddFilterItem("PREFABRICATED structures (x < 5y)", false);
            filter.FilterGroups.Add(filterGroup1);

            var filterGroup2 = new FilterGroup(2, "SIZE OF INFRASTRUCTURE");
            filterGroup2.AddFilterItem("FAMILY size (10m² < x < 20m²)", false);
            filterGroup2.AddFilterItem("POLYVALENT size (20m² < x < 50m²)", false);
            filterGroup2.AddFilterItem("MEDIUM size (50m² < x < 150m²)", false);
            filterGroup2.AddFilterItem("LARGE size (150m² < x)", false);
            filter.FilterGroups.Add(filterGroup2);

            var filterGroup3 = new FilterGroup(3, "THERMAL VALUE");
            filterGroup3.AddFilterItem("LOW", false);
            filterGroup3.AddFilterItem("MEDIUM", false);
            filterGroup3.AddFilterItem("HIGH", false);            
            filter.FilterGroups.Add(filterGroup3);

            var filterGroup4 = new FilterGroup(4, "COST EFFECTIVENESS");
            filterGroup4.AddFilterItem("LOW", false);
            filterGroup4.AddFilterItem("MEDIUM", false);
            filterGroup4.AddFilterItem("HIGH (500 €/m² < x < 1000 €/m²)", false);
            filter.FilterGroups.Add(filterGroup4);

            var filterGroup5 = new FilterGroup(5, "SET-UP TIME");
            filterGroup5.AddFilterItem("LOW (0 < x < 5h)", false);
            filterGroup5.AddFilterItem("MEDIUM (5h < x 2 days)", false);
            filterGroup5.AddFilterItem("HIGH(2 days)", false);
            filter.FilterGroups.Add(filterGroup5);

            var filterGroup6 = new FilterGroup(6, "SPECIFIC FEATURES");
            filterGroup6.AddFilterItem("FLOORING PROVIDED", false);
            filterGroup6.AddFilterItem("TRANSPORT BY PLANE", false);
            filterGroup6.AddFilterItem("TRANSPORT BY CONTAINER TRUCK", false);
            filterGroup6.AddFilterItem("TRANSPORT BY PICKUP", false);
            filter.FilterGroups.Add(filterGroup6);

            return filter;
        }
    }
}
