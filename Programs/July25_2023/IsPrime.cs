using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingVS.Programs.July25_2023
{
    internal class IsPrime
    {
       public static void PrimeMain()
        {
            int num = 12;
            int count = 0;
            for(int i = 2; i < num/2;i++)
            {
              if(num%i == 0)
                {
                    count++;
                }
                
            }
            if(count >0) 
            {
                Console.WriteLine("The number "+num+" is not a prime number");
            }
            else
            {
                Console.WriteLine("The number "+num+" is a prime number");
            }
        }
        
    }
}
