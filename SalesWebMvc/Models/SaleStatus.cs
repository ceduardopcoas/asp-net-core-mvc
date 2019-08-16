using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class SaleStatus
    {
        public int PENDING { get; set; }
        public int BILLED { get; set; }
        public int CANCELED { get; set; }

    }
}
