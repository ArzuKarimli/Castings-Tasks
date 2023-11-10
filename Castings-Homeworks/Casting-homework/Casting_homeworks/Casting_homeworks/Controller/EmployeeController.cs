using Service.Service;
using Service.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting_homeworks.Controller
{
    internal class EmployeeController
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController()
        {
            _employeeService=new EmployeeService();
        }
         public void CountEmployees()
        {
            DateTime startDate = new(1985, 01, 01);
            DateTime endDate = new(2000, 01, 01);
            double salary = 2000;
            var result=_employeeService.CountEmployees(startDate, endDate, salary);
            Console.WriteLine(result);
        }

    }
}
