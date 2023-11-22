﻿using Microsoft.AspNetCore.Mvc;
using shop.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace shop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<Product> products = new List<Product>();
        [HttpGet]
        public List<Product> Get()
        {
            return products;
        }


        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            var product = products.Find(pro => pro.Id == id);
            if (product == null)
                return NotFound();
            products.Remove(product);
            products.Add(product);
            return Ok();
        }

        [HttpPost]
        public void Post([FromBody] Product pro)
        {
            products.Add(pro);
        }

        [HttpPut("{id}/Price")]

        public ActionResult<Product> Put(int id, [FromBody] int price)
        {
            var product = products.Find(pro => pro.Id == id);
            if (product == null)
                return NotFound();
            product.Price=price;
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Product pro)
        {
            var product = products.Find(p => p.Id == id);
            if (product == null)
                return NotFound();
            products.Remove(product);
            products.Add(pro);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult<Product> Delete(int id)
        {
            var product = products.Find(pro => pro.Id == id);
            if (product == null)
                return NotFound();
            products.Remove(product);
            return Ok();
        }
    }
}
