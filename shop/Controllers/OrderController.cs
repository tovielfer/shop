using Microsoft.AspNetCore.Mvc;
using shop.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace shop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private DataContext context;
        [HttpGet]
        public List<Order> Get()
        {
            return context.Orders;
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var order = context.Orders[id];
            if(order == null)
                return NotFound();
            return Ok(order);        
        }

        [HttpPost]
        public void Post([FromBody] Order ord)
        {
            context.Orders.Add(ord);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Order ord)
        {
            var order = context.Orders.Find(o => o.Id == id);
            if (order == null)
                return NotFound();
            context.Orders.Remove(order);
            context.Orders.Add(ord);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Order ord = context.Orders.Find(o => o.Id == id);
            if(ord == null)
                return NotFound();
            context.Orders.Remove(ord);
            return Ok();
        }
    }
}
