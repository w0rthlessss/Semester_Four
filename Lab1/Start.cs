using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Start
    {
        public Start() {
            Information info = new();
            Segment first = new Segment();
            Segment second = new Segment();
            info.Greeting();
            info.Options();
            while (true) {                
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D1:
                        DataInput.ConsoleInput(out first, out second);
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("Correct!");
                        break;
                    case ConsoleKey.D3:
                        DataInput.RandomInput(out first, out second);
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

                info.Options();
            }
        }
    }
}
