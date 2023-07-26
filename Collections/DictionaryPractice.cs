using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingVS.Collections
{
    public class DictionaryPractice
    {
        public static void DictionaryMain()
        {
            var sense=new Dictionary<int,string>();
            sense.Add(1, "sight");
            sense.Add(2, "smell");
            sense.Add(3, "sound");
            sense.Add(4, "touch");
            sense.Add(5, "taste");

            foreach(var item in sense)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("printing in another way:");
            foreach (KeyValuePair<int,string> item in sense)
            {
                Console.WriteLine(item.Key+"  "+item.Value);
            }
        }
    }
}
