using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;
                Console.WriteLine("Practice/ex04");
                Console.WriteLine();

                Console.Write("Вкажіть нижню межу діапазону: ");
                int lowerBound = Convert.ToInt32(Console.ReadLine());

                Console.Write("Вкажіть верхню межу діапазону: ");
                int upperBound = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                int a = 0, b = 1;
                int fibonacciNumber = 0;
                Console.Write("Рядок Фібоначчі:");
                while (fibonacciNumber <= upperBound)
                {
                    if (fibonacciNumber >= lowerBound)
                    {
                        Console.Write($"  {fibonacciNumber}");
                    }

                    fibonacciNumber = a + b;
                    a = b;
                    b = fibonacciNumber;
                }
            }
            catch (FormatException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Помилка формату введення! Має бути число, а не текст!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                Console.ReadKey();
                Console.ResetColor();
            }
        }
    }
}