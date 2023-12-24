using HttpFilesDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace HttpFilesDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var products = Enumerable.Range(1, 3)
                    .Select(i => new Product { Id = i, Name = $"Product {i}" })
                    .ToList();

            return Ok(products);
        }

        [HttpPost]
        public IActionResult Post(Product product)
        {
            return Ok(product);
        }

        [HttpDelete]
        public IActionResult Delete(int productId)
        {
            return Ok($"Product {productId} was deleted.");
        }
    }
}