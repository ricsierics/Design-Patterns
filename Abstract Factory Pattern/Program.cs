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
            string selection;
            do
            {
                Console.Clear();
                Console.WriteLine(string.Format("Enter factory (1 or 2): "));
                selection = Console.ReadLine();
                if (!IsSelectionValid(selection))
                {
                    Console.WriteLine("Invalid input. Press Enter to restart");
                    Console.ReadLine();
                }
            } while (!IsSelectionValid(selection));

            //Abstract factory start
            AbstractFactory pf = FactoryMaker.getFactory(selection);
            AbstractProductA product = pf.CreateProductA();

            product.OperationA1();
            product.OperationA2();
            //Abstract factory end

            Console.WriteLine("Press Enter key to exit");
            Console.ReadLine();
        }

        static bool IsSelectionValid(string selection)
        {
            var validSelections = new List<string>() { "1", "2" };
            foreach (var validSelection in validSelections)
            {
                if (selection.Trim().Equals(validSelection))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
