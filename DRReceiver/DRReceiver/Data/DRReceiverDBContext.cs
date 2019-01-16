using DRReceiver.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DRReceiver.Data
{
    public class DRReceiverDBContext : DbContext
    {
        public DRReceiverDBContext(DbContextOptions<DRReceiverDBContext> options)
         : base(options)
        {
        }
        public DbSet<SalesOrder> SalesOrders { get; set; }
    }
}
