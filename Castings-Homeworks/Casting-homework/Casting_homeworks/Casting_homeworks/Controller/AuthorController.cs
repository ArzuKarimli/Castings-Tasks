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
    internal class AuthorController
    {
        public IAuthorService _authorService;
        public AuthorController()
        {
            _authorService = new AuthorService();
        }

        public void GetAge()
        {

            foreach (var author in _authorService.SortAuthorsAge(40))
            {
                Console.WriteLine(author.Name);
            }
        }
        
            
    }
}
