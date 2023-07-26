using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingVS.Abstraction
{
    public abstract class AbstractionExample1
    {
        public abstract void AbMain();
        public void ConMain()
        {
            Console.WriteLine("this is a concrete method");
        }
        
    }

    public class AbstractionOutput: AbstractionExample1
    {
        public override void AbMain()
        {
            Console.WriteLine("Implemented abstract method here");
        }

        public static void AbstractMain()
        {
            AbstractionExample1 example = new AbstractionOutput();
            example.ConMain();
            example.AbMain();
        }
    }
}
