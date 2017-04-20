using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern
{
    class FactoryMaker
    {
        private static AbstractFactory pf = null;
        public static AbstractFactory getFactory(string choice)
        {
            switch (choice)
            {
                case "a":
                    pf = new ConcreteFactory1();
                    break;
                case "b":
                    pf = new ConcreteFactory2();
                    break;
                default:
                    break;
            }
            return pf;
        }
    }
}
