using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Company>? Companies { get; set; }
        public DbSet<Employee>? Employees { get; set; }
    }
}