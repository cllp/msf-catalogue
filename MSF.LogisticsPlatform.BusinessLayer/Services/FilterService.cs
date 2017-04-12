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

            return filter;
        }
    }
}
