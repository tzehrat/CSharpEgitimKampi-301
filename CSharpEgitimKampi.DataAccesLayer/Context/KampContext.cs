﻿using CSharpEgitimKampi301.EntityLayer;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi.DataAccesLayer.context
{
    public class KampContext:DbContext // veri tabanına yansıtmak isteiğimiz sınıflar bunun içnde yer alıcak
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet< Order  > Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }
    
    
    
    
    
    }
}
