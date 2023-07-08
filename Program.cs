using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
//Завдання 6
//Користувач вводить речення з клавіатури.Вам необ-
//хідно підрахувати кількість слів у ньому.
            Console.WriteLine("Practice/Mod02/ex06\n");
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Введіть речення: ");
            string str = Console.ReadLine();
            string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("\nКількість слів у реченні: " + words.Length);

            Console.ReadKey();
        }
    }
}