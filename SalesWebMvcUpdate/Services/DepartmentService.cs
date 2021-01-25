using Microsoft.EntityFrameworkCore;
using SalesWebMvcUpdate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvcUpdate.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcUpdateContext _context;
        public DepartmentService(SalesWebMvcUpdateContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
