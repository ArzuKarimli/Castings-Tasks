using Castings_practice.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castings_practice.Controllers
{
    internal class ProductController
    {
        private readonly IProductService _service;
        public ProductController()
        {
            _service = new ProductService();
        }

        public void GetAll()
        {
            var datas=_service.GetAll();
            foreach (var data in datas)
            {
                Console.WriteLine(data.Name+data.Price);
            }
        }

        public void GetById()
        {
            var data = _service.GetById(2);
            Console.WriteLine(data.Name + data.Price);
        }
    }
}