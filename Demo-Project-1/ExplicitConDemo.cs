using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Project_1
{
    internal class ExplicitConDemo
    {
        public ExplicitConDemo()
        {
            Console.WriteLine("The constructor is called :-");
        }

        public static void Main()
        {
            ExplicitConDemo obj1 = new ExplicitConDemo();
            ExplicitConDemo obj2 = new ExplicitConDemo();
            ExplicitConDemo obj3 = new ExplicitConDemo();
        }
    }
}
