using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service.Interfaces
{
    public interface IAccountService
    {
        bool Login(string email,string password);
    }
}
