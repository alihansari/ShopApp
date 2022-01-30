using Microsoft.AspNetCore.Mvc;
using shopapp.business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopapp.webapi.Controllers
{
    //localhost:4200/api/products
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult GetProducts()
        {
            var products = _productService.GetAll();
            return Ok(products);
        }
        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var product = _productService.GetById(id);
            if (product==null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
