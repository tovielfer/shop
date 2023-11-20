using Microsoft.AspNetCore.Mvc;
using shop.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace shop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private static List <Employee> employees=new List<Employee>();
        [HttpGet]
        public List<Employee> Get()
        {
            return employees;
        }


        [HttpGet("{id}")]
        public ActionResult<Employee> Get(int id)
        {
            var employee = employees[id];
            if(employee == null)
                return NotFound();
            return Ok();        
        }

        [HttpPost]
        public void Post([FromBody] Employee emp)
        {
            employees.Add(emp);
        }

        [HttpPut("{id}")]
        public ActionResult<Employee> Put(int id, [FromBody] Employee emp)
        {
            var employee = employees.Find(emp => emp.Id == id);
            if (employee == null)
                return NotFound();
            employees.Remove(employee);
            employees.Add(emp);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult<Employee> Delete(int id)
        {
            Employee emp = employees.Find(emp => emp.Id == id);
            if(emp == null)
                return NotFound();
            employees.Remove(emp);
            return Ok();
        }
    }
}
