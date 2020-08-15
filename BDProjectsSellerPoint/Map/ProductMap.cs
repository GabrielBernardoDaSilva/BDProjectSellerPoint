using BDProjectsSellerPoint.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDProjectsSellerPoint.Map
{
    class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {


            HasKey(p => new { p.Id, p.Cod });


            Property(p => p.Cod).IsRequired().HasMaxLength(50).HasColumnName("PROD_CODE");
            Property(p => p.Description).IsRequired().HasMaxLength(50).HasColumnName("PROD_DESCRIPTION");
            Property(p => p.Price).IsRequired().HasColumnName("PROD_PRICE");
            Property(p => p.Quantity).IsRequired().HasColumnName("PROD_QUANTITY");


            ToTable("PROD");
        }

        

    }
}
