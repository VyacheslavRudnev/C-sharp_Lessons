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
                Console.WriteLine("Practice/ex05");
                Console.WriteLine();

                Console.Write("Вкажіть перше число: A = ");
                int A = Convert.ToInt32(Console.ReadLine());

                Console.Write("Вкажіть друге число: B = (має бути більшим за А)");
                int B = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (A < B)
                {
                    for (int i = A; i <= B; i++)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            Console.Write(i +" ");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Число B має бути більшим за A.");
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