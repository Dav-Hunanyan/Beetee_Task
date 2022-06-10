using Beetee_Task.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Beetee_Task.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HrDataController : Controller
    {
        static HrDataContext db;


        public HrDataController(HrDataContext context)
        {
            db = context;
        }


        [HttpGet]
        public IEnumerable<HrData> Get() => db.datas;

        [HttpGet("{id}")]

        public IActionResult Get(int id)
        {
            var data = db.datas.SingleOrDefault(x => x.Employee_Id == id);
            if (data == null)
            {
                return NotFound();
            }
            return Ok(data);
        }

        [HttpPost]

        public IActionResult Post(HrData data)
        {
            if (data == null)
            {
                return BadRequest();
            }

            db.datas.Add(data);
            return Ok(data);
        }

        [HttpPut]
        public IActionResult Put(HrData data)
        {
            if (data == null)
            {
                return BadRequest();
            }
            if (!db.datas.Any(x => x.Employee_Id == data.Employee_Id))
            {
                return BadRequest();
            }
            db.Update(data);
            return Ok(data);
        }

        [HttpDelete]


        public IActionResult Delete(int id)
        {
            HrData data = db.datas.FirstOrDefault(x => x.Employee_Id == id);
            if (data == null)
            {
                return NotFound();
            }
            db.datas.Remove(data);
            return Ok(data);
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
