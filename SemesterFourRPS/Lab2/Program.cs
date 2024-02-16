using Lab1;
using System.Collections.Generic;

namespace Lab2
{
    internal class Program
    {
        static void Main()
        {
            Information.Greeting();
            Information.Options();

            double[] array = new double[1];

            while (true)
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D1:
                        DataInputAndOutput.ConsoleInput(out array);
                        break;
                    case ConsoleKey.D2:
                        DataInputAndOutput.FileInput(out array);
                        break;
                    case ConsoleKey.D3:
                        DataInputAndOutput.RandomInput(out array);
                        break;
                    case ConsoleKey.D4:
                        Console.WriteLine($"{Environment.NewLine}Programm finished it's work!");
                        Environment.Exit(0);
                        break;
                    default:
                        continue;
                }

                ArrayManipulation.InsertionSort(ref array);
                Console.WriteLine("Ascending sorted array:");
                for(int i = 0; i < array.Length; i++)               
                    Console.Write($"{array[i]} ");
                Console.WriteLine();

                double[] expected = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];
                bool a = double.Equals(expected, array);

                Console.WriteLine($"{Environment.NewLine}Enter element which position must be found:");
                double requestedElement = DataInputAndOutput.ReadInt(">>");
                Console.WriteLine();

                int requestedPosition = ArrayManipulation.BinarySearch(array, requestedElement);

                if (requestedPosition == -1)
                    Console.WriteLine($"Array does not contain requested element of {requestedElement} :(");
                else
                    Console.WriteLine($"Requested element of {requestedElement} is located at " +
                            $"position {requestedPosition} in ascending sorted array");

                Information.AskToSave("results");
                if (Console.ReadKey(true).Key == ConsoleKey.D1)
                    DataInputAndOutput.SaveData([double.NaN, requestedElement, requestedPosition]);

                Information.Options();
            }

        }
    }
}
