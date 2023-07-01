using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Practice/Mod02/ex03");
            Console.WriteLine();
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Введіть три числа, розділені пробілами:");
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');

            int[] array = { 7, 6, 5, 3, 4, 7, 6, 5, 8, 7, 6, 5 };
            int count = CountSequence(array, numbers);

            Console.WriteLine("Кількість повторень послідовності: " + count);
            Console.WriteLine();
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