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
                    FilterGroupId = 1,
                    FilterGroupDescription = "LIFESPAN OF INFRASTRUCTURE",
                    FilterItemsGroup = new List<FilterItem>()
                    {
                        new FilterItem(){ ItemSer = 1, Filter = "BASIC shelter (3 mths < x < 6 mths)", FilterCriteria = "ProductType=1", IsChecked = false},
                        new FilterItem(){ ItemSer = 2, Filter = "TRANSITIONAL shelter (x < 18 mths)", FilterCriteria = "ProductType=2", IsChecked = false},
                        new FilterItem(){ ItemSer = 3, Filter = "WAREHOUSE structure (x < 2y)", FilterCriteria = "ProductType=3", IsChecked = false},
                        new FilterItem(){ ItemSer = 4, Filter = "PREFABRICATED structures (x < 5y)", FilterCriteria = "ProductType=4", IsChecked = false},
                    }
                }
            );
            FilterGroups.Add(
                new FilterGroup()
                {
                    FilterGroupId = 2,
                    FilterGroupDescription = "SIZE OF INFRASTRUCTURE",
                    FilterItemsGroup = new List<FilterItem>()
                    {
                        new FilterItem(){ ItemSer = 1, Filter = "FAMILY size (10m² < x < 20m²)",FilterCriteria= "(ProductAttribute.AttributeId=14 and (ProductAttribute.AttributeValue >10 and ProductAttribute.attributeValue <=20)", IsChecked= false },
                        new FilterItem(){ ItemSer = 2, Filter = "POLYVALENT size(20m² < x < 50m²)", FilterCriteria = "(ProductAttribute.AttributeId = 14 and(ProductAttribute.AttributeValue > 20 and  ProductAttribute.attributeValue <= 50)", IsChecked = false},
                        new FilterItem(){ ItemSer = 3, Filter = "MEDIUM size (50m² < x < 150m²)", FilterCriteria= "(ProductAttribute.AttributeId=14 and (ProductAttribute.AttributeValue >50 and  ProductAttribute.attributeValue <=150)",
                            IsChecked = false},
                        new FilterItem(){ ItemSer = 4, Filter = "LARGE size (150m² < x)", FilterCriteria="(ProductAttribute.AttributeId=14 and ProductAttribute.AttributeValue >150 )",IsChecked= false},
                    }
                }
            );
            FilterGroups.Add(
               new FilterGroup()
               {
                   FilterGroupId = 3,
                   FilterGroupDescription = "THERMAL VALUE",
                   FilterItemsGroup = new List<FilterItem>()
                   {
                       new FilterItem(){ ItemSer = 1, Filter = "LOW",FilterCriteria= "(ProductAttribute.AttributeId=23 and ProductAttribute.attributeValue <=2)", IsChecked= false },
                       new FilterItem(){ ItemSer = 2, Filter = "MEDIUM", FilterCriteria = "(ProductAttribute.AttributeId=23 and (ProductAttribute.AttributeValue >2 and  ProductAttribute.attributeValue <=4)", IsChecked = false},
                       new FilterItem(){ ItemSer = 3, Filter = "HIGH", FilterCriteria= "(ProductAttribute.AttributeId = 23 and ProductAttribute.AttributeValue > 4)", IsChecked=false },
                    }
               }
            );

            FilterGroups.Add(
                new FilterGroup()
                {
                    FilterGroupId = 4,
                    FilterGroupDescription = "COST EFFECTIVENESS",
                    FilterItemsGroup = new List<FilterItem>()
                    {
                        new FilterItem(){ ItemSer = 1, Filter = "LOW , (0 < x < 100 €/m²)",FilterCriteria="(ProductAttribute.AttributeId=36 and ProductAttribute.attributeValue <=100)", IsChecked= false },
                        new FilterItem(){ ItemSer = 2, Filter = "MEDIUM, (100€/m² < x < 500 €/m²)", FilterCriteria = "(ProductAttribute.AttributeId=36 and (ProductAttribute.AttributeValue >100 and  ProductAttribute.attributeValue <=500)", IsChecked = false},
                        new FilterItem(){ ItemSer = 3, Filter = "HIGH (500 €/m² < x < 1000 €/m²)", FilterCriteria= "(ProductAttribute.AttributeId=36 and ProductAttribute.AttributeValue >500 )", IsChecked = false},
                    }
                }
            );
            FilterGroups.Add(
               new FilterGroup()
               {
                   FilterGroupId = 5,
                   FilterGroupDescription = "SET-UP TIME",
                   FilterItemsGroup = new List<FilterItem>()
                   {
                        new FilterItem(){ ItemSer = 1, Filter = "LOW (0 < x < 5h)",FilterCriteria="(ProductAttribute.AttributeId=32 and  ProductAttribute.attributeValue <=5)", IsChecked= false },
                        new FilterItem(){ ItemSer = 2, Filter = "MEDIUM (5h < x 2 days)", FilterCriteria = "(ProductAttribute.AttributeId=32 and (ProductAttribute.AttributeValue >5 and  ProductAttribute.attributeValue <=48)", IsChecked = false},
                        new FilterItem(){ ItemSer = 3, Filter = "HIGH(2 days)", FilterCriteria= "(ProductAttribute.AttributeId=32 and ProductAttribute.AttributeValue >48 )", IsChecked = false},
                   }
               }
           );
            FilterGroups.Add(
               new FilterGroup()
               {
                   FilterGroupId = 6,
                   FilterGroupDescription = "SPECIFIC FEATURES",
                   FilterItemsGroup = new List<FilterItem>()
                   {
                        new FilterItem(){ ItemSer = 1, Filter = "FLOORING PROVIDED",FilterCriteria="(ProductAttribute.AttributeId = 37 and ProductAttribute.AttributeValue = True)", IsChecked= false },
                        new FilterItem(){ ItemSer = 2, Filter = "TRANSPORT BY PLANE", FilterCriteria = "(ProductAttribute.AttributeId=38 and ProductAttribute.AttributeValue =True )", IsChecked = false},
                        new FilterItem(){ ItemSer = 3, Filter = "TRANSPORT BY CONTAINER TRUCK", FilterCriteria= "(ProductAttribute.AttributeId=39 and ProductAttribute.AttributeValue =True )", IsChecked=false },
                        new FilterItem(){ ItemSer = 4, Filter = "TRANSPORT BY PICKUP",FilterCriteria="(ProductAttribute.AttributeId=40 and ProductAttribute.AttributeValue =True )", IsChecked= false },
                   }
               }
           );

            return FilterGroups;
        }        
    }
}
