using System;

namespace Task2._3
{
    class Program2_3
    {
        static void Main(string[] args)
        {
            Solve();

            Console.ReadKey();
        }
        private static void Solve()
        {
            Input(out int inputMinutes);
            if (inputMinutes <= 0)
            {
                Console.WriteLine("Событие уже началось!");
                return;
            }
            else
            {
                Console.WriteLine(ToString(GetMinutes(inputMinutes),
                                           GetHour(inputMinutes, GetDay(inputMinutes)),
                                           GetDay(inputMinutes),
                                           EndingOfTheMinutes(GetMinutes(inputMinutes)),
                                           EndingOfTheHours(GetHour(inputMinutes, GetDay(inputMinutes))),
                                           EndingOfTheDays(GetDay(inputMinutes))));
            }

        }

        private static void Input(out int inputMinutes)
        {
            Console.WriteLine("Введите сколько осталось минут до события");
            while (!int.TryParse(Console.ReadLine(), out inputMinutes))
            {
                Console.Error.WriteLine("Введите целое число минут");
            }
        }

        private static int GetDay(int minutes)
        {
            return minutes / 60 / 24;
        }

        private static int GetHour(int minutes, int day)
        {
            return minutes / 60 - 24 * day;
        }

        private static int GetMinutes(int minutes)
        {
            int hours = minutes / 60;
            return minutes - hours * 60;
        }

        private static string EndingOfTheMinutes(int minutes)
        {
            string endMin = "";
            int min = minutes % 10;
            if (min == 1 && minutes != 11)
            {
                endMin = "минуту";
            }
            else if (min >= 2 && min <= 4 && minutes != 12 && minutes != 13 && minutes != 14)
            {
                endMin = "минуты";
            }
            else
            {
                endMin = "минут";
            }
            return endMin;
        }

        private static string EndingOfTheHours(int hour)
        {
            string endHour = "";
            int h = hour % 10;
            if (h == 1 && hour != 11)
            {
                endHour = "час";
            }
            else if (h >= 2 && h <= 4 && hour != 12 && hour != 13 && hour != 14)
            {
                endHour = "часа";
            }
            else
            {
                endHour = "часов";
            }
            return endHour;
        }

        private static string EndingOfTheDays(int day)
        {
            string endDay = "";
            int d = day % 10;
            if (d == 1 && day != 11)
            {
                endDay = "день";
            }
            else if (d >= 2 && d <= 4 && day != 12 && day != 13 && day != 14)
            {
                endDay = "дня";
            }
            else
            {
                endDay = "дней";
            }
            return endDay;
        }

        private static string ToString(int minutes, int hour, int day, string endMinutes, string endHour, string endDay)
        {
            return $"Событие наступит через {day} {endDay} {hour} {endHour} и {minutes} {endMinutes}!";
        }
    }
}
