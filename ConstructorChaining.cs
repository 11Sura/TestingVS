using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingVS
{
    public class ConstructorChaining
    {
    }
    public class SuperClass
    {
        public SuperClass() 
        {
            Console.WriteLine("Super class contructor");
        }
        public SuperClass(string word)
        {
            Console.WriteLine("Super class constructor says "+word);
        }
        public void SupMain()
        {
            Console.WriteLine("Hello from super class");
        }
    }

    public class SubClass : SuperClass
    {
        public SubClass() : base("hey") 
        {
            Console.WriteLine("Sub class constructor");
        }
        public void SubMain()
        {
            Console.WriteLine("hello from sub class");
        }
        

    }
}
