using Microsoft.AspNetCore.Mvc;
using shop.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace shop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private DataContext context;
        [HttpGet]
        public List<Product> Get()
        {
            return context.Products;
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = context.Products.Find(pro => pro.Id == id);
            if (product == null)
                return NotFound();
            return Ok(product);
        }

        [HttpPost]
        public void Post([FromBody] Product pro)
        {
            context.Products.Add(pro);
        }

        [HttpPut("{id}/Price")]

        public IActionResult Put(int id, [FromBody] int price)
        {
            var product = context.Products.Find(pro => pro.Id == id);
            if (product == null)
                return NotFound();
            product.Price=price;
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Product pro)
        {
            var product = context.Products.Find(p => p.Id == id);
            if (product == null)
                return NotFound();
            context.Products.Remove(product);
            context.Products.Add(pro);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var product = context.Products.Find(pro => pro.Id == id);
            if (product == null)
                return NotFound();
            context.Products.Remove(product);
            return Ok();
        }
    }
}
