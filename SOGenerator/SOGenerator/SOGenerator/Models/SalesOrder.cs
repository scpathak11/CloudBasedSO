using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SOGenerator.Models
{
    public class SalesOrder
    {
        [Key]
        public int Id { get; set; }
        public string ItemCode { get; set; }
        public string CustomerCode { get; set; }
        public int Quantity { get; set; }
    }
}
