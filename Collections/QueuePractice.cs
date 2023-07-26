using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingVS.Collections
{
    public class QueuePractice
    {
        public static void QueueMain()
        {
            var alpha=new Queue<string>();
            alpha.Enqueue("A");
            alpha.Enqueue("B");
            alpha.Enqueue("C");
            alpha.Enqueue("D");
            alpha.Enqueue("E");
            alpha.Enqueue("F");

            foreach (var item in alpha)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(alpha.Dequeue());
        }
    }
}
