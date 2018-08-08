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
            hallo h = new hallo();
            Tschuess t = new Tschuess();

            string name;

            name = h.sayHello();
            t.sayBye(name);
            

        }
    }
}
