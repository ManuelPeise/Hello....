using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("What's your name?");
            name = Console.ReadLine().ToString();

            Console.WriteLine("Hello " + name + "!");



        }
    }
}
