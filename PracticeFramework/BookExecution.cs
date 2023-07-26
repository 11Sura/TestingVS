using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingVS.PracticeFramework
{
    public class BookExecution
    {
        
        public void BookMain()
        {
            BookInterface bi;

            bi = new Biographies();
            bi.Title();
            bi.Author();
            bi.Price();

            bi=new Fiction();
            bi = new Fiction("war and peace");
            bi.Title();
            bi.Author();
            bi.Price();

            bi = new SciFi();
            bi = new SciFi("Frankenstein");
            SciFi sf = new SciFi();
            sf.BookDetails();
            
        }
    }
}
