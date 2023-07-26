using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingVS.PracticeFramework
{
    public class Fiction:BookInterface
    {
        public Fiction() 
        {
            Console.WriteLine("fiction book details");
        }
        public Fiction(string name)
        {
            Console.WriteLine("deatils of " + name + " book");
        }
        public void Title()
        {
           
            Console.WriteLine("fiction title");
        }
        public void Author()
        {
            Console.WriteLine("fiction author");
        }
        public  void Price()
        {
            Console.WriteLine("fiction price");
        }

    }
}
