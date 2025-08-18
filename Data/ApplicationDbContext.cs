using Microsoft.EntityFrameworkCore;
using Nofuture1.Models.Entities;

namespace Nofuture1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
