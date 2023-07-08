using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
//Завдання 8
//Користувач вводить з клавіатури речення.Додаток має
//підрахувати кількість голосних літер у реченні.
            Console.WriteLine("Practice/Mod02/ex08\n");
            Console.WriteLine();
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Введіть речення українською мовою: ");
            string str = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'а' || str[i] == 'е' || str[i] == 'и' || str[i] == 'і' || str[i] == 'о' || str[i] == 'у' || str[i] == 'ю' || str[i] == 'я' || str[i] == 'є' || str[i] == 'ї')
                {
                    count++;
                }
            }
            Console.WriteLine("\nКількість голосних літер у реченні: " + count);

            Console.ReadKey();
        }
    }
}