using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory pf = FactoryMaker.getFactory("b");
            AbstractProductA product = pf.CreateProductA();

            product.OperationA1();
            product.OperationA2();
            Console.ReadLine();

        }
    }
}
