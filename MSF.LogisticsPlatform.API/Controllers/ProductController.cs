using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MSF.LogisticsPlatform.BusinessLayer;
using MSF.LogisticsPlatform.BusinessLayer.Models;
using Newtonsoft.Json;

namespace MSF.LogisticsPlatform.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Product")]
    public class ProductController : Controller
    {

        IServiceFactory _ServiceFactory;

        public ProductController(IServiceFactory serviceFactory)
        {
            _ServiceFactory = serviceFactory;
        }

        // GET: api/product

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _ServiceFactory.GetProductService().GetAll();
            var formatedResult = JsonConvert.SerializeObject(result, Formatting.Indented);
            return Ok(formatedResult);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _ServiceFactory.GetProductService().Get(id);
            var formatedResult = JsonConvert.SerializeObject(result, Formatting.Indented);
            return Ok(formatedResult);
        }

        private IEnumerable<FilterGroup> GetFilter(SelectedFilters selectedFilters)
        {
            var filter = _ServiceFactory.GetFilterService().GetFilter(selectedFilters.ProductCategory);
            foreach (var selectedFilter in selectedFilters.FilterGroups)
            {
                var filterGroup = filter.Find((x) => x.FilterGroupId == selectedFilter.ProductGroupId); if (filterGroup == null) { throw new ArgumentException(string.Format("FilterGroupId [{0}] does not exist for category [{1}]", selectedFilter.ProductGroupId, selectedFilters.ProductCategory)); }
                var filterItem = filterGroup.FilterItemsGroup.Find((x) => x.FilterCriteria == selectedFilter.FilterCriteria); if (filterItem == null) { throw new ArgumentException(string.Format("FilterCriteria [{0}] does not exist for filtergroup [{1}]", selectedFilter.FilterCriteria, filterGroup.FilterGroupId)); }
                filterItem.IsChecked = true;
            }
            return filter;
        }

        [HttpGet("{filterJson}")]
        public IActionResult GetFilteredProducts(string filterJson)
        {
            SelectedFilters selectedFilters = JsonConvert.DeserializeObject<SelectedFilters>(filterJson); var result = _ServiceFactory.GetProductService().GetProductsByFilter(selectedFilters.ProductCategory, GetFilter(selectedFilters));
            return Ok(result);
        }
    }
}
