using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HW/ex07");
            Console.WriteLine();
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Введіть перше число:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введіть друге число:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int start = Math.Min(number1, number2);
            int end = Math.Max(number1, number2);

            if (start % 2 != 0)
                start++;

            Console.WriteLine("Парні числа у вказаному діапазоні: ");
            for (int i = start; i <= end; i += 2)
            {
                Console.Write($" {i}");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}