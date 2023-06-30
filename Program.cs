using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HW/ex04");
            Console.WriteLine();
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            try
            {
                Console.Write("Введіть шестизначне число: ");
                int number = int.Parse(Console.ReadLine());
                if (number < 100000 || number > 999999)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Введене число не є шестизначним");
                    return;
                }
                Console.WriteLine("Введіть номер першої цифри яку хочете замінити ");
                int index1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введіть номер другої цифри яку хочете замінити ");
                int index2 = int.Parse(Console.ReadLine());

                if (index1 < 1 || index1 > 6 || index2 < 1 || index2 > 6)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Помилка! Введені номери повинні бути в диапазоні від 1 до 6.");
                }
                else
                {
                    int[] digits = new int[6];

                    for (int i = 5; i >= 0; i--)
                    {
                        digits[i] = number % 10;
                        number /= 10;
                    }

                    int temp = digits[index1 - 1];
                    digits[index1 - 1] = digits[index2 - 1];
                    digits[index2 - 1] = temp;

                    int result = digits[0] * 100000 + digits[1] * 10000 + digits[2] * 1000 +
                                 digits[3] * 100 + digits[4] * 10 + digits[5];

                    Console.WriteLine("Результат заміни: " + result);
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