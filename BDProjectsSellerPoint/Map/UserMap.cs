using BDProjectsSellerPoint.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDProjectsSellerPoint.Map
{
    class UserMap : EntityTypeConfiguration<User>
    {
        public void Configure()
        {
            HasKey(u => u.Id);

            Property(u => u.Login).IsRequired().HasMaxLength(50).HasColumnName("USER_LOGIN");

            Property(u => u.Password).IsRequired().HasMaxLength(50).HasColumnName("USER_PASSWORD");

            ToTable("USER");
        }
    }
}
