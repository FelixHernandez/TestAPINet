using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestAPINet.Models;

namespace TestAPINet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : ControllerBase
    {
        private Context _db;
        public EmployeesController(Context db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_db.Employees);
        }

        [HttpPost]
        public IActionResult Save(Employee employee)
        {
            _db.Employees.Add(employee);
            _db.SaveChanges();
            return Ok(employee);
        }

        [HttpPut("{Id}")]
        public IActionResult Update(int Id, Employee employee)
        {
            var _employee = _db.Employees.FirstOrDefault(x => x.Id == Id);
            if (_employee == null) return BadRequest("Employee Not Found");
            _db.Employees.Update(employee);
            _db.SaveChanges();
            return Ok(employee);
        }
        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            var _employee = _db.Employees.FirstOrDefault(x => x.Id == Id);
            if (_employee == null) return BadRequest("Employee Not Found");
            _employee.IsDeleted = true;
            return Ok(_employee);
        }
    }
}