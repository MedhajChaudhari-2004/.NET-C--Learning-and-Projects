using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Project_1
{
    internal class ProgramAccess
    {
        private void Test1()
        {
            Console.WriteLine("this is a private method");
        }

        internal void Test2()
        {
            Console.WriteLine("this is a Internal Method");
        }

        protected void Test3()
        {
            Console.WriteLine("this is a protected Method");
        }

        protected internal void Test4()
        {
            Console.WriteLine("this is a protected Internal Method");

        }

        public void Test5()
        {
            Console.WriteLine("this is a public Method");
        }

        static void Main()
        {
            ProgramAccess p =  new ProgramAccess();

            p.Test1();
            p.Test2();
            p.Test3();
            p.Test4();
            p.Test5();
        }
    }
}
