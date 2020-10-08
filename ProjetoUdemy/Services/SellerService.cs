using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoUdemy.Data;
using ProjetoUdemy.Models;

namespace ProjetoUdemy.Services
{
    public class SellerServices
    {
        private readonly ProjetoUdemyContext _context;

        public SellerServices(ProjetoUdemyContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            obj.Department = _context.Department.First();
            _context.Add(obj);
            _context.SaveChanges();
        }

    }
}
