using Microsoft.AspNetCore.Mvc;
using shop.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace shop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProviderController : ControllerBase
    {
        private static List<Provider> providers = new List<Provider>();
        [HttpGet]
        public List<Provider> Get()
        {
            return providers;
        }


        [HttpGet("{id}")]
        public ActionResult<Provider> Get(int id)
        {
            var provider = providers[id];
            if (provider == null)
                return NotFound();
            return Ok();
        }

        [HttpPost]
        public void Post([FromBody] Provider pro)
        {
            providers.Add(pro);
        }

        [HttpPut("{id}")]
        public ActionResult<Provider> Put(int id, [FromBody] Provider pro)
        {
            var provider = providers.Find(pro => pro.Id == id);
            if (provider == null)
                return NotFound();
            providers.Remove(provider);
            providers.Add(pro);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult<Provider> Delete(int id)
        {
            var pro = providers.Find(p => p.Id == id);
            if (pro == null)
                return NotFound();
            providers.Remove(pro);
            return Ok();
        }
    }
}
