using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingVS.Programs.July25_2023
{
    internal class ArrayMinSum
    {
        public static void ArrMain()
        {
            int[] a = { 8, 4, 7, -11, 45, 2, 9,2 };
            for(int i = 0; i < a.Length; i++)
            {
                for(int j=i+1; j<a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i]; 
                        a[i] = a[j];
                        a[j] = temp;
                    }

                    
                }
                Console.WriteLine(a[i]);

            }
            int sum=0;
            for(int i=0; i < a.Length; i++)
            {
                sum += a[i];

            }
            Console.WriteLine("Sum of all numbers in the array is: "+sum);
        }
       
        
    }
}
