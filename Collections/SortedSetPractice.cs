using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingVS.Collections
{
    public class SortedSetPractice
    {
        public static void SortedMain()
        {
            var digits=new HashSet<int>();
            digits.Add(4);
            digits.Add(1);
            digits.Add(-7);
            digits.Add(0);
            digits.Add(9);
            digits.Add(4); //duplicate
            digits.Add(0); //duplicate

            foreach (var item in digits)
            {
                Console.WriteLine(item);
            }

        }
    }
}
