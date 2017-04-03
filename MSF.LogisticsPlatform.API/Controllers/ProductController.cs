using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MSF.LogisticsPlatform.Domain.Services;
using MSF.LogisticsPlatform.Domain.Entities;

namespace MSF.LogisticsPlatform.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Product")]
    public class ProductController : Controller
    {
        //private readonly ProductRepository productRepository;

        IProductService _productService;

        //Constructor
        /* public ProductController()
         {
             productRepository = new ProductRepository();
         }*/
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        // GET: api/values

        [HttpGet]
        public IEnumerable<Product> GetAll()
        {
            // var result = await productRepository.GetAll();
            var result = _productService.GetAll();
            return result;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            //return productRepository.Get(id);
            return _productService.Get(id);

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
