using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvcUpdate.Models;

namespace SalesWebMvcUpdate.Data
{
    public class SalesWebMvcUpdateContext : DbContext
    {
        public SalesWebMvcUpdateContext (DbContextOptions<SalesWebMvcUpdateContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
