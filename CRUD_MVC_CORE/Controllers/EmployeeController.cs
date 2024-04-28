using CRUD_MVC_CORE.Data;
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
      
    }
}
