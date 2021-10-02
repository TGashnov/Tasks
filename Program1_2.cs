using System;

namespace Task1._2
{
    class Program1_2
    {
        static void Main(string[] args)
        {
            Solve();

            Console.ReadKey();
        }

        static void Solve()
        {
            Console.WriteLine("Введите что-нибудь");
            string input = Console.ReadLine();
            if (int.TryParse(input, out _))
            {
                Console.WriteLine("Вы ввели целое число");
            }
            else if (double.TryParse(input, out _))
            {
                Console.WriteLine("Вы ввели рациональное число");
            }
            else if (bool.TryParse(input, out _))
            {
                Console.WriteLine("Вы ввели логическое значение");
            }
            else
            {
                Console.WriteLine("Вы ввели текст");
            }
        }
    }
}
