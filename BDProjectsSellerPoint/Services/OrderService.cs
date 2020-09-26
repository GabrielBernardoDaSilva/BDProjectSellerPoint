using BDProjectsSellerPoint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDProjectsSellerPoint.Services
{
    public class OrderService
    {
        List<Product> products { get;}

        public OrderService()
        {
            products = new List<Product>();          
        }

        public void addProduct(Product product) => products.Add(product);

        public void removeProduct(Product product) => products.Remove(product);

        public Product Product(string cod) => products.Where(p => p.Cod == cod).FirstOrDefault();

        public double totalOrder() => products.Sum(p => p.Price);

    }
}
