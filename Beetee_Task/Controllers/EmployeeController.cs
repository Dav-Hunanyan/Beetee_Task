using Microsoft.AspNetCore.Mvc;
using Beetee_Task.Models;
using System.Collections.Generic;
using System.Linq;

namespace Beetee_Task.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {

        public static EmployeeContext db;
        public EmployeeController(EmployeeContext context)
        {
            db = context;          
        }

        [HttpGet]
        public IEnumerable<Employee> Get() => db.Employees;

        [HttpGet("{id}")]

        public IActionResult Get(int id)
        {
            var employee = db.Employees.SingleOrDefault(x => x.ID == id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }
        [HttpPost]

        public IActionResult Post(Employee employee)
        {
            if (employee == null)
            {
                return BadRequest();
            }

            db.Employees.Add(employee);
            db.SaveChanges();

            return Ok(employee);
        }

        [HttpPut]

        public IActionResult Put(Employee employee)
        {
            if (employee == null)
            {
                return BadRequest();
            }
            if (!db.Employees.Any(x => x.ID == employee.ID))
            {
                return NotFound();
            }
            db.Update(employee);
            return Ok(employee);
        }


        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            Employee employee = db.Employees.FirstOrDefault(x => x.ID == id);
            if (employee == null)
            {
                return NotFound();
            }

            db.Remove(employee);
            db.SaveChanges();
            return Ok(employee);
        }


        //public IActionResult Index() { return View(); }



    }
}

