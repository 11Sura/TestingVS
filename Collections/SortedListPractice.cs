using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingVS.Collections
{
    public class SortedListPractice
    {
        public static void SortedListMain()
        {
            var month=new SortedList<int,string>();
            month.Add(9, "Sept");
            month.Add(1, "Jan");
            month.Add(5, "May");
            month.Add(2, "Feb");

            foreach (var item in month)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("printing in another way:");
            foreach (KeyValuePair<int, string> item in month)
            {
                Console.WriteLine(item.Key + "  " + item.Value);
            }
        }
    }
}
