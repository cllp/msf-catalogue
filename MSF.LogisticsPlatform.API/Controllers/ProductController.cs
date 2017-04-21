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



        [HttpGet("{productCategory}/{filterJson}")]
        public IActionResult GetFilteredProducts(string productCategory, string filterJson)
        {
            var filterJsonSim = @"[
            {
                ""FilterGroupDescription"":""shelter"",
                ""FilterItemsGroup"":[{
                        ""FilterCriteria"": ""@BASIC"",
                        ""IsChecked"":""true""
                    }
                ]
            }
        ]";
            
            List<FilterGroup> filterGroups = JsonConvert.DeserializeObject<List<FilterGroup>>(filterJsonSim);
            var result = _ServiceFactory.GetProductService().GetProductsByFilter(productCategory, filterGroups);
            var formatedResult = JsonConvert.SerializeObject(result, Formatting.Indented);
            return Ok(formatedResult);
        }
    }
}
