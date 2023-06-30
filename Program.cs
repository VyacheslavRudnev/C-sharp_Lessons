using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Practice/ex02");
            Console.WriteLine();
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.Write("Введіть перше число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть друге число: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть третє число: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть четверте число: ");
            int num4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть п'яте число: ");
            int num5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"Ваші числа: {num1}, {num2}, {num3}, {num4}, {num5}");
            Console.WriteLine();
            Console.WriteLine($"Сума ваших чисел: {num1 + num2 + num3 + num4 + num5}");
            Console.WriteLine($"Добуток ваших чисел: {num1 * num2 * num3 * num4 * num5}");
            Console.WriteLine($"Середнє арифметичне ваших чисел: {(num1 + num2 + num3 + num4 + num5) / 5}");
            Console.WriteLine($"Максимальне число: {Math.Max(num1, Math.Max(num2, Math.Max(num3, Math.Max(num4, num5))))}");
            Console.WriteLine($"Мінімальне число: {Math.Min(num1, Math.Min(num2, Math.Min(num3, Math.Min(num4, num5))))}");
            Console.WriteLine();

        }
    }
}