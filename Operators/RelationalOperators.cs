using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingVS.Operators
{
    internal class RelationalOperators
    {
        public void RelationalMain()
        {
            int x = 4, y = -9;
            Console.WriteLine("x= "+x+"  "+"y= "+y);
            if (x == y)
            {
                Console.WriteLine("x and y values are equal (x==y)");
            }
            else if(x != y ) 
            {
                Console.WriteLine("x and y  values are not equal (x!=y)");

            }
            else if(x<y)
            {
                Console.WriteLine("x is less than y (x<y)");
            }
            else if (x>y)
            {
                Console.WriteLine("x is greater than y(x>y)");
            }
            else if (x<=y) {
                Console.WriteLine("x is less than or equal to y (x<=y)");

            }
            else
            {
                Console.WriteLine("x is greater than or equal to y (x>=y)");
            }
        }
    }
}
