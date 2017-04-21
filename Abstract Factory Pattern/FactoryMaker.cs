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
                case "1":
                    pf = new ConcreteFactory1();
                    break;
                case "2":
                    pf = new ConcreteFactory2();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter 1 or 2");
                    throw new ArgumentOutOfRangeException("Invalid choice. Please enter 1 or 2");
            }
            return pf;
        }
    }
}
