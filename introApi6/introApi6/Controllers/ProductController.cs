using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using introApi6.Models;

namespace introApi6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase //Controllerbase, view desteği olmadan mvc controller desteği sunuyor. 
    {

        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Description = "Product 1", Price = 10, Discount = 0.1, ImageUrl = "https://picsum.photos/200/300", Name = "Product 1", Stock = 100 },
                new Product { Id = 2, Description = "Product 2", Price = 10, Discount = 0.1, ImageUrl = "https://picsum.photos/200/300", Name = "Product 2", Stock = 100 },
                new Product { Id = 4, Description = "Product 4", Price = 10, Discount = 0.1, ImageUrl = "https://picsum.photos/200/300", Name = "Product 3", Stock = 100 },
                new Product { Id = 5, Description = "Product 5", Price = 10, Discount = 0.1, ImageUrl = "https://picsum.photos/200/300", Name = "Product 4", Stock = 100 },
                new Product { Id = 3, Description = "Product 3", Price = 10, Discount = 0.1, ImageUrl = "https://picsum.photos/200/300", Name = "Product 5", Stock = 100 },


            };
            return Ok(products);

        }
    }
}
