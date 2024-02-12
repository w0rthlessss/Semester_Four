using Microsoft.VisualBasic;

namespace Lab1
{
    internal class Program
    {
        static void Main()
        {
            Segment first = new();
            Segment second = new();
            Information.Greeting();
            Information.Options();
            while (true)
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D1:
                        DataInputAndOutput.ConsoleInput(ref first, ref second);
                        break;
                    case ConsoleKey.D2:
                        DataInputAndOutput.FileInput(ref first, ref second);
                        break;
                    case ConsoleKey.D3:
                        DataInputAndOutput.RandomInput(ref first, ref second);
                        break;
                    case ConsoleKey.D4:
                        Console.WriteLine($"{Environment.NewLine}Programm finished it's work!");
                        Environment.Exit(0);
                        break;
                    default:
                        continue;
                }

                Segment res = SegmentIntersection.Intersection(first, second);

                if (double.IsNaN(res.start.x))
                    Console.WriteLine($"Segments do not intersect :( {Environment.NewLine}");

                else if (double.IsNaN(res.end.x))
                    Console.WriteLine($"Segments intersect at {{{res.start.x}; " +
                        $"{res.start.y}}}{Environment.NewLine}");

                else
                    Console.WriteLine($"Segments intersect within " +
                        $"{{{res.start.x}; {res.start.y}}} : " +
                        $"{{{res.end.x}; {res.end.y}}}{Environment.NewLine}");

                Information.AskToSave("results");
                if (Console.ReadKey(true).Key == ConsoleKey.D1) DataInputAndOutput.SaveData([res]);

                Information.Options();
            }
        }
    }
}
