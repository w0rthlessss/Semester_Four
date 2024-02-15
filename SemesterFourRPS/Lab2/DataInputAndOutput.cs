using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    static class DataInputAndOutput
    {
        private static double ReadDouble(string message)
        {
            bool isCorrectInput = false;
            double value = 0;

            while (!isCorrectInput)
            {
                Console.Write(message);
                string? temp = Console.ReadLine();
                if (!double.TryParse(temp, out value))
                    Console.WriteLine("Invalid input! Numbers only allowed!");
                else isCorrectInput = true;
            }

            return value;
        }

        public static int ReadInt(string message)
        {
            bool isCorrectInput = false;
            int value = 0;

            while (!isCorrectInput)
            {
                Console.Write(message);
                string? temp = Console.ReadLine();
                if (!int.TryParse(temp, out value))
                    Console.WriteLine("Invalid input! Integers only allowed!");
                else if (value < 1)
                    Console.WriteLine("Array size must be > 0!");
                else isCorrectInput = true;
            }

            return value;
        }

        private static string ReadPath()
        {
            string? path = "";
            while (string.IsNullOrWhiteSpace(path))
            {
                Console.Write($"Enter filepath{Environment.NewLine}>>");
                path = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(path))
                    Console.WriteLine($"{Environment.NewLine}Path must not be empty!{Environment.NewLine}");
            }

            return path;
        }

        private static double[] SplitString(string input)
        {
            string[] separated = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            
            int numberOfElements = separated.Length;

            double[] values = new double[numberOfElements];

            for(int i = 0; i < numberOfElements; i++)
                if (!double.TryParse(separated[i], out values[i])) return [double.NaN, i + 1];
            
            return values;
        }

        public static void SaveData(double[] values)
        {
            bool isCorrect = false;

            while (!isCorrect)
            {
                string path = ReadPath();
                
                if (File.Exists(path))
                {
                    Console.WriteLine($"{Environment.NewLine}File exists! Do you want to overwrite it?{Environment.NewLine}");
                    Information.AskToOverwriteFile();
                    if(Console.ReadKey(true).Key == ConsoleKey.D2) continue;
                }
                else
                {
                    try
                    {
                        FileStream fs = File.Open(path, FileMode.OpenOrCreate);
                        fs.Close();
                    }
                    catch(IOException)
                    {
                        Console.WriteLine($"{Environment.NewLine}Path contains forbidden values!{Environment.NewLine}");
                        continue;
                    }      
                }

                if(values.Length == 3 && double.IsNaN(values[0]))
                {
                    if (values[1] == -1)
                        File.WriteAllText(path, $"Array does not contain requested element of {values[1]}!");

                    else
                        File.WriteAllText(path, $"Requested element of {values[1]} is located at " +
                            $"position {values[2]} in ascending sorted array");

                    Information.SaveSuccess("Results");
                }
                else
                {
                    string data = "";
                    for(int i = 0; i < values.Length - 1; i++)
                    {
                        data += $"{values[i]} ";
                    }
                    data += $"{values.Last()}";

                    File.WriteAllText(path, data);

                    Information.SaveSuccess("Data");
                }

                isCorrect = true;
            }
        }
        public static void ConsoleInput(out double[] array)
        {
            Console.WriteLine($"<<Console input>>{Environment.NewLine}");

            Console.WriteLine("Enter number of elements in array:");
            int arraySize = ReadInt(">>");
            array = new double[arraySize];

            Console.WriteLine();

            Console.WriteLine($"Enter {arraySize} elements of array:");
            for (int i = 0; i < arraySize; i++)
                array[i] = ReadDouble(">>");

            Console.WriteLine();

            Console.WriteLine($"{Environment.NewLine}Entered array:");
            for (int i = 0;i < arraySize; i++)
                Console.Write($"{array[i]} ");

            Console.WriteLine();

            Information.AskToSave("data");
            if(Console.ReadKey(true).Key == ConsoleKey.D1) SaveData(array);
        }

        public static void RandomInput(out double[] array)
        {
            Console.WriteLine($"<<Random input>>{Environment.NewLine}");

            Console.WriteLine("Enter number of elements in array:");
            int arraySize = ReadInt(">>");
            array = new double[arraySize];

            int randomBorder = 999;
            var random = new Random();

            for(int i = 0; i < arraySize; i++)
                array[i] = random.Next(-randomBorder, randomBorder);

            Console.WriteLine($"{Environment.NewLine}Generated array:");
            for (int i = 0; i < arraySize; i++)
                Console.Write($"{array[i]} ");

            Console.WriteLine();

            Information.AskToSave("data");
            if (Console.ReadKey(true).Key == ConsoleKey.D1) SaveData(array);
            
        }

        public static void FileInput(out double[] array)
        {
            Console.WriteLine($"<<File input>>{Environment.NewLine}");
            Information.FileInputInfo();

            bool isCorrect = false;

            array = new double[1];

            while(!isCorrect)
            {
                string path = ReadPath();

                if (!File.Exists(path))
                {
                    Console.WriteLine($"{Environment.NewLine}There is no such file!{Environment.NewLine}");
                    continue;
                }

                string? input = File.ReadAllText(path);

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine($"File is empty!{Environment.NewLine}");
                    continue;
                }

                array = SplitString(input);
               
                if(array.Length == 2 && double.IsNaN(array[0]))
                {
                    Console.WriteLine($"File contains invalid value at position {array[1]}!{Environment.NewLine}");
                    continue;
                }

                isCorrect = true;
            }

            Console.WriteLine($"{Environment.NewLine}Entered array:");
            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]} ");
            Console.WriteLine($"{ Environment.NewLine}");
        }
    }
}
