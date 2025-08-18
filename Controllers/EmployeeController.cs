using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nofuture1.Data;
using Nofuture1.Models;
using Nofuture1.Models.Entities;

namespace Nofuture1.Controllers
{
    //localhost:xxxx/api/employee
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public EmployeeController(ApplicationDbContext dbContext) {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllEmployee()
        {
            var allEmployees = dbContext.Employees.ToList();
            return Ok(allEmployees);
        }

        [HttpPost]
        public IActionResult AddEmloyee(AddEmployeeDto addEmployeeDto)
        {
            var employeeEntity = new Employee()
            {
                HoTen = addEmployeeDto.HoTen,
                Tuoi = addEmployeeDto.Tuoi,
                Sdt = addEmployeeDto.Sdt,
                GioiTinh = addEmployeeDto.GioiTinh,
                PhongBan = addEmployeeDto.PhongBan,
                ViTri = addEmployeeDto.ViTri

            };


            dbContext.Employees.Add(employeeEntity);
            dbContext.SaveChanges();

            return Ok(employeeEntity);
        }

        //[HttpGet]
        //[Route("{id:int}")]
        //public IActionResult GetEmployee(int id)
        //{
        //    var empolyee = dbContext.Employees.Find(id);
        //    return Ok(empolyee);
        //}

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetEmployee(int id)
        {
            var employee = dbContext.Employees.Find(id);

            if (employee == null)
            {
                return NotFound();
            }


            return Ok(employee);
        }

        [HttpPut]
        [Route("{id:int}")]
        public IActionResult UpdateEmployee(int id, UpdateEmployeeDto updateEmployeeDto)
        {
            var employee = dbContext.Employees.Find(id);

            if(employee is null)
            {
                return NotFound();
            }

            employee.HoTen = updateEmployeeDto.HoTen;
            employee.Tuoi = updateEmployeeDto.Tuoi;
            employee.Sdt = updateEmployeeDto.Sdt;
            employee.GioiTinh= updateEmployeeDto.GioiTinh;
            employee.PhongBan = updateEmployeeDto.PhongBan;
            employee.ViTri = updateEmployeeDto.ViTri;

            dbContext.SaveChanges();

            return Ok(employee);

        }
        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult DeleteEmployee(int id)
        {
            var employee = dbContext.Employees.Find(id);

            if(employee is null)
            {
                return NotFound();
            }

            dbContext.Remove(employee);
            dbContext.SaveChanges();

            return Ok(employee);

        }
    }
}
