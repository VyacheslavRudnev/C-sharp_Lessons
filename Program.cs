using System.Globalization;
using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HW/ex05");
            Console.WriteLine();
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Введіть дату у форматі дд.мм.рррр:");
            string input = Console.ReadLine();

            DateTime date;
            if (DateTime.TryParseExact(input, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                string season = GetSeason(date.Month);
                string dayOfWeek = date.DayOfWeek.ToString();

                Console.WriteLine($"{season} {dayOfWeek}");
            }
            else
            {
                Console.WriteLine("Некоректний формат дати.");
            }

            string GetSeason(int month)
            {
                switch (month)
                {
                    case 12:
                    case 1:
                    case 2:
                        return "Winter";
                    case 3:
                    case 4:
                    case 5:
                        return "Spring";
                    case 6:
                    case 7:
                    case 8:
                        return "Summer";
                    case 9:
                    case 10:
                    case 11:
                        return "Autumn";
                    default:
                        return "";
                }
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}