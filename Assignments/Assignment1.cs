using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Assignment1
    {
        static void Main()
        {
            Console.WriteLine("=== Integral Types ===");
            Console.WriteLine($"byte     : {byte.MinValue} to {byte.MaxValue}");
            Console.WriteLine($"int      : {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"long     : {long.MinValue} to {long.MaxValue}");
            Console.WriteLine($"char     : {(int)char.MinValue} to {(int)char.MaxValue} (Unicode)");

            Console.WriteLine("\n=== Floating Point Types ===");
            Console.WriteLine($"float    : {float.MinValue} to {float.MaxValue}");
            Console.WriteLine($"double   : {double.MinValue} to {double.MaxValue}");
            Console.WriteLine($"decimal  : {decimal.MinValue} to {decimal.MaxValue}");
        }
    }
}