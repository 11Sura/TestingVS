using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingVS.Operators
{
    internal class ArithmeticOperators
    {
        public void ArithmeticMain()
        {
            int i = -11, j=76;

            Console.WriteLine("Number 1= "+i+"   "+"Number 2= "+j);

            Console.WriteLine("Sum: "+(i + j));
            Console.WriteLine("Difference: "+(i - j));
            Console.WriteLine("Product: "+(i * j));
            Console.WriteLine("Quotient: "+(j / i));
            Console.WriteLine("Remainder: "+(j % i));
        }
    }
}
