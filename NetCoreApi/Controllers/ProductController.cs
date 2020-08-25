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
