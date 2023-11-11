using Domain.Data;
using Domain.Models;
using Service.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class ProductService : IProductService
    {
       
        public List<Product> GetProducts()
        {
            return AppDbContext.AllProducts();
        }

        public List<Product> SearchProduct(string searchText)
        {
            List<Product> products = AppDbContext.AllProducts();
            List<Product> filteredProducts=new List<Product>();
           foreach (var product in AppDbContext.AllProducts())
            {
                if (product.Name.ToLower().Contains(searchText.ToLower()))
                {
                   filteredProducts.Add(product);
                }
            }
            return filteredProducts;
        }
    }
}
