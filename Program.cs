using System.Diagnostics;
using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Practice/ex06");
            Console.WriteLine();
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.Write("Вкажіть довжину лінії: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Вкажіть символ: ");
            char symbol = Convert.ToChar(Console.ReadLine());
            Console.Write("Оберіть напрямок: 1 - горизонтально, 2 - Вертикально ");
            int direction = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (direction)
            {
                case 1:
                    for (int i = 0; i < length; i++)
                    {
                        Console.Write($" { symbol}");
                    }
                    break;
                case 2:
                    for (int i = 0; i < length; i++)
                    {
                        Console.WriteLine(symbol);
                    }
                    break;
                default:
                    Console.WriteLine("Невірно вказаний напрямок");
                    break;
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}