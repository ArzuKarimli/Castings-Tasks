using Domain.Data;
using Service.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class AccountService : IAccountService
    {
        public bool Login(string email, string password)
        {
            var datas = AppDbContext.AllUsers();
            foreach (var user in datas)
            {
                if(user.Email==email && user.Password==password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
