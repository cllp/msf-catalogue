using System;
using System.Collections.Generic;
using System.Text;
using MSF.LogisticsPlatform.Domain.Database.Data;
using System.Linq;
namespace MSF.LogisticsPlatform.BusinessLayer.Models
{
    public static class ExtensionMethods
    {
        public static ShelterFilter Translate(this IEnumerable<FilterGroup> filter)
        {
            var shelterFilter = new ShelterFilter();
            var queriableCollection = new List<FilterGroup>(filter); shelterFilter.BASIC = queriableCollection.Find((x) => x.FilterGroupId == 1).FilterItemsGroup.Find((x) => x.FilterCriteria == "BASIC shelter (3 mths < x < 6 mths)").IsChecked;
            shelterFilter.TRANSITIONAL = queriableCollection.Find((x) => x.FilterGroupId == 1).FilterItemsGroup.Find((x) => x.FilterCriteria == "TRANSITIONAL shelter (x < 18 mths)").IsChecked;
            shelterFilter.WAREHOUSE = queriableCollection.Find((x) => x.FilterGroupId == 1).FilterItemsGroup.Find((x) => x.FilterCriteria == "WAREHOUSE structure (x < 2y)").IsChecked; shelterFilter.PREFABRICATED = queriableCollection.Find((x) => x.FilterGroupId == 1).FilterItemsGroup.Find((x) => x.FilterCriteria == "PREFABRICATED structures (x < 5y)").IsChecked;
            shelterFilter.FamilySize = queriableCollection.Find((x) => x.FilterGroupId == 1).FilterItemsGroup.Find((x) => x.FilterCriteria == "FAMILY size (10m² < x < 20m²)").IsChecked; shelterFilter.POLYVALENTSize = queriableCollection.Find((x) => x.FilterGroupId == 1).FilterItemsGroup.Find((x) => x.FilterCriteria == "POLYVALENT size(20m² < x < 50m²)").IsChecked;
            shelterFilter.MediumSize = queriableCollection.Find((x) => x.FilterGroupId == 1).FilterItemsGroup.Find((x) => x.FilterCriteria == "MEDIUM size (50m² < x < 150m²)").IsChecked; shelterFilter.LargeSize = queriableCollection.Find((x) => x.FilterGroupId == 1).FilterItemsGroup.Find((x) => x.FilterCriteria == "LARGE size (150m² < x)").IsChecked;
            shelterFilter.FamilySize = queriableCollection.Find((x) => x.FilterGroupId == 1).FilterItemsGroup.Find((x) => x.FilterCriteria == "FAMILY size (10m² < x < 20m²)").IsChecked; shelterFilter.POLYVALENTSize = queriableCollection.Find((x) => x.FilterGroupId == 1).FilterItemsGroup.Find((x) => x.FilterCriteria == "POLYVALENT size(20m² < x < 50m²)").IsChecked;
            shelterFilter.MediumSize = queriableCollection.Find((x) => x.FilterGroupId == 1).FilterItemsGroup.Find((x) => x.FilterCriteria == "MEDIUM size (50m² < x < 150m²)").IsChecked; shelterFilter.LargeSize = queriableCollection.Find((x) => x.FilterGroupId == 1).FilterItemsGroup.Find((x) => x.FilterCriteria == "LARGE size (150m² < x)").IsChecked;

            throw new NotImplementedException();
        }

    }
}