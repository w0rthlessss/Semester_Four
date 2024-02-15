using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1;

static class ConsoleInputProcessing
{
    /*
     * Считывание значения с консоли и проверка на 
     * конвертируемость его в целое положительное число
     */
    public static double ReadDouble(string message)
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
}
