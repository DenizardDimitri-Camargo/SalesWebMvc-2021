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

        public DbSet<SalesWebMvcUpdate.Models.Department> Department { get; set; }
    }
}
