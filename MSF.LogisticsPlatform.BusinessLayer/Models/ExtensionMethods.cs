using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace MSF.LogisticsPlatform.BusinessLayer.Models
{
    /*
     * This static class is used to translate FilterGroups (json that is recieved and converted into FilterGroups)
     * to a string that can be readable by DB's stored procecdure. 
     */
    public static class ExtensionMethods
    {
        public static string GetAsParameterArray(this IEnumerable<FilterGroup> filter)
        {
            StringBuilder result = new StringBuilder();
            foreach (var filterGroup in filter)
            {
                foreach (var filterItem in filterGroup.FilterItemsGroup)
                {
                    result.Append("@"+filterItem.FilterCriteria);
                    result.Append("=");
                    if (filterItem.IsChecked)
                    {
                        result.Append("1");
                    }
                    else
                    {
                        result.Append("0");
                    }
                    result.Append(",");
                }
            }
            return result.ToString().TrimEnd(',');
        }
    }
}