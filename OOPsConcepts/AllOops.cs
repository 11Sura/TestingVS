using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TestingVS.OOPsConcepts
{
    public class AllOops
    {
        private int num;
        public int SetNum
        {
            set { num = value; }
        }
        public int GetNum
        {
            get { return num; }
        }
        
    }
    public class EncapAccess:AllOops
    {
        public int n;
        public void EnMain()
        {
            
            AllOops all=new AllOops();
            all.SetNum = 5;
            n= all.GetNum;
            Console.WriteLine(n);
        }
        public void EncapMain()
        {
            Console.WriteLine(n*n);
        }
        public void EncapMain(int n)
        {
            Console.WriteLine("Given number is: "+n);
        }
    }

    public class AllOopInheritance:EncapAccess
    {
        public void InMain()
        {
            AllOopInheritance aoi = new AllOopInheritance();
            
            aoi.EncapMain(50);
            
        }
    }

    public interface AllOopAbstract
    {
        public void AbMain();
    }
    public class AbstractImplementation : AllOopAbstract
    {
        public void AbMain()
        {
            Console.WriteLine("Implemented interface method");
        }
        public virtual void AbVirtualMain()
        {
            Console.WriteLine("Method to be overridden");
        }
        
    }
    public class OverrideOutput : AbstractImplementation
    {
        public override void AbVirtualMain()
        {
            base.AbVirtualMain();
            Console.WriteLine("Overridden");
        }

    }

    
    

}
