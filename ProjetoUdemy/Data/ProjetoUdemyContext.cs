﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoUdemy.Models;

namespace ProjetoUdemy.Data
{
    public class ProjetoUdemyContext : DbContext
    {
        public ProjetoUdemyContext (DbContextOptions<ProjetoUdemyContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }

    }
}
