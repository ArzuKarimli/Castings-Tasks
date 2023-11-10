using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castings_practice.Exceptions
{
    internal class LessThanZeroException : Exception
    {
        public LessThanZeroException() :this("Cannot be less than zero!")
        {
        }
        public LessThanZeroException(string msj) : base(msj) { }
       
    }
}
