using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingVS.Inheritance
{
    public class ParentClass
    {
        public static void Parent()
        {
            Console.WriteLine("this is parent class method");
        }
        public void ParentOverride()
        {
            Console.WriteLine("Hello from parent class");
        }
    }
}
