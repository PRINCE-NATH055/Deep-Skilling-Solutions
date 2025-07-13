using Microsoft.AspNetCore.Mvc;
using EmployeeWebApi.Models;
using EmployeeWebApi.Filters;
using System;
using System.Collections.Generic;

namespace EmployeeWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [CustomAuthFilter] 
    public class EmployeeController : ControllerBase
    {
        private List<Employee> _employees;

        public EmployeeController()
        {
            _employees = GetStandardEmployeeList();
        }

     
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)] 
        public ActionResult<List<Employee>> GetStandard()
        {
            throw new Exception("Intentional exception to test CustomExceptionFilter");
           
        }

        [HttpPost]
        public ActionResult AddEmployee([FromBody] Employee employee)
        {
            _employees.Add(employee);
            return Ok(employee);
        }

        private List<Employee> GetStandardEmployeeList()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "John Doe",
                    Salary = 50000,
                    Permanent = true,
                    DateOfBirth = new DateTime(1990, 1, 1),
                    Department = new Department { Id = 1, Name = "HR" },
                    Skills = new List<Skill>
                    {
                        new Skill { Id = 1, Name = "Communication" },
                        new Skill { Id = 2, Name = "Recruitment" }
                    }
                },
                new Employee
                {
                    Id = 2,
                    Name = "Jane Smith",
                    Salary = 70000,
                    Permanent = false,
                    DateOfBirth = new DateTime(1985, 5, 23),
                    Department = new Department { Id = 2, Name = "Finance" },
                    Skills = new List<Skill>
                    {
                        new Skill { Id = 3, Name = "Accounting" },
                        new Skill { Id = 4, Name = "Excel" }
                    }
                }
            };
        }
    }
}
