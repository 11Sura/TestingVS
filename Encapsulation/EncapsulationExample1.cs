using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TestingVS.Encapsulation
{
    public class EncapsulationExample1
    {
        private string P1="abc";
        public string GetP1              //this is calles properties, works like a method:
        {                                //can use the same property for both getter and setter or different
            get { return P1; }           //get, set, value are keywords
            //set { P1 = value; }
        }
        public string SetP1
        {
            set { P1 = value; }
        }

        //below shown are getter and setter methods similar to java
        public string GetP2()
        {
            return P1;
        }
        public void SetP2(string value) 
        { 
        P1 = value;
        }
        
    }

    public class EncapsulationAccess: EncapsulationExample1
    {
        
        public static void EncapMain()
        {
            EncapsulationExample1 ee = new EncapsulationExample1();
            Console.WriteLine(ee.GetP1);
            ee.SetP1 = "xyz";
            Console.WriteLine(ee.GetP1);

            //accessing getter and setter mtds similar to java below:
            ee.SetP2("123");
            Console.WriteLine(ee.GetP2());
        }
    }
}
