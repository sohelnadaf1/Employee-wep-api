using EmployeeDb_Api.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDb_Api.Data.Services
{
    public class EmployeeService : IEmployeeService
    {
        private EmployeeDbContext _context;

        public EmployeeService(EmployeeDbContext context)
        {
            _context = context;
        }
        public List<Employee> Getdata()
        {
            var data =  _context.employees.ToList();
            return data;
        }
    }
}
