using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;


namespace SalesWebMvc.Data
{
    public class SeedingService
    {

        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {

            if (_context.Department.Any() || _context.SalesRecord.Any() || _context.Seller.Any())
            {
                return; // DB ja foi populado.
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Eduardo", "edu@edu", new DateTime(1984, 02, 01), 2000, d1);
            Seller s2 = new Seller(2, "Juliana", "ju@ju", new DateTime(1983, 03, 02), 3000, d2);
            Seller s3 = new Seller(3, "Liz", "liz@liz", new DateTime(1982, 04, 03), 4000, d1);
            Seller s4 = new Seller(4, "Eve", "eve@eve", new DateTime(1981, 05, 04), 5000, d4);
            Seller s5 = new Seller(5, "Luan", "luan@luan", new DateTime(1980, 06, 05), 6000, d3);
            Seller s6 = new Seller(6, "Vic", "vic@vic", new DateTime(1979, 07, 06), 7000, d2);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2019, 08, 01), 11000, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2019, 08, 02), 12000, SaleStatus.Billed, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2019, 08, 03), 13000, SaleStatus.Billed, s3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2019, 08, 04), 14000, SaleStatus.Billed, s4);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2019, 08, 05), 15000, SaleStatus.Billed, s5);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2019, 08, 06), 16000, SaleStatus.Billed, s6);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2019, 08, 07), 11000, SaleStatus.Billed, s6);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2019, 08, 08), 12000, SaleStatus.Billed, s5);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2019, 08, 09), 14000, SaleStatus.Billed, s4);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2019, 08, 10), 20000, SaleStatus.Billed, s3);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2019, 08, 11), 19000, SaleStatus.Billed, s2);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2019, 08, 12), 18000, SaleStatus.Billed, s1);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2019, 08, 13), 17000, SaleStatus.Billed, s2);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2019, 08, 13), 16000, SaleStatus.Billed, s3);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2019, 08, 14), 18000, SaleStatus.Billed, s4);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2019, 08, 15), 1000, SaleStatus.Billed, s5);
            SalesRecord r17 = new SalesRecord(17, new DateTime(2019, 08, 16), 2000, SaleStatus.Billed, s2);
            SalesRecord r18 = new SalesRecord(18, new DateTime(2019, 08, 17), 3000, SaleStatus.Billed, s3);
            SalesRecord r19 = new SalesRecord(19, new DateTime(2019, 08, 18), 4000, SaleStatus.Billed, s1);
            SalesRecord r20 = new SalesRecord(20, new DateTime(2019, 08, 19), 1000, SaleStatus.Billed, s2);
            SalesRecord r21 = new SalesRecord(21, new DateTime(2019, 08, 20), 6000, SaleStatus.Billed, s5);
            SalesRecord r22 = new SalesRecord(22, new DateTime(2019, 08, 21), 8000, SaleStatus.Billed, s6);
            SalesRecord r23 = new SalesRecord(23, new DateTime(2019, 08, 22), 9000, SaleStatus.Billed, s4);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14,
                r15, r16, r17, r18, r19, r20, r21, r22, r23);
            _context.SaveChanges();
        }

        

    }
}
