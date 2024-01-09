using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SeleWebMvc.Models;
using SeleWebMvc.Models.Enums;

namespace SeleWebMvc.Data
{
    public class SeleWebMvcContext : DbContext
    {
        public SeleWebMvcContext (DbContextOptions<SeleWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; } = default!;
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
     
    }
}
