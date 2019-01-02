using eCommerce.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.DAL
{
    public class Context:DbContext
    {
        public Context():base("eCommerce")
        {

        }
        public DbSet<Products> products { get; set; }
        public DbSet<Vendors> vendors { get; set; }
        public DbSet<ProductCategory> pCategory { get; set; }
        public DbSet<User> user { get; set; }
        public DbSet<Orders> orders { get; set; }
    }
}
