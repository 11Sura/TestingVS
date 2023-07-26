using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingVS.PracticeFramework
{
    public class SciFi:Fiction
    {
        public SciFi(String name):base(name) 
        {
            Console.WriteLine(name+" is a science fiction book");
        }
        public SciFi():base() 
        { }
       
        
        public void BookDetails()
        {
            this.Title();
            base.Author();
            this.Price();
        }
        
    }
}
