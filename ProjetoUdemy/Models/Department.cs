
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoUdemy.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Seller> Selles { get; set; } = new List<Seller>();

        public Department()
        {
        }

        public Department(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void AddSeller(Seller seller)
        {
            Selles.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Selles.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
