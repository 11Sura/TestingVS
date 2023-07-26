using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingVS.Abstraction
{
    abstract class AbstractionExample1
    {
        abstract public void AbMain();
        public void ConMain()
        {
            Console.WriteLine("this is a concrete method");
        }
        
    }
}
