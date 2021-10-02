using System;

namespace Task2._2
{
    class Program2_2
    {
        static void Main(string[] args)
        {
            InputWall(out double length, out double width, out double height);
            double wallSquare = GetWallSquare(length, width, height);
            double holeSquare = GetHoleSquare();
            double answer = Wall(wallSquare, holeSquare);
            Console.WriteLine("Общая площадь стен = " + answer);

            Console.ReadKey();
        }

        private static void InputWall(out double length, out double width, out double height)
        {
            Console.WriteLine("Введите длину помещения в метрах");
            length = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите ширину помещения в метрах");
            width = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите высоту помещения в метрах");
            height = double.Parse(Console.ReadLine());
        }

        private static double GetWallSquare(double length, double width, double height)
        {
            return 2 * (length + width) * height;
        }

        private static double GetHoleSquare()
        {
            Console.WriteLine("Введите количество дверей");
            uint doors = uint.Parse(Console.ReadLine());
            double doorLength = 0;
            double doorWidth = 0;
            double hole = 0;
            for (int i = 0; i < doors; i++)
            {
                Console.WriteLine("Введите длину двери");
                doorLength = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите ширину двери");
                doorWidth = double.Parse(Console.ReadLine());
                hole += doorLength * doorWidth;
            }
            Console.WriteLine("Введите количество окон");
            uint windows = uint.Parse(Console.ReadLine());
            double windowLength = 0;
            double windowWidth = 0;
            for (int i = 0; i < windows; i++)
            {
                Console.WriteLine("Введите длину окна");
                windowLength = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите ширину окна");
                windowWidth = double.Parse(Console.ReadLine());
                hole += windowLength * windowWidth;
            }
            return hole;
        }

        private static double Wall(double wallSquare, double holeSquare)
        {
            return wallSquare - holeSquare;
        }
    }
}