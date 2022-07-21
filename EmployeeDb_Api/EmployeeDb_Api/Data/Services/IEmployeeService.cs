using EmployeeDb_Api.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDb_Api.Data.Services
{
    public interface IEmployeeService 
    {
        public List<Employee> Getdata();
    }
}
