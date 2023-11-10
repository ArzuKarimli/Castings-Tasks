using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castings_practice.Models
{
    internal class Bird : Animal
    {
        public Bird()
        {
            Console.WriteLine("Bird construcrtor");
        }
        public string Color { get; set; }
    }
}
