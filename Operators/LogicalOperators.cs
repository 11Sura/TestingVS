using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingVS.Operators
{
    internal class LogicalOperators
    {
        public void LogicalMain()
        {
            int a=11,b=-12;
            Console.WriteLine("a= " + a + " " + "b= " + b);
            if ((a>0)&&(b>0))
            {
                Console.WriteLine("(a>0) && (b<0) : result= true");

            }
            else if((a>0)||(b<0))
            {
                Console.WriteLine("(a>0) || (b<0) : result= true");
            }
            else
            {
                Console.WriteLine("result: false");
            }
        }
    }
}
