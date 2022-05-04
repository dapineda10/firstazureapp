using firstazureapp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace firstazureapp.Controllers
{
    public class EmployeeController : Controller
    {
        public CompanyContext _context;
        public EmployeeController(CompanyContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var employees = from a in _context.Employes
                            select a;
            return View("Index",employees.ToList());
        }

        [HttpPost]
        public IActionResult Create(Employee employee) 
        {
            employee.Id = Guid.NewGuid().ToString();
            _context.Employes.Add(employee);
            _context.SaveChanges();
            
            return View(); 
        }

        public IActionResult Create()
        {
            return View("Create");
        }
    }
}
