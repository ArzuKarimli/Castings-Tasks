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
    public class AuthorService : IAuthorService
    {
        public List<Author> SortAuthorsAge(int age)
        {

            var datas = AppDbContext.GetAll();
            List<Author> result = new List<Author>();
            DateTime NowDate = DateTime.Now;
            foreach (var author in datas)
            {
                int ages = NowDate.Year - author.DateTime.Year;
                if (age < ages)
                {
                    result.Add(author);
                }
            }
            return result;
        }

      

        
    }
}
