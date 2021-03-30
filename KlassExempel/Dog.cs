using System;
using System.Collections.Generic;
using System.Text;

namespace KlassExempel
{
    class Dog
    {
        public String Name { get; set; }

        public void Bark()
        {
            Console.WriteLine($"{Name} skäller voff voff");
        }
    }
}
