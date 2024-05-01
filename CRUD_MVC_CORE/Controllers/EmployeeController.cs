using CRUD_MVC_CORE.Data;
using CRUD_MVC_CORE.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_MVC_CORE.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeeController(ApplicationDbContext dbContext)
        {
            _context = dbContext;
            
        }

        public IActionResult Index()
        {
            var employee = _context.Employees.ToList();
            return View(employee);
        }


        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee) 
        {
            if (employee !=null)
            {
                _context.Employees.Add(employee);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }
            return View();

        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var emp = _context.Employees.Find(id);
            return View(emp);
        }

        [HttpPost]
        public IActionResult Edit(Employee employee)
        {

            if(employee!= null)
            {
                var employeeinDb = _context.Employees.Find(employee.Id);

                if (employeeinDb != null)
                {
                    employeeinDb.Name = employee.Name;
                    employeeinDb.Department = employee.Department;
                    employeeinDb.Salary = employee.Salary;  

                    _context.Employees.Update(employeeinDb);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View();
        }


        [HttpGet]
        public IActionResult Details(int id)
        {
            var emp = _context.Employees.Find(id);
            return View(emp);
        }



        [HttpGet]
        public IActionResult Delete(int id)
        {
            var emp = _context.Employees.Find(id);
            return View(emp);
        }

        [HttpPost]
        public IActionResult Delete(Employee employee)
        {
            if(employee!= null)
            {
                var empinDb = _context.Employees.Find(employee.Id);

                if (empinDb !=null)
                {
                    _context.Employees.Remove(empinDb);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                    
                }

            }




            return View();
        }

    }
}
