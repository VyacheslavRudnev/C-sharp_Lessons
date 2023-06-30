using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HW/ex06");
            Console.WriteLine();
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            
            Console.WriteLine("Виберіть опцію конвертації: ");
            Console.WriteLine("1. Фаренгейт в Цельсій");
            Console.WriteLine("2. Цельсій в Фаренгейт");

            int choice = int.Parse(Console.ReadLine());

            double temp;
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Введіть температуру в Фаренгейтах: ");
                    temp = double.Parse(Console.ReadLine());
                    double celsius = (temp - 32) * 5 / 9;
                    Console.WriteLine($"Температура в Цельсіях: {celsius}°C");
                    break;
                case 2:
                    Console.WriteLine("Введіть температуру в Цельсіях:");
                    temp = double.Parse(Console.ReadLine());
                    double fahrenheit = temp * 9 / 5 + 32;
                    Console.WriteLine($"Температура в Фаренгейтах: {fahrenheit}°F");
                    break;
                default:
                    Console.WriteLine("Некоректний вибір.");
                    break;
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}