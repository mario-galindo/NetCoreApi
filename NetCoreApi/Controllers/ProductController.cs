using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreApi.Controllers
{
    [ApiController]
    [Route("products")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Product>> GetAll()
        {
            return Products;
        }

        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            return Products.Single(x => x.Id == id);
        }

        public ActionResult Create(Product product)
        {
            product.Id = Products.Count() + 1;
            Products.Add(product);

            return CreatedAtAction(
                "Get",
                new { id = product.Id },
                product
                );
        }

        public static List<Product> Products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Guitarra electrica",
                Price = 1200,
                Description = "Ideal para tocar jazz, blues rock clasico y afines"
            },
            new Product
            {
                Id = 2,
                Name = "Amplificadot para guitarra electrica",
                Price = 1200,
                Description = "Excelente amplificador con un sonido calido"
            }
        };

    }
}
