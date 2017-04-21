using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern
{
    class ProductB1 : AbstractProductB
    {
        public ProductB1(string args)
        {
            Console.WriteLine(string.Format("Hello {0}", args));
        }

        public override void OperationB1()
        {
            Console.WriteLine("Operation B1 completed");
        }

        public override void OperationB2()
        {
            Console.WriteLine("Operation B2 completed");
        }
    }
}
