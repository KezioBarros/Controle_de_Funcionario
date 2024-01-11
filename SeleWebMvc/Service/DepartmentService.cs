using SeleWebMvc.Data;
using SeleWebMvc.Models;
using System.Collections.Generic;

namespace SeleWebMvc.Service
{
    public class DepartmentService
    {
        private readonly SeleWebMvcContext _context;

        public DepartmentService(SeleWebMvcContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
