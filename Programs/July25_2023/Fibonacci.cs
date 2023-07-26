using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingVS.Programs.July25_2023
{
    internal class Fibonacci
    {
        public static void fibMain()
        {

            int limit=10, n1=0, n2=1,n3;
            Console.Write(n1+" "+n2+" ");
            while (limit > 0)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
                limit--;
            }
            
                
        }
    }
}
