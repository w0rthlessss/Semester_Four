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
            if(separated.Length != 8)  return new double[2]; 

            double[] coords = new double[8];

            for(int i = 0; i < 8; i++)
                if (!double.TryParse(separated[i], out coords[i])) return [i + 1];
            
            return coords;
        }

        public static void SaveData(Segment[] segments)
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

                if(segments.Length == 1)
                {
                    if (double.IsNaN(segments[0].start.x)) 
                        File.WriteAllText(path, "Segments do not intersect");   

                    else if (double.IsNaN(segments[0].end.x))
                        File.WriteAllText(path, $"Segments intersect at {{{segments[0].start.x}; " +
                            $"{segments[0].start.y}}}");

                    else 
                        File.WriteAllText(path, $"Segmets intersect within " +
                            $"{{{segments[0].start.x}; {segments[0].start.y}}} : " +
                            $"{{{segments[0].end.x}; {segments[0].end.y}}}");

                    Information.SaveSuccess("Results");
                }
                else
                {
                    string data = $"{segments[0].start.x} {segments[0].start.y} " +
                        $"{segments[0].end.x} {segments[0].end.y} " +
                        $"{segments[1].start.x} {segments[1].start.y} " +
                        $"{segments[1].end.x} {segments[1].end.y}";

                    File.WriteAllText(path, data);

                    Information.SaveSuccess("Data");
                }

                isCorrect = true;
            }
        }
        public static void ConsoleInput(ref Segment first, ref Segment second)
        {
            Console.WriteLine($"<<Console input>>{Environment.NewLine}");

            Console.WriteLine("Enter coordinates of start point of the first segment:");
            double x1 = ReadDouble("x: ");
            double y1 = ReadDouble("y: ");

            Console.WriteLine("Enter coordinates of end point of the first segment:");
            double x2 = ReadDouble("x: ");
            double y2 = ReadDouble("y: ");

            Console.WriteLine("Enter coordinates of start point of the second segment:");
            double x3 = ReadDouble("x: ");
            double y3 = ReadDouble("y: ");

            Console.WriteLine("Enter coordinates of end point of the second segment:");
            double x4 = ReadDouble("x: ");
            double y4 = ReadDouble("y: ");

            Console.WriteLine();

            first = new Segment(x1, y1, x2, y2);
            second = new Segment(x3, y3, x4, y4);

            Console.WriteLine(
                $"Entered segments:{Environment.NewLine}" +
                $"First: {{{first.start.x}; {first.start.y}}} : {{{first.end.x}; {first.end.y}}}{Environment.NewLine}" +
                $"Second: {{{second.start.x}; {second.start.y}}} : {{{second.end.x}; {second.end.y}}}{Environment.NewLine}"
            );

            Information.AskToSave("data");
            if(Console.ReadKey(true).Key == ConsoleKey.D1) SaveData([first, second]);
        }

        public static void RandomInput(ref Segment first, ref Segment second)
        {
            Console.WriteLine($"<<Random input>>{Environment.NewLine}");

            int randomBorder = 999;
            double[] vals = new double[8];
            var random = new Random();

            for(int i = 0; i < 8; i++)
                vals[i] = random.Next(-randomBorder, randomBorder);

            first = new Segment(vals[0], vals[1], vals[2], vals[3]);
            second = new Segment(vals[4], vals[5], vals[6], vals[7]);

            Console.WriteLine(
                $"Entered segments:{Environment.NewLine}" +
                $"First: {{{first.start.x}; {first.start.y}}} : {{{first.end.x}; {first.end.y}}}{Environment.NewLine}" +
                $"Second: {{{second.start.x}; {second.start.y}}} : {{{second.end.x}; {second.end.y}}}{Environment.NewLine}"
            );

            Information.AskToSave("data");
            if (Console.ReadKey(true).Key == ConsoleKey.D1) SaveData([first, second]);
            
        }

        public static void FileInput(ref Segment first, ref Segment second)
        {
            Console.WriteLine($"<<File input>>{Environment.NewLine}");
            Information.FileInputInfo();

            bool isCorrect = false;       

            while(!isCorrect)
            {
                string path = ReadPath();

                if (path.Intersect(Path.GetInvalidFileNameChars()).Any())
                {
                    Console.WriteLine($"{Environment.NewLine}Path contains forbidden values!{Environment.NewLine}");
                    continue;
                }

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

                double[] coords = SplitString(input);
               
                if(coords.Length == 2)
                {
                    Console.WriteLine($"Invalid amount of values in the file!{Environment.NewLine}");
                    continue;
                }

                if(coords.Length == 1)
                {
                    Console.WriteLine($"Invalid value at position {coords[0]}!{Environment.NewLine}");
                    continue;
                }

                first = new Segment(coords[0], coords[1], coords[2], coords[3]);
                second = new Segment(coords[4], coords[5], coords[6], coords[7]);

                isCorrect = true;
            }

            Console.WriteLine(
                $"{Environment.NewLine}Entered segments:{Environment.NewLine}" +
                $"First: {{{first.start.x}; {first.start.y}}} : {{{first.end.x}; {first.end.y}}}{Environment.NewLine}" +
                $"Second: {{{second.start.x}; {second.start.y}}} : {{{second.end.x}; {second.end.y}}}{Environment.NewLine}"
            );

        }
    }
}
