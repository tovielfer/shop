using Microsoft.AspNetCore.Mvc;
using shop.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace shop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProviderController : ControllerBase
    {
        private DataContext context;
        [HttpGet]
        public List<Provider> Get()
        {
            return context.Providers;
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var provider = context.Providers[id];
            if (provider == null)
                return NotFound();
            return Ok(provider);
        }

        [HttpPost]
        public void Post([FromBody] Provider pro)
        {
            context.Providers.Add(pro);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Provider pro)
        {
            var provider = context.Providers.Find(pro => pro.Id == id);
            if (provider == null)
                return NotFound();
            context.Providers.Remove(provider);
            context.Providers.Add(pro);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var pro = context.Providers.Find(p => p.Id == id);
            if (pro == null)
                return NotFound();
            context.Providers.Remove(pro);
            return Ok();
        }
    }
}
