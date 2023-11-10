using Castings_practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castings_practice.Services.Interfaces
{
    internal interface IProductService
    {
        List<Product> GetAll();
        Product GetById(int id);
    }
}
