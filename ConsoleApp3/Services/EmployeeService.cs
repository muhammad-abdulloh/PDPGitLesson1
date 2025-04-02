using ConsoleApp3.Models;
using ConsoleApp3.Services.IServices;

namespace ConsoleApp3.Services
{
    class EmployeeService : IEmployeeService
    {
        public List<Employee> Xodimlar { get; set; } = new List<Employee>();

        public string CreateEmployee(Employee employee)
        {
            Xodimlar.Add(employee);

            return "Created employee";
        }

        public string DeleteEmployee(Guid Id)
        {
            try
            {
                Employee data = new Employee { };

                foreach (Employee x in Xodimlar)
                {
                    if (x.Id == Id)
                    {
                        data = x;
                        break;
                    }
                }

                Xodimlar.Remove(data);

                return "Removed";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public IEnumerable<Employee> GetAllEmployes()
        {
            return Xodimlar;
        }

        public Employee GetByIdEmployee(Guid Id)
        {
            Employee data = new Employee { };

            foreach (Employee x in Xodimlar)
            {
                if (x.Id == Id)
                {
                    data = x;
                    break;
                }
            }

            return data;
        }

        public Employee UpdateEmployee(Employee employee)
        {
            Employee result = new Employee();

            foreach (Employee data in Xodimlar)
            {
                if (data.Id == employee.Id)
                {

                    data.Salary = employee.Salary;
                    data.Surname = employee.Surname;
                    data.DateOfBirth = employee.DateOfBirth;
                    data.Name = employee.Name;
                    data.Position = employee.Position;

                    result = data;
                    break;
                }
            }

            return result;

            
        }
    }
}
