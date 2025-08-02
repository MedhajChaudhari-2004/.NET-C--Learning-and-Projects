using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Project_1
{
     class Class2
    {
        static void Main()
        {
            ProgramAccess pro = new ProgramAccess();
         // pro.Test1();  Not available duue to private class
            pro.Test2();
          //pro.Test3();  Not available due to no parent child relation in this class
            pro.Test4();
            pro.Test5();
            Console.ReadLine();
            
        }

    }
}
