using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingVS.Collections
{
    public class StackPractice
    {
        public static void StackMain()
        {
            var days=new Stack<string>();
            days.Push("Saturday");
            days.Push("Friday");
            days.Push("Thursday");
            days.Push("Wednesday");
            days.Push("Tuesday");
            days.Push("Monday");
            days.Push("Sunday");

            foreach (var item in days)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(days.Peek());
            Console.WriteLine(days.Pop());
        }
    }
}
