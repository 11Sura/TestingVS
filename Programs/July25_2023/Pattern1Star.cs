using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingVS.Programs.July25_2023
{
    internal class Pattern1Star
    {
        public void Pattern1Main() 
        {
            int num = 5;
            for(int i = num; i >0; i--)
            {
                for(int j = 1; j <= num; j++)
                {
                    if (i <= j)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();

            }
        }
    }
}
