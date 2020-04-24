using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyTesting
{
    class Test
    {
        static void Main(string[] agrs)
        {
            Console.WriteLine("Hello");

            BasicOperations basicOperations = new BasicOperations();
            Console.WriteLine("4 + 5 is {0}.",basicOperations.Add(4,5));
            Console.WriteLine("5 * 4 is {0}.", basicOperations.Mul(5, 4));
            Console.WriteLine("15 / 5 is {0}.", basicOperations.Div(15, 5));
            Console.WriteLine("7 - 6 is {0}.", basicOperations.Sub(7, 6));

            ClassicPrograms classicProgram = new ClassicPrograms();
            Console.WriteLine("Is 4 Prime? {0}", classicProgram.IsPrime(9));
            Console.WriteLine("Is 5 odd {0}", classicProgram.IsOdd(5));
            Console.WriteLine("Is 3 Even? {0}", classicProgram.IsEven(3));

            Console.ReadKey();

        }
    }
}
