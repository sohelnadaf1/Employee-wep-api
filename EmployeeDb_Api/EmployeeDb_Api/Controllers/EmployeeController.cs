using EmployeeDb_Api.Data.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDb_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeService empService;

        public EmployeeController(IEmployeeService emp)
        {
            empService = emp;
        }

        [HttpGet("getall")]
        public IActionResult GetAllData()
        {
            var data = empService.Getdata();
            return Ok(data);
        }

    }
}
