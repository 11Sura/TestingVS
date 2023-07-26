using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingVS.Polymorphism
{
    public class MethodOverridding
    {
        public virtual void VirtualMain()
        {
            Console.WriteLine("initial method");
        }
    }

    public class OverrideExample: MethodOverridding
    { 
        public override void VirtualMain()
        {
            Console.WriteLine("Method overridden");
        }
    }

    public class OverridingOutput
    {
        public static void OverrideMain()
        {
            OverrideExample oe=new OverrideExample();
            oe.VirtualMain();
        }
    }
}
