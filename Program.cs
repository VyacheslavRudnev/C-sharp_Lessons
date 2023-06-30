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
                Console.WriteLine("Practice/ex02");
                Console.WriteLine();

                Console.Write("Введіть шестизначне число: ");
                int number = int.Parse(Console.ReadLine());
                if (number < 100000 || number > 999999)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Введене число не є шестизначним");
                    return;
                }
                
                string numberString = number.ToString();
                char[] charArray = numberString.ToCharArray();
                Array.Reverse(charArray);

                string reversedNumberString = new string(charArray);
                int reversedNumber = int.Parse(reversedNumberString);
                Console.WriteLine();
                Console.WriteLine($"Ваше перевернуте число :{reversedNumber}");
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