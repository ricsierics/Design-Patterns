using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern
{
    class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2("Product A2");
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB2("Product B2");
        }
    }
}
