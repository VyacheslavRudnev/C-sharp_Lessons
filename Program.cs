using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
//Завдання 9
//Створіть додаток для підрахунку кількості входжень
//підрядка в рядок.Користувач вводить вихідний рядок і
//слово для пошуку. Додаток відображає результат пошуку.
//Наприклад:
//користувач ввів: Why she had to go.I don't know, she
//wouldn't say;
//підрядок для пошуку: she;
//результат пошуку: 2.

            Console.WriteLine("Practice/Mod02/ex09\n");
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Введіть речення: ");
            string? text = Console.ReadLine();
            Console.WriteLine("\nВведіть слово для пошуку: ");
            string? word = Console.ReadLine();
            
            int count = 0;
            int indexOfWord = text.IndexOf(word);
            while (indexOfWord != -1)
            {
                count++;
                indexOfWord = text.IndexOf(word, indexOfWord + 1);
            }
            if (count > 0)
            {
                Console.WriteLine($"\nКількість входжень слова {word} в речення: {count}");
            }
            else
            {
                Console.WriteLine($"\nСлово {word} не знайдено в реченні");
            }
            Console.ReadKey();
        }
    }
}