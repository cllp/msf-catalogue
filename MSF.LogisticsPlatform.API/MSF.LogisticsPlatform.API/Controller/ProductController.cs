using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace MSF.LogisticsPlatform.API.Controller
      {
    [Route("Product")]
    public class ProductController : ControllerBase
    {
        /*private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }*/
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("welcome");
        }
        //[HttpGet "(id)"]
        //public IActionResult GetId(int id)
        //{
           // return Ok(_productRepository.Products.Product_id);
        //}
    }
}
