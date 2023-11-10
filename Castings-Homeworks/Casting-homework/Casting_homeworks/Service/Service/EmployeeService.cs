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
    public class EmployeeService : IEmployeeService
    {
        public int CountEmployees(DateTime startDate, DateTime endDate, double salary)
        {
            int count = 0;
            var employees =AppDbContext.GetAllEmployes();

            foreach (var employee in employees)
            {
               
                if (employee.Birthday >= startDate && employee.Birthday <= endDate && employee.Salary > salary)
                {
                    count++;
                }
            }

            return count;
        }

        
    }
}
