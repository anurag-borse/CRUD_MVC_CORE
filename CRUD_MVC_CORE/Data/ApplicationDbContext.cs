using CRUD_MVC_CORE.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_MVC_CORE.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options) 
        {
            
        }

       public DbSet<Employee> Employees { get; set; }
    }
}
