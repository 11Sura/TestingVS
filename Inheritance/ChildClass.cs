using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingVS.Inheritance
{
    public class ChildClass:ParentClass, ParentInterface
    {
        public void ChMain()
        {
            
            Console.WriteLine("this is child class method");
            ParentClass.Parent();
        }

     
     public   void ParentInt()
        {
            Console.WriteLine("this is parent interface method");
        }
    }
}
