using Domain.Models;
using Service.Service;
using Service.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting_homeworks.Controller
{
    internal class AccountController
    {
        IAccountService _accountService;

        public AccountController()
        {
            _accountService = new AccountService();
        }

        public void Login()
        {
            Console.WriteLine("Enter your email:");
            string email = Console.ReadLine();
            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();

            if (_accountService.Login(email, password))
            {
                Console.WriteLine("Login success");
                Console.WriteLine("1:All Products");
                Console.WriteLine("2:Enter SearchText");
                int choose = int.Parse(Console.ReadLine());
                ProductService productService = new ProductService();
                switch (choose)
                {
                    case 1:
                        List<Product> products = productService.GetProducts();
                        foreach (var product in products)
                        {
                            Console.WriteLine(product.Name + "-" + product.Price);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Write SearchText:");
                        string searchtext = Console.ReadLine();
                        List<Product> allproducts = productService.SearchProduct(searchtext);
                        foreach (var product in allproducts)
                        {
                            Console.WriteLine(product.Name + "-" + product.Price);
                        }
                        break;

                

                }

            }
            else
            {
                Console.WriteLine("Login or email incorrect");
            }
        }

    }
}
