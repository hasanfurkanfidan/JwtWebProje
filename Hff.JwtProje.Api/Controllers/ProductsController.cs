
using System.Threading.Tasks;
using AutoMapper;
using Hff.JwtProje.Api.CustomFilters;
using Hff.JwtProje.Business.Interfaces;
using Hff.JwtProje.Entities.Concrete;
using Hff.JwtProje.Entities.Dtos.ProductDtos;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Hff.JwtProje.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        public ProductsController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task< IActionResult> GetAll()
        {
            return Ok( await _productService.GetAll());
        }
        [HttpGet("{id}")]
        [ServiceFilter(typeof(ValidId<Product>))]
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
        [ValidModel]
        public async Task<IActionResult>Add(ProductAddDto productAddDto)
        {
            await _productService.Add(_mapper.Map<Product>(productAddDto));
            return Created("", productAddDto);
        }
        [HttpPut]
        public async Task<IActionResult> Update(ProductUpdateDto productUpdateDto)
        {
            await _productService.Update(_mapper.Map<Product>(productUpdateDto));
            return NoContent();
        }
        [HttpDelete("{id}")]
        [ServiceFilter(typeof(ValidId<Product>))]

        public async Task<IActionResult> Delete(int id)
        {
            var deletedProduct =await _productService.GetById(id);
            await _productService.Delete(deletedProduct.Id);
            return NoContent();
        }
        [Route("{/Error}")]
        public IActionResult Error()
        {

           var errorInfo =  HttpContext.Features.Get<IExceptionHandlerPathFeature>();
           
            return Problem(detail:"Bir hata oluştu");
        }
    }
}
