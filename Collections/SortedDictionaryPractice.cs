using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace TestingVS.Collections
{
    public class SortedDictionaryPractice
    {
        public static void SortedDictionaryMain() 
        { 
            var num=new SortedDictionary<int, string>();
            num.Add(4, "four");
            num.Add(1, "one");
            num.Add(32, "thirty two");
            num.Add(11, "eleven");

            foreach(var item in num)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("printing in another way:");
            foreach (KeyValuePair<int, string> item in num)
            {
                Console.WriteLine(item.Key + "  " + item.Value);
            }
        }
    }
}
