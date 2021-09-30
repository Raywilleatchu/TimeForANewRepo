using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeAPI.Models;

namespace EmployeeAPI.Controllers
{
    [Route("api/employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet("ReadAll")]
        public List<Employee> readAll()
        {
            return DAL.ReadAllEmployees();
        }

        [HttpGet("ReadOne")]
        public Employee readOne(int id)
        {
            return DAL.ReadOneEmployee(id);
        }

        [HttpGet("ReadByDept")]
        public List<Employee> ReadByDepartment(string dept)
        {
            return DAL.ReadAllByDepartment(dept);
        }

        [HttpDelete("Delete")]
        public bool DeleteEmployee(int id)
        {
            return DAL.DeleteEmployee(id);
        }
        
        [HttpPost("Add")]
        public Employee addEmployee(Employee emp)
        {
            return DAL.AddEmployee(emp);
        }

        [HttpPut("Update")]
        public Employee updateEmployee(Employee emp)
        {
            return DAL.UpdateEmployee(emp);
        }
    }
}
