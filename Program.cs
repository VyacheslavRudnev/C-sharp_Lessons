using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
//Завдання 2
//Дано двовимірний масив розміром 5×5, заповне -
//ний випадковими числами з діапазону від –100 до 100.
//Визначити суму елементів масиву, розташованих між
//мінімальним і максимальним елементами.

            Console.WriteLine("HW/Mod02/ex02\n");
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int[,] arr = new int[5, 5];
            Random rnd = new Random();
            int minElem = 100, maxElem = -100, sumRange = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] =rnd.Next(-100, 100);
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < minElem)
                    {
                        minElem = arr[i, j];
                    }
                    if (arr[i, j] > maxElem)
                    {
                        maxElem = arr[i, j];
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Мінімальний елемент масиву: " + minElem);
            Console.WriteLine("Максимальний елемент масиву: " + maxElem);
            bool foundMin = false;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (arr[i, j] == minElem)
                    {
                        foundMin = true;
                    }
                    else if (arr[i, j] == maxElem)
                    {
                        if (foundMin)
                        {
                            foundMin = false;
                            break;
                        }
                    }
                    else if (foundMin)
                    {
                        sumRange += arr[i, j];
                    }
                }
            }

            Console.WriteLine("Сума елементів в диапазоні між Мксимальни та Мінімальним: " + sumRange);


            Console.WriteLine();
            Console.ReadKey();
        }
    }
}