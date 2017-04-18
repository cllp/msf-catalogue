using Microsoft.AspNetCore.Mvc;
using MSF.LogisticsPlatform.BusinessLayer;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSF.LogisticsPlatform.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Filter")]
    public class FilterController : Controller
    {
        IServiceFactory _ServiceFactory;

        public FilterController(IServiceFactory serviceFactory)
        {
            _ServiceFactory = serviceFactory;
        }

        // GET: api/filter

        [HttpGet]
        public IActionResult GetAll(string category)
        {
            var result = _ServiceFactory.GetFilterService().GetFilter(category);

            var formatedResult = JsonConvert.SerializeObject(result, Formatting.Indented);
            return Ok(formatedResult);
        }
    }
}
