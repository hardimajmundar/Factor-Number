using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class FactorNumber
    {
        static void Main(string[] args)
        {
            int factornumber = 0;
            Console.WriteLine("Enter the Number", +factornumber);
            Console.ReadLine();

            if (factornumber % 3 == 0)
            {
                Console.WriteLine("Pling");
            }
            if (factornumber % 5 == 0)
            {
                Console.WriteLine("Plang");
            }
            if (factornumber % 7 == 0)
            {
                Console.WriteLine("Plong");
            }
            else
            {
                Console.WriteLine("Number" + factornumber);
            }
            Console.ReadKey();
        }
    }
}
