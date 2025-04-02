
using ConsoleApp3.Models;
using ConsoleApp3.Services;
using ConsoleApp3.Services.IServices;
using Microsoft.Win32.SafeHandles;
using System.Collections;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        // create qilmoqchiman
        EmployeeService employeeService = new EmployeeService();

        while (true)
        {
            JumpToHigth:;

            int choosenNumber = 0;

            Console.WriteLine("Amalni tanlang: ");
            Console.WriteLine("1: Create");
            Console.WriteLine("2: Delete");
            Console.WriteLine("3: Update");
            Console.WriteLine("4: GetById");
            Console.WriteLine("5: GetAll");

            choosenNumber = int.Parse(Console.ReadLine());

            if (choosenNumber == 1)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Surname: ");
                string surname = Console.ReadLine();

                Console.Write("Position: ");
                string position = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());

                Console.WriteLine("Yil: ");
                int yil = int.Parse(Console.ReadLine());

                Console.WriteLine("Oy: ");
                int oy = int.Parse(Console.ReadLine());

                Console.WriteLine("Kun: ");
                int kun = int.Parse(Console.ReadLine());


                Employee data = new Employee()
                {
                    Name = name,
                    Surname = surname,
                    Position = position,
                    DateOfBirth = new DateTime(yil, oy, kun),
                    Salary = salary
                };


                var result = employeeService.CreateEmployee(data);

                Console.WriteLine(result);
            }
            else if (choosenNumber == 2)
            {
                var myId = Guid.Parse(Console.ReadLine());
                var result = employeeService.DeleteEmployee(myId);

                Console.WriteLine(result);
            }
            else if (choosenNumber == 3)
            {
                Console.WriteLine("Id ni kirgazing: ");
                var employeeId = Guid.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Surname: ");
                string surname = Console.ReadLine();

                Console.Write("Position: ");
                string position = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());

                Console.Write("Yil: ");
                int yil = int.Parse(Console.ReadLine());

                Console.Write("Oy: ");
                int oy = int.Parse(Console.ReadLine());

                Console.Write("Kun: ");
                int kun = int.Parse(Console.ReadLine());


                Employee data = new Employee()
                {
                    Id = employeeId,
                    Name = name,
                    Surname = surname,
                    Position = position,
                    DateOfBirth = new DateTime(yil, oy, kun),
                    Salary = salary
                };
                var result = employeeService.UpdateEmployee(data);

                Console.WriteLine($"Id:{result.Id} Name: {result.Name}, Surname: {result.Surname}, Position: {result.Position}, DateOfBirth: {result.DateOfBirth}, Salary: {result.Salary}");
            }
            else if (choosenNumber == 4)
            {
                Console.Write("Id ni kiriting: ");
                var Id = Guid.Parse(Console.ReadLine());

                var result = employeeService.GetByIdEmployee(Id);
            }
            else if (choosenNumber == 5)
            {

                IEnumerable<Employee> employees = employeeService.GetAllEmployes();

                foreach (var employee in employees)
                {
                    Console.WriteLine($"Id: {employee.Id} Name: {employee.Name}, Position: {employee.Position}, DateOfBirth: {employee.DateOfBirth}, Salary: {employee.Salary}");
                }

            }
            else
            {
                goto JumpToHigth;
            }
            

        }
    }
  
}