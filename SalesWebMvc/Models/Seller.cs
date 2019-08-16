using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Seller
    {

        public int id { get; set; }
        public string name { get; set; }
        public DateTime birthDate { get; set; }
        public double baseSalary { get; set; }
        
        public void addSales()
        {

        }

        public void removeSales()
        {

        }

        public double totalSales()
        {
            return 10;
        }



    }
}
