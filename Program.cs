using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
//Завдання 3
//Користувач вводить з клавіатури три числа. Необхідно
//підрахувати кількість разів послідовності цих трьох чисел
//в масиві.
//Наприклад:
//користувач ввів: 7 6 5;
//масив: 7 6 5 3 4 7 6 5 8 7 6 5;
//кількість повторень послідовності: 3.

            Console.WriteLine("Practice/Mod02/ex03\n");
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.Write("Введіть три числа, розділені пробілами: ");
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');

            int[] array = { 7, 6, 5, 3, 4, 7, 6, 5, 8, 7, 6, 5 };
            int count = CountSequence(array, numbers);

            Console.WriteLine("\nКількість повторень послідовності: " + count);
            Console.ReadKey();
        }
        static int CountSequence(int[] array, string[] sequence)
        {
            int count = 0;
            int index = 0;

            while (index < array.Length - sequence.Length + 1)
            {
                bool found = true;

                for (int i = 0; i < sequence.Length; i++)
                {
                    int number = int.Parse(sequence[i]);

                    if (array[index + i] != number)
                    {
                        found = false;
                        break;
                    }
                }

                if (found)
                {
                    count++;
                    index += sequence.Length;
                }
                else
                {
                    index++;
                }
            }

            return count;
        }
    }
}