using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingVS.Collections
{
    public class HashSetPractice
    {
        public static void HashMain()
        {
            var vowel = new HashSet<char>();
            vowel.Add('a');
            vowel.Add('e');
            vowel.Add('a'); //duplicate
            vowel.Add('i');
            vowel.Add('o');
            vowel.Add('a'); //duplicate
            vowel.Add('o'); //duplicate
            vowel.Add('a'); //duplicate
            vowel.Add('u');

            foreach (var item in vowel)
            {
                Console.WriteLine(item);
            }
        }
    }
}
