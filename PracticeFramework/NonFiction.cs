using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingVS.PracticeFramework
{
    public abstract class NonFiction: BookInterface
    {
        public NonFiction() 
        {
            Console.WriteLine("Non fiction book details");
        }

        const string bookRating = "good";
        public virtual void Title()
        {
            Console.WriteLine("non fiction title");
        }
        public  void Author()
        {
            Console.WriteLine("non fiction author");
        }
        public abstract void Price();
        

        
    }
}
