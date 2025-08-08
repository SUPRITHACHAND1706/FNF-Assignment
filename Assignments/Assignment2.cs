using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Assignment2
    {
        static void Main()

        {
            
            Console.WriteLine("Enter the number of elements: ");
            int size = int.Parse(Console.ReadLine());
            int[] numbers = new int[size];
            Console.WriteLine("Enter the numbers:");
            for (int i = 0; i < size; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            OddAndEven(numbers);

        }

        static void OddAndEven(int[] arr)

        {

            Console.WriteLine("Even Numbers:");

            foreach (int num in arr)

            {
                if (num % 2 == 0)
                    Console.Write(num + " ");
            }

            Console.WriteLine("\nOdd Numbers:");
            foreach (int num in arr)
            {
                if (num % 2 != 0)
                    Console.Write(num + " ");
            }

        }

    }
}


