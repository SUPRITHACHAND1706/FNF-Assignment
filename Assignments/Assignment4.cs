using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Assignment4
    {
        static void Main()
        {
            Console.WriteLine("Enter the size of the array:");
            int size = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the datatype:");
            string dataType = Console.ReadLine().ToLower();

            Console.WriteLine($"Enter {size} values of type {dataType}:");

            switch (dataType)
            {
                case "int":
                    int[] intArray = new int[size];
                    for (int i = 0; i < size; i++)
                    {
                        Console.WriteLine($"Element{i+1}:");
                        intArray[i] = int.Parse(Console.ReadLine());

                    }
                    Console.WriteLine("\nArray contents:");
                    foreach(int val in intArray)
                        Console.WriteLine(val +  " ");
                    break;
                case "double":
                    double[] doubleArray = new double[size];
                    for (int i = 0; i < size; i++)
                    {
                        Console.WriteLine($"Element{i + 1}:");
                        doubleArray[i] = double.Parse(Console.ReadLine());

                    }
                    Console.WriteLine("\nArray contents:");
                    foreach (int val in doubleArray)
                        Console.WriteLine(val + " ");
                    break;
                case "string":
                    string[] stringArray = new string[size];
                    for (int i = 0; i < size; i++)
                    {
                        Console.WriteLine($"Element{i + 1}:");
                        stringArray[i] = Console.ReadLine();

                    }
                    Console.WriteLine("\nArray contents:");
                    foreach (string val in stringArray)
                        Console.WriteLine(val + " ");
                    break;
                case "float":
                    float[] floatArray = new float[size];
                    for (int i = 0; i < size; i++)
                    {
                        Console.WriteLine($"Element{i + 1}:");
                        floatArray[i] = float.Parse(Console.ReadLine());

                    }
                    Console.WriteLine("\nArray contents:");
                    foreach (float val in floatArray)
                        Console.WriteLine(val + " ");
                    break;
                default:
                    Console.WriteLine("Unsupported datatype.");
                    break;

            }

        }

    }
}
