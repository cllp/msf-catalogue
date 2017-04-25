using Microsoft.AspNetCore.Mvc;
using MSF.LogisticsPlatform.BusinessLayer;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSF.LogisticsPlatform.API.Controllers
{
    // This controller is used for the filters layout.
    // The layout is hardcoded and will be sent to the front-end to load fitlers pannel on the product page
    [Produces("application/json")]
    [Route("api/Filter")] 
    public class FilterController : Controller
    {
        IServiceFactory _ServiceFactory;//Reference to Service Factory Interface to access the factory and create filter services.

        public FilterController(IServiceFactory serviceFactory)
        {
            _ServiceFactory = serviceFactory;
        }

        //This action will be sent through API to front-end
        // GET: api/filter
        [HttpGet]
        public IActionResult GetAll(string category)
        {
            //Call filter service to return all hardcoded layouts as list of FilterGroup
            var result = _ServiceFactory.GetFilterService().GetFilter(category);
            var formatedResult = JsonConvert.SerializeObject(result, Formatting.Indented);//Serialize json objects to a proper format.
            return Ok(formatedResult);
        }
    }
}
