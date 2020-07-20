using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hff.JwtProje.Business.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hff.JwtProje.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }
    }
}
