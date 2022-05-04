using Microsoft.EntityFrameworkCore;

namespace firstazureapp.Models
{
    public class CompanyContext : DbContext
    {
        public DbSet<Employee> Employes { get; set; }

        public CompanyContext(DbContextOptions<CompanyContext> options)
        : base(options) { }
    }
}