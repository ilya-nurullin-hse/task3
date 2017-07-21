using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var defaultConsoleColor = Console.ForegroundColor;

                Console.WriteLine("Введите координаты точки в формате float через пробел или q для выхода");
                var input = Console.ReadLine();

                if (input == "")
                    continue;

                if (input == "q")
                    break;

                try
                {
                    var coords = input.Split();
                    var x = float.Parse(coords[0]);
                    var y = float.Parse(coords[1]);

                    var isXMoreThan0 = x >= 0;
                    var isPointInCircle = x * x + y * y <= 1;
                    var isInArea1 = isXMoreThan0 && isPointInCircle;

                    var upperLine = x >= -2 && x <= 0 && 2 * y <= (x + 2);
                    var lowerLine = x >= -2 && x <= 0 && 2 * y >= -(x + 2);
                    var isInArea2 = upperLine && lowerLine;

                    if (isInArea1 || isInArea2)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Точка принадлежит закрашенной области");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Точка не принадлежит закрашеннгой области");
                    }
                    Console.ForegroundColor = defaultConsoleColor;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ожидались числа в формате float или q");
                    Console.ForegroundColor = defaultConsoleColor;
                }

                Console.WriteLine();
            }
        }
    }
}
