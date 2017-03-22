using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;
using WebApplication.Repositories;

namespace WebApplication.Controllers
{
    [Route("api/product")]
    public class ProductController :  Controller
    {
        private readonly ProductRepository _productRepository;

        public ProductController()
        {
            _productRepository = new ProductRepository();
        }

        [Route("All")]
        [HttpGet]
        // GET api/product
        public IEnumerable<Product> Get()
        {
            return _productRepository.GetAll();
        }

        // GET api/product/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
    }   
}
