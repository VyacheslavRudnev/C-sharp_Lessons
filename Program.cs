using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Practice/Mod02/ex02");
            Console.WriteLine();
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.Write("Вкажіть розмір масиву: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.Write("Вкажіть параметр для пошуку: ");
            int key = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Random rnd = new Random();
            int[] arr = new int[size];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-10, 20);
            }
            Console.WriteLine("Похідний масив: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Елементи масиву меньше ({key}):"); 
            int countElem = 0;
            foreach (var i in arr)
            {
                if(i<key)
                {
                    Console.Write(i + " ");
                    countElem++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Кількість елементів масиву < {key}: {countElem}");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}