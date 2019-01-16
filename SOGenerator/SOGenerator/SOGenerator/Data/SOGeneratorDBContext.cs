using Microsoft.EntityFrameworkCore;
using SOGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOGenerator.Data
{
    public class SOGeneratorDBContext : DbContext
    {
        public SOGeneratorDBContext(DbContextOptions<SOGeneratorDBContext> options)
            : base(options)
        {
        }
        public DbSet<SalesOrder> SalesOrders { get; set; }
    }
}
