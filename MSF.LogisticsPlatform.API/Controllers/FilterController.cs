using Microsoft.AspNetCore.Mvc;
using MSF.LogisticsPlatform.BusinessLayer;
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

        //Constructor
        /* public ProductController()
         {
             productRepository = new ProductRepository();
         }*/
        public FilterController(IServiceFactory serviceFactory)
        {
            _ServiceFactory = serviceFactory;
        }

        // GET: api/values

        [HttpGet]
        public IActionResult GetAll(string category)
        {
            var result = _ServiceFactory.GetFilterService().GetFilter(category);
            return Ok(result);
        }
    }
}
