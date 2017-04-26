using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MSF.LogisticsPlatform.BusinessLayer;
using MSF.LogisticsPlatform.BusinessLayer.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;

namespace MSF.LogisticsPlatform.API.Controllers
{
    //This controller is used to return all products, product by id and all filtered products.
    [Route("api/Product")]
    public class ProductController : Controller
    {
        IServiceFactory _ServiceFactory;//Reference to Service Factory Interface to access the factory and create product services.
        public ProductController(IServiceFactory serviceFactory)
        {
            _ServiceFactory = serviceFactory;
        }
        //Call product service to return all products as action results
        //This action will be sent through API to front-end
        // GET: api/product
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _ServiceFactory.GetProductService().GetAll();
            var formatedResult = JsonConvert.SerializeObject(result, Formatting.Indented);// put the json object in 
            return Ok(formatedResult);
        }

        // GET: api/product/id
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _ServiceFactory.GetProductService().Get(id);
            var formatedResult = JsonConvert.SerializeObject(result, Formatting.Indented);
            return Ok(formatedResult);
        }


        // Get: api/product/shelter/filterJson
        [Route("{productCategory}/filterJson")]
        [HttpPost]
        public IActionResult GetFilteredProducts(string productCategory, [FromBody]List<FilterGroup> filterJson)
        {
            var result = _ServiceFactory.GetProductService().GetProductsByFilter(productCategory, filterJson);
            var formatedResult = JsonConvert.SerializeObject(result, Formatting.Indented);
            return Ok(formatedResult);
        }
    }
}
