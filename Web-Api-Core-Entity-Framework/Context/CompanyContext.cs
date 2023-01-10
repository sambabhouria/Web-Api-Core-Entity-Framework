using Microsoft.EntityFrameworkCore;
using Web_Api_Core_Entity_Framework.Models;

namespace Web_Api_Core_Entity_Framework.Context
{
    public class CompanyContext
         : DbContext
    {
        public CompanyContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
