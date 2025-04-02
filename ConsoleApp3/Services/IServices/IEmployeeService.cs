using ConsoleApp3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Services.IServices
{
    interface IEmployeeService
    {
        public string CreateEmployee(Employee employee);
        public Employee GetByIdEmployee(Guid Id);
        public IEnumerable<Employee> GetAllEmployes();
        public Employee UpdateEmployee(Employee employee);
        public string DeleteEmployee(Guid Id);
    }
}
