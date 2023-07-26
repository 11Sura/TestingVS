using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingVS.Polymorphism
{
    internal class MethodOverloading
    {
        public void Overload()
        {
            Console.WriteLine("No argument method");
        }

        public void Overload(string arg) 
        {
            Console.WriteLine("String given is: "+arg);
        }
        public void Overload(int num1,int num2)
        {
            Console.WriteLine("Product of "+num1+" and "+num2+" is: "+(num1*num2));
        }
        public void Overload(String name,float num,String unit)
        {
            Console.WriteLine("The value of " + name + " is " + num+" "+unit);
        }

    }
}
