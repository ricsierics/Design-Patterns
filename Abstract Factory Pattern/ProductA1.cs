using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern
{
    class ProductA1 : AbstractProductA
    {
        public ProductA1(string arg)
        {
            Console.WriteLine(string.Format("Hello {0}", arg));
        }

        public override void OperationA1()
        {
            Console.WriteLine("OperationA1 completed");
        }

        public override void OperationA2()
        {
            Console.WriteLine("OperationA2 completed");
        }
    }
}
