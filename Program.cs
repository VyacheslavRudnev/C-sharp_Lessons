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

            Console.Write("Вкажіть розмір масиву: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.Write("Вкажіть три цифри в диапазоні (-10, 20): ");
            int key1 = Convert.ToInt32(Console.ReadLine());
            int key2 = Convert.ToInt32(Console.ReadLine());
            int key3 = Convert.ToInt32(Console.ReadLine());
                     
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
            int count1 = 0,
                count2 = 0,
                count3 = 0;
            
            foreach (var i in arr)
            {
                if (i == key1)
                {
                    count1++;
                }
                else if (i == key2)
                {
                    count2++;
                }
                else if (i == key3)
                {
                    count3++;
                }
            }
            int count = 0;
            if (count1 < count2 && count1 < count3)
            {
                count = count1;
            }
            else if (count2 < count1 && count2 < count3)
            {
                count = count2;
            }
            else if (count3 < count1 && count3 < count2)
            {
                count = count3;
            }
            Console.WriteLine();
            Console.WriteLine($"Кількість повторень послідовностей для {key1}: {count1}");
            Console.WriteLine($"Кількість повторень послідовностей для {key2}: {count2}");
            Console.WriteLine($"Кількість повторень послідовностей для {key3}: {count3}");
            Console.WriteLine($"Кількість повторень послідовностей для всіх чисел: {count}");
           


            Console.WriteLine();
            Console.ReadKey();
        }
    }
}