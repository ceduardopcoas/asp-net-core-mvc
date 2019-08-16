using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {

        public int id { get; set; }
        public DateTime date { get; set; }
        public double amount { get; set; }
        public SaleStatus status { get; set; }
    }
}
