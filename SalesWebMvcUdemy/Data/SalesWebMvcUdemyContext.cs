using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvcUdemy.Models;

namespace SalesWebMvcUdemy.Data
{
    public class SalesWebMvcUdemyContext : DbContext
    {
        public SalesWebMvcUdemyContext (DbContextOptions<SalesWebMvcUdemyContext> options)
            : base(options)
        {
        }

        public DbSet<SalesWebMvcUdemy.Models.Department> Department { get; set; }
    }
}
