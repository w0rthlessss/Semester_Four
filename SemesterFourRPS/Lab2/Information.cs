using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    static class Information
    {
        public static void Greeting()
        {
            Console.WriteLine("Lab #2");
            Console.WriteLine("Group #423");
            Console.WriteLine("Efremov Ivan Andreevich");
            Console.WriteLine("Option #5");
            Console.WriteLine($"Implement binary search of the element in array.{Environment.NewLine}");
        }

        public static void Options()
        {
            Console.WriteLine($"[1] - Console input");
            Console.WriteLine($"[2] - File input");
            Console.WriteLine($"[3] - Random input");
            Console.WriteLine($"[4] - Quit application");
            Console.WriteLine();
        }

        public static void AskToSave(string message)
        {
            Console.WriteLine($"{Environment.NewLine}Do you want to save {message} into file?");
            Console.WriteLine("[1] - Yes");
            Console.WriteLine("[2] - No");
            Console.WriteLine();
        }

        public static void FileInputInfo()
        {
            Console.WriteLine("Data in file must be located in one line. Elements must be separated with spaces!");
            Console.WriteLine($"Example:{Environment.NewLine}a1 a2 a3 ... an{Environment.NewLine}");
        }

        public static void AskToOverwriteFile()
        {
            Console.WriteLine("[1] - Yes");
            Console.WriteLine("[2] - No");
            Console.WriteLine();
        }

        public static void SaveSuccess(string message)
        {
            Console.WriteLine();
            Console.WriteLine($"{message} was successfully saved!");
            Console.WriteLine();
        }
    }
}
