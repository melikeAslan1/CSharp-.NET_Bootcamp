using introAPI6.Models;
using introAPI6.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace introAPI6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
       

        private readonly ProductsService _productsService;

        public ProductsController(ProductsService productsService)
        {
            _productsService = productsService;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = _productsService.GetAll();
            return Ok(products);
        }

        [HttpPost]
        public IActionResult AddProduct(Product product) 
        {
            //Model Binder, Http request body'sinden gelen verileri Product nesnesine dönüştürür.
            if (ModelState.IsValid)
            {
                _productsService.Create(product);
                return CreatedAtAction(nameof(GetProduct), routeValues: new { id = 5 }, value: product);
                //StatusCodes.
            }
            return BadRequest(ModelState);  //400
        }
        [HttpGet("{id}")]
        public IActionResult GetProduct([FromRoute]int id)
        {
            var product = _productsService.GetById(id);
            if (product == null)
            {
                return NotFound(new { message = $"{id} numaralı ürün bulunamadı" });
            }
            return Ok(product);

        }
        
        
         

    }

    //[HttpGet]
    //public IActionResult SearchProductByName(string name)
    //{
    //    return Ok();
    //}

}

