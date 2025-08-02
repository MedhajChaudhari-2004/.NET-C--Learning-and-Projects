using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Project_1
{
    internal class StaticConDemo
    {

        static StaticConDemo()
        {
            Console.WriteLine("this is a static constructor");
        }

        public StaticConDemo()
        {
            Console.WriteLine("this is a explicit constructor");
        }

        static void Main()

        {
            Console.WriteLine("this is a main function");
            StaticConDemo demo = new StaticConDemo();   
        }
    }
}
