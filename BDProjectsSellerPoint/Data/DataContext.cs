using BDProjectsSellerPoint.Map;
using BDProjectsSellerPoint.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDProjectsSellerPoint.Data
{
    class DataContext : DbContext
    {


        public DbSet<Product> products { get; set; }

        public DbSet<User> Users { get; set; }

        public DataContext() : base("Server=DESKTOP-RD0K8GL\\SQLEXPRESS;Database=SellerPointDb;Integrated Security=True;")
        {

        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new ProductMap());
        }



    }

    
}
