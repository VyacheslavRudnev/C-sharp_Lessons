using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
//Завдання 5
//Розробіть додаток, який знаходитиме мінімальне і
//максимальне значення у двовимірному масиві.   
            Console.WriteLine("Practice/Mod02/ex05\n");
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Вкажіть параметри двомірного масиву, розділені пробілом: ");
            string[] input = Console.ReadLine().Split(' ');
            int[,] arr = new int[Convert.ToInt32(input[0]), Convert.ToInt32(input[1])];
            Random rnd = new Random();
            Console.WriteLine("Двомірний масив: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write("\t");
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(0, 100);
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int minValue = 0, maxValue = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (i == 0)
                {
                    minValue = arr[i, 0];
                    maxValue = arr[i, 0];
                }
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < minValue)
                    {
                        minValue = arr[i, j];
                    }
                    if (arr[i, j] > maxValue)
                    {
                        maxValue = arr[i, j];
                    }
                }
            }
            Console.WriteLine($"\nМінімальне значення: {minValue}");
            Console.WriteLine($"\nМаксимальне значення: {maxValue}");
            




            Console.WriteLine();
            Console.ReadKey();
        }
    }
}