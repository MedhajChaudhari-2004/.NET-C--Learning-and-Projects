using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Project_1
{
    internal class ParameterizedConDemo
    {
        int x;
        public ParameterizedConDemo(int i)
        {
            x = i;
            Console.WriteLine("Constructor is called:-" + i);
        }
        public void Display()
        {
            Console.WriteLine("The value is :- " + x);
        }

        static void Main(string[] args)
        {
            ParameterizedConDemo cd1 = new ParameterizedConDemo(10);
            ParameterizedConDemo cd2 = new ParameterizedConDemo(20);
            cd1.Display();
            cd2.Display();

        }
    }
}
