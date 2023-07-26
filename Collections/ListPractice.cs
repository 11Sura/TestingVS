using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingVS.Collections
{
    public class ListPractice
    {
        public static void ListMain()
        {
            var anime = new List<String>();
            anime.Add("HxH");
            anime.Add("FMAB");
            anime.Add("One Piece");
            anime.Add("K Project");
            foreach (var item in anime)
            {
                Console.WriteLine(item);
            }
        }
    }
}
