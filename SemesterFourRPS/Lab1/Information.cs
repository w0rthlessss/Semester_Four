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
            Console.WriteLine("Lab #1");
            Console.WriteLine("Group #423");
            Console.WriteLine("Efremov Ivan Andreevich");
            Console.WriteLine("Option #5");
            Console.WriteLine($"Define if two segments intersect. Find intersection point.{Environment.NewLine}");
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
            Console.WriteLine($"Do you want to save {message} into file?");
            Console.WriteLine("[1] - Yes");
            Console.WriteLine("[2] - No");
            Console.WriteLine();
        }

        public static void FileInputInfo()
        {
            Console.WriteLine("Data in file must be located in one line. Coordinates must be separated with spaces!");
            Console.WriteLine($"Example:{Environment.NewLine}x1 y1 x2 y2 x3 y3 x4 y4{Environment.NewLine}");
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
