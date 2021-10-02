using System;

namespace Task2._1
{
    class Program2_1
    {
        static void Main(string[] args)
        {
            Task4();

            Console.ReadKey();
        }
        static void Task4()
        {
            Console.WriteLine("Введите стоимость товара");
            Check(out double input);
            double remainder = (input / 1.2) - Math.Floor(input / 1.2);
            if (remainder >= 0.5)
            {
                remainder = Math.Ceiling(input - input / 1.2);
            }
            else
            {
                remainder = Math.Floor(input - input / 1.2);
            }
            Console.WriteLine("Стоимость товара без НДС: " + (input / 1.2));
            Console.WriteLine("Сумма НДС в чеке: " + Math.Round(input - input / 1.2, 2));
            Console.WriteLine("Сумма НДС для налоговой декларации: " + remainder);
        }

        static void Check(out double input)
        {
            while (!double.TryParse(Console.ReadLine(), out input) || input < 0)
            {
                Console.WriteLine("Введите число больше 0!");
            }
        }
    }
}