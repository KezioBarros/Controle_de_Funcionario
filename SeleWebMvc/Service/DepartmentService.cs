using SeleWebMvc.Data;
using SeleWebMvc.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SeleWebMvc.Service
{
    public class DepartmentService
    {
        private readonly SeleWebMvcContext _context;

        public DepartmentService(SeleWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
