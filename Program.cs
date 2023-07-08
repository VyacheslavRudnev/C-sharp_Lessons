using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
//Завдання 7
//Створіть додаток, який перевіряє текст на неприпу-
//стимі слова.Якщо неприпустиме слово знайдено, воно
//має бути замінено набором символів *.За підсумками
//роботи програми, необхідно показати статистику дій.

            Console.WriteLine("HW/Mod02/ex07\n");
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Введіть базовий текст для перевірки: ");
            string? text = Console.ReadLine();
            Console.WriteLine("\nВведіть неприпустиме слово: ");
            string? word = Console.ReadLine();
            char ch = '*';
           
            int count = 0;
            int indexOfWord = text.IndexOf(word);
            while (indexOfWord != -1)
            {
                count++;
                indexOfWord = text.IndexOf(word, indexOfWord + 1);
            }
            string replacedText = text.Replace(word, new string(ch, word.Length));
            Console.WriteLine($"\nЗаміна неприпустимого слова на символ {ch}:\n {replacedText}");
            Console.WriteLine($"\nКількість проведених замін неприпустимого слова {word} = {count}");

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}