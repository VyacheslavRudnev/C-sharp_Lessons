using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
//Завдання 5
//Користувач з клавіатури вводить до рядка арифме -
//тичний вираз.Додаток має підрахувати його результат.
//Необхідно дотримуватися лише двох операцій: +і –.
            Console.WriteLine("HW/Mod02/ex05\n");
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Введіть арифметичний вираз: ");
            string expression = Console.ReadLine();
            int result = 0;
            int i = 0;
            while (i < expression.Length)
            {
                if (expression[i] == '+')
                {
                    result += int.Parse(expression[i + 1].ToString());
                    i += 2;
                }
                else if (expression[i] == '-')
                {
                    result -= int.Parse(expression[i + 1].ToString());
                    i += 2;
                }
                else
                {
                    result += int.Parse(expression[i].ToString());
                    i++;
                }
            }
            Console.WriteLine("Результат: " + result);

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}