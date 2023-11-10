using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Data
{
    public static class AppDbContext
    {
        public static List<Author> GetAll()
        {
            return new List<Author>()
            {
                new Author() {Id=1,Name="Colleen",Surname="Hoover",DateTime=new (1982,09,15)},
                new Author() {Id=2,Name="Margaret",Surname="Atwood",DateTime=new (1962,09,18)},
                new Author() {Id=3,Name="Jhon",Surname="Green",DateTime=new (1978,10,10)},
                new Author() {Id=4,Name="Neil",Surname="Gaiman",DateTime=new (1975,06,05)},
                new Author() {Id=5,Name="Vi",Surname="Keeland",DateTime=new (1991,12,15)},
            };

        }

        public static List<Employee> GetAllEmployes()
        {
            return new List<Employee>()
            {
                new Employee(){Id=1,Name="Nergiz",Surname="Ehmedova",Salary=1200,Birthday=new(1992,02,17)},
                new Employee(){Id=2,Name="Nezrin",Surname="Abbasova",Salary=2200,Birthday=new(1993,02,15)},
                new Employee(){Id=3,Name="Ilahe",Surname="Memmedova",Salary=2500,Birthday=new(1984,03,14)},
                new Employee(){Id=4,Name="Tebriz",Surname="Axundov",Salary=3000,Birthday=new(1990,10,12)},
            };
        }

        public static List<Users> AllUsers()
        {
            return new List<Users>()
            {
                new Users() {Id=1,Fullname="Arzu Kerimli",Email="arzu@gmail.com",Password="arzu1998"},
                new Users() {Id=2,Fullname="Omer Kerimli",Email="omer@gmail.com",Password="omer1998"},
                new Users() {Id=3,Fullname="Hebibe Axundova",Email="hebibe@gmail.com",Password="hebibe1998"},
            };
        }

        public static List<Product> AllProducts() 
        {
            return new List<Product>()
            {
                new Product() {Id=1,Name="Iphone",Price=3000},
                new Product() {Id=2,Name="Samsung",Price=2000},
                new Product() {Id=3,Name="Nokia",Price=300},
                new Product() {Id=4,Name="HuaWei",Price=200},
            };
        }
    }
}
