using ListaApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ListaApi.Controllers
{
    public class PdfGeneratorController : Controller
    {
        public IActionResult Index()
        {
            var itDepartments = new Department
            {
                Name = "It"
            };
            var salesDepartment = new Department
            {
                Name = "Sales"
            };
            var employees = new List<Employee>
            {
                new Employee
                {
                    EmployeeId = 1,
                    CompleteName = "Jonh",
                    Salary = 40000,
                    Department = itDepartments,
                },
                 new Employee
                {
                    EmployeeId = 2,
                    CompleteName = "Carl",
                    Salary = 50000,
                    Department = salesDepartment,
                },
            };
            return View(employees);
        }
    }
}
