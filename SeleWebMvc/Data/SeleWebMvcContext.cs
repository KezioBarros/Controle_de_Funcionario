using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SeleWebMvc.Models;

namespace SeleWebMvc.Data
{
    public class SeleWebMvcContext : DbContext
    {
        public SeleWebMvcContext (DbContextOptions<SeleWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<SeleWebMvc.Models.Department> Department { get; set; } = default!;
    }
}
