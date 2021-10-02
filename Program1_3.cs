using System;

namespace Task1._3
{
    class Program1_3
    {
        static void Main(string[] args)
        {
            Task3();

            Console.ReadKey();
        }
        static void Task3()
        {
            Console.WriteLine("Введите числа из диапазона [-1000; 1000]");
            string input = Console.ReadLine();
            int number;
            int count = 0;
            int min = 1001;
            int max = -1001;
            long sum = 0;
            double middle = 0;
            do
            {
                if (!int.TryParse(input, out number) || number > 1000 || number < -1000)
                {
                    Console.WriteLine("Вы ввели число не из дипазона. Попробуйте еще раз.");
                    input = Console.ReadLine();
                    continue;
                }
                count++;
                if (number < min)
                {
                    min = number;
                }
                if (number > max)
                {
                    max = number;
                }
                sum += number;
                middle = (double)sum / count;
                input = Console.ReadLine();
            } while (input != "");
            Console.WriteLine("Количество введенных чисел: " + count);
            Console.WriteLine("Минимальное число: " + min);
            Console.WriteLine("Максимальное число: " + max);
            Console.WriteLine("Сумма введенных чисел: " + sum);
            Console.WriteLine("Среднее арифметическое: " + middle);
        }
    }
}
