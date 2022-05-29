using Catalog.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Business
{
    public class ProductService
    {
        private List<Product> products;

        public ProductService()
        {

            products = new List<Product>
            {
                new Product { Id = 1, Name = "Product 1", Price = 100, Description = "Produc 1 description", ImageUrl = "https://picsum.photos/200/300"},


            };
        }




         

            
    }
}
