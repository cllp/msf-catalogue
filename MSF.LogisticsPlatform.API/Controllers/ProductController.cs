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

        // GET: api/values

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _ServiceFactory.GetProductService().GetAll();
            var result2 = JsonConvert.SerializeObject(result, Formatting.Indented);
            return Ok(result2);

            //var result = _ServiceFactory.GetProductService().GetAll();
            //return Ok(result);
        }

        public IActionResult GetFilteredProducts(string filterJson)
        {
            var result = _ServiceFactory.GetProductService().GetProductsByFilter(new Filter(filterJson));
            return Ok(result);
        }

        //POST api/values
        //[HttpPost]
        /*public void Post([FromBody]Product prod)
        {
            if (ModelState.IsValid)

                _productService.Add(prod);
        }
        
        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Product prod)
        {
            prod.ProductID = id;
            if (ModelState.IsValid)
                productRepository.Update(prod);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            productRepository.Delete(id);
        }*/

    }
}
