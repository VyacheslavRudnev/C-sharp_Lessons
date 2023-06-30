using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HW/ex02");
            Console.WriteLine();
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Введіть два числа. Де перше число буде значенням, а друге - выдсоток першого числа. ");
            Console.Write("Введіть перше число: ");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть друге число: ");
            int percent = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int result = value * percent / 100;
            Console.WriteLine("Відсоток числа {0} від числа {1} = {2}", percent, value, result);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}