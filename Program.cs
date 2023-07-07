using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
//Завдання 6
//Користувач з клавіатури вводить певний текст. Додаток
//має змінювати регістр першої літери кожного речення на
//літеру у верхньому регістрі.
            Console.WriteLine("HW/Mod02/ex06");
            Console.WriteLine();
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Введіть текст:");
            string ? text = Console.ReadLine();
            string[] sentences = text.Split('.', '!','?');
            for(int i = 0; i < sentences.Length; i++)
            {
                if (!string.IsNullOrEmpty(sentences[i]))
                {
                    string sentence = sentences[i].Trim();
                    if (sentence.Length > 0)
                    {
                        char firstChar = char.ToUpper(sentence[0]);
                        sentences[i] = firstChar + sentence.Substring(1);
                    }
                }
            }
            text = string.Join(". ", sentences);
            Console.WriteLine(text);

            Console.ReadKey();
        }
    }
}