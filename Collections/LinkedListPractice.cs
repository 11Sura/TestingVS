using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingVS.Collections
{
    public class LinkedListPractice
    {
        public static void LinkedListMain()
        {
            var odd=new List<int>();
            odd.Add(81);
            odd.Add(11);
            odd.Add(27);
            odd.Add(-5);
            foreach(int i in odd)
            {
                Console.WriteLine(i);
            }
        }
    }
}
