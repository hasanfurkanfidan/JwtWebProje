﻿
using System.Threading.Tasks;
using Hff.JwtProje.Business.Interfaces;
using Hff.JwtProje.Entities.Concrete;
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
        public async Task< IActionResult> GetAll()
        {
            return Ok( await _productService.GetAll());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult>GetById(int id)
        {
            var product =await _productService.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            else
            {
                return Ok();
            }
           
        }
        [HttpPost]
        public async Task<IActionResult>Add(Product product)
        {
            await _productService.Add(product);
            return Created("", product);
        }
        [HttpPut]
        public async Task<IActionResult> Update(Product product)
        {
            await _productService.Update(product);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deletedProduct =await _productService.GetById(id);
            await _productService.Delete(deletedProduct.Id);
            return NoContent();
        }
    }
}
