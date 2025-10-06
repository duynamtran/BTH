using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225446_TranDuynam_Pattern01_Bridge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Abstraction ab = new RefinedAbstraction();
            // Set implementation and call
            ab.Implementor = new ConcreteImplementorA();
            ab.Operation();
            // Change implemention and call
            ab.Implementor = new ConcreteImplementorB();
            ab.Operation();
            // Wait for user
            Console.ReadKey();
        }
    }
}
