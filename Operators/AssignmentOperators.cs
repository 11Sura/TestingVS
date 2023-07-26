using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingVS.Operators
{
    internal class AssignmentOperators
    {
        public void AssignmentMain()
        {
            int i = -7,j;
            Console.WriteLine("value of i= "+i);
            Console.WriteLine("Assigning value of i to j:");
            j = i;
            Console.WriteLine("j= " + j);
            j += i;
            Console.WriteLine("j= " + j);
            j -= i;
            Console.WriteLine("j= " + j);
            j *= i;
            Console.WriteLine("j= " + j);
            j /= i;
            Console.WriteLine("j= " + j);
            j %= i;
            Console.WriteLine("j= " + j);

        }
    }
}
