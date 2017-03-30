using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MSF.LogisticsPlatform.Domain.Repository;
//using System.Web.Http;


namespace MSF.LogisticsPlatform.API.Controller
{
    [Route("api/Product")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IActionResult> Get()
        {
            //IHttpActionResult
            var resultData = await _productRepository.GetAll();
            if (resultData == null)
            {
                return NotFound();
            }
            return Ok(resultData);
        }


        //[HttpGet]
        //public IEnumerable<Product> Get()
        //{
        //    return _productRepository.GetAll();
        //}


        /*public async Task<IActionResult> Get()
        {
            //IHttpActionResult
            var resultData = await _productRepository.GetAll();
            if (resultData == null)
            {
                return NotFound();
            }
            return Ok(resultData);
        }*/

        //public IActionResult Get()
        //{ return Ok("OK"); }

        //[HttpGet "(id)"]
        //public IActionResult GetId(int id)
        //{
        // return Ok(_productRepository.Products.Product_id);
        //}
    }
}
