using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using crudops.Models;

namespace crudops.Data
{
    public class crudopsContext : DbContext
    {
        public crudopsContext (DbContextOptions<crudopsContext> options)
            : base(options)
        {
        }

        public DbSet<crudops.Models.Employee> Employee { get; set; } = default!;
    }
}
