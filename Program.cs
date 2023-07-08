using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
//Завдання 7
//Користувач вводить речення з клавіатури.Вам необхід-
//но перевернути кожне слово речення і вивести результат
//на екрані.
            Console.WriteLine("Practice/Mod02/ex07\n");
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Введіть речення: ");
            string str = Console.ReadLine();
            string[] words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                char[] word = words[i].ToCharArray();
                Array.Reverse(word);
                words[i] = new string(word);
            }
            str = string.Join(" ", words);
            Console.WriteLine(str);

            Console.ReadKey();
        }
    }
}