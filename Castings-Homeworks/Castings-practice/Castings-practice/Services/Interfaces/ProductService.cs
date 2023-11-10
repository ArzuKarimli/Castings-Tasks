using Castings_practice.Data;
using Castings_practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castings_practice.Services.Interfaces
{
    internal class ProductService : IProductService
    {
        public List<Product> GetAll()
        {
            return AppDbContext.Products();
        }

        public Product GetById(int id)
        {
            return AppDbContext.Products().FirstOrDefault(m => m.Id == id);

        }
    }
}
