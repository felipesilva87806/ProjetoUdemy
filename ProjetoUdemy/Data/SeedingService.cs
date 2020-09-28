using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoUdemy.Models;
using Microsoft.AspNetCore.Http.Connections;
using ProjetoUdemy.Models.Enums;

namespace ProjetoUdemy.Data
{
    public class SeedingService
    {
        private ProjetoUdemyContext _cotext;

        public SeedingService(ProjetoUdemyContext cotext)
        {
            _cotext = cotext;
        }

        public void Seed()
        {
            if (_cotext.Department.Any() ||
                _cotext.Seller.Any() ||
                _cotext.SalesRecord.Any())
            {
                return;// BD já foi populado
            }

            Department d1 = new Department(1, "Computadores");
            Department d2 = new Department(2, "Eletronicos");
            Department d3 = new Department(3, "Livros");

            Seller s1 = new Seller(1, "Felipe", "felipe.com",new DateTime(1992, 10, 10) , 1000.0, d1);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2019, 09, 28), 1100.0, SaleStatus.Billed,s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2019, 09, 27), 2000.0, SaleStatus.Canceled, s1);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2019, 09, 26), 7000.0, SaleStatus.Peding, s1);

            _cotext.Department.AddRange(d1, d2, d3);
            _cotext.Seller.AddRange(s1);
            _cotext.SalesRecord.AddRange(r1, r2,r3);

            _cotext.SaveChanges();

        }

    }
}
