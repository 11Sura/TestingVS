using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TestingVS.PracticeFramework
{
    public class Biographies:NonFiction
    {
      public Biographies():base() { }
        
       sealed public override void Title()
        {
            Console.WriteLine("Into the wild");
        }
       
        public override void Price()
        {
            Console.WriteLine("120 rupees");
        }
    }
}
