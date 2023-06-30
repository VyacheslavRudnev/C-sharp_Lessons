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

            Console.WriteLine("Введіть чотири цифри: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            int num4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int number = num1 * 1000 + num2 * 100 + num3 * 10 + num4;
            Console.WriteLine("Сформование число: " + number);
            
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}