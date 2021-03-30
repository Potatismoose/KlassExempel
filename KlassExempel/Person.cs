using System;
using System.Collections.Generic;
using System.Text;

namespace KlassExempel
{
    static class Person
    {
        public static String Name { get; set; }

        public static void Jump()
        {
            Console.WriteLine($"{Name} hoppar");
        }
    }
}
