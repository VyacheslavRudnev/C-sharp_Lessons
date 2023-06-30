using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HW/ex01");
            Console.WriteLine();
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            
            try
            {
                Console.Write("Введіть число від 1 до 100: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if(number < 1 || number > 100)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Помилка! Введене число не відповідає вказаному діапазону");
                    return;
                }
                if (number % 3 == 0 && number % 5 != 0)
                {
                   Console.WriteLine("Fizz");
                }
                else if (number % 3 != 0 && number % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                {
                    Console.WriteLine($"Число {number}");
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