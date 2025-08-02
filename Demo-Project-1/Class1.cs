using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Project_1
{   
    // consuming method from a child class
    class Class1 : ProgramAccess
    {
        static void Main()
        {
            
            Class1 c = new Class1();
           // c.Test1();   No run due to private
            c.Test2();
            c.Test3();
            c.Test4();
            c.Test5();

        }

    }
}
