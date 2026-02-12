
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly DBContext Context;
        public EmployeesController(DBContext context) { 
            this.Context = context; ;
        }

        [HttpGet]
        public IActionResult GetAllEmployee()
        {
            var Employees = Context.Employees.ToList();

            return Ok(Employees);
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public IActionResult GetEmployeeById(Guid id)
        {
            var employee = Context.Employees.Find(id);

            if(employee is null)
            {
                return NotFound();
            }

            return Ok(employee);

        }

        [HttpPost]
        public IActionResult AddEmployee(EmployeeDTO addEmployee)
        {
            var newEmployee = new Employee()
            {
                Name = addEmployee.Name,
                Email = addEmployee.Email,
                Phone = addEmployee.Phone
            };

            Context.Employees.Add(newEmployee);
            Context.SaveChanges();

            return Ok(newEmployee);
        }

        [HttpPut]
        [Route("{id:Guid}")]
        public IActionResult UpdateEmployee(Guid id, UpdateEmployeeDTO UpdateEmployee)
        {
            var employee = Context.Employees.Find(id);

            if (employee is null)
            {
                return NotFound();
            }

            employee.Name = UpdateEmployee.Name;
            employee.Email = UpdateEmployee.Email;
            employee.Phone = UpdateEmployee.Phone;

            Context.SaveChanges();
            return Ok(employee);
        }

        [HttpDelete]
        public IActionResult DeleteEmployee(Guid id) { 
            var employee = Context.Employees.Find(id);
            Context.Employees.Remove(employee);

            Context.SaveChanges();
            return Ok(); 
        }
    }
}
