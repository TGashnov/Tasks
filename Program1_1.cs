using System;

namespace Task1._1
{
    class Program1_1
    {
        static void Main(string[] args)
        {
            Check(out int number);
            Console.WriteLine(Math.Pow(number, 2));

            Console.ReadKey();
        }

        static void Check(out int number)
        {
            Console.WriteLine("Введите число от -1000000 до 1000000");
            number = int.Parse(Console.ReadLine());
            while (number < -1000000 || number > 1000000)
            {
                Console.WriteLine("Вы ввели неправильное число");
                number = int.Parse(Console.ReadLine());
            }
        }
    }
}
