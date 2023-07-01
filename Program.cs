using System;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Practice/Mod02/ex01");
            Console.WriteLine();
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.Write("Вкажіть розмір масиву: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Random rnd = new Random();
            int[] arr = new int[size];
            
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-10, 10);
            }

            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            int evenElem = 0;
            int oddElem = 0;
            int uniqueElem = 0;
            foreach (int i in arr)
            {
                if (i%2==0)
                {
                    evenElem++;
                }
                else
                {
                    oddElem++;
                }
            }
            Console.WriteLine();
            Console.Write("Унікальні елементи масиву: ");
            var items = arr.Distinct();
            foreach (var item in items)
            {
                Console.Write(item + " ");
                uniqueElem++;
            }
            Console.WriteLine();
            Console.WriteLine($"Кількість парних елементів в масиві: {evenElem}");
            Console.WriteLine($"Кількість непарних елементів в масиві: {oddElem}");
            Console.WriteLine($"Кількість унікальних елементів в масиві: {uniqueElem}");

            





            Console.ReadKey();
        }
    }
}