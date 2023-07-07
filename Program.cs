using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
//Завдання 1
//Оголосити одновимірний(5 елементів) масив з назвою
//A i двовимірний масив(3 рядки, 4 стовпці) дробових чисел
//з назвою B.Заповнити одновимірний масив А числами,
//введеними з клавіатури користувачем, а двовимірний
//масив В — випадковими числами за допомогою циклів.
//Вивести на екран значення масивів: масиву А — в один
//рядок, масиву В — у вигляді матриці.Знайти у даних
//масивах загальний максимальний елемент, мінімальний
//елемент, загальну суму усіх елементів, загальний добуток
//усіх елементів, суму парних елементів масиву А, суму
//непарних стовпців масиву В.

            Console.WriteLine("HW/Mod02/ex01\n");
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int[] arrA = new int[5];
            double[,] arrB = new double[3, 4];
            Console.WriteLine("Введіть п'ять значень для масиву arrA, розділені пробілом");
            for (int i = 0; i < arrA.Length; i++)
            {
                Console.Write($"Введіть значення для {i} елементу: ");
                arrA[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n\nПохідний масив arrA: ");
            foreach (int i in arrA)
            {
                Console.Write(i + "\t");
            }

            Console.WriteLine("\n\nПохідний масив arrB: ");
            Random rnd = new Random();
            for (int i = 0; i < arrB.GetLength(0); i++)
            {
                for (int j = 0; j < arrB.GetLength(1); j++)
                {
                    arrB[i, j] = Math.Round(rnd.NextDouble(),3);
                    Console.Write(arrB[i, j] + "\t");
                }
                Console.WriteLine();
            }
            // Загальний максимальний елемент
            double maxElement = double.MinValue;
            foreach (int element in arrA)
            {
                if (element > maxElement)
                {
                    maxElement = element;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (arrB[i, j] > maxElement)
                    {
                        maxElement = arrB[i, j];
                    }
                }
            }
            // Загальний мінімальний елемент
            double minElement = double.MaxValue;
            foreach (int element in arrA)
            {
                if (element < minElement)
                {
                    minElement = element;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (arrB[i, j] < minElement)
                    {
                        minElement = arrB[i, j];
                    }
                }
            }
            // Загальна сума усіх елементів
            double sum = 0;
            foreach (int element in arrA)
            {
                sum += element;
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sum += arrB[i, j];
                }
            }

            // Загальний добуток усіх елементів
            double product = 1;
            foreach (int element in arrA)
            {
                product *= element;
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    product *= arrB[i, j];
                }
            }

            // Сума парних елементів масиву A
            int evenSum = 0;
            foreach (int element in arrA)
            {
                if (element % 2 == 0)
                {
                    evenSum += element;
                }
            }

            // Cума непарних стовпців масиву B
            double oddColumnsSum = 0;
            for (int j = 0; j < 4; j += 2)
            {
                for (int i = 0; i < 3; i++)
                {
                    oddColumnsSum += arrB[i, j];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Загальний максимальний елемент: " + maxElement);
            Console.WriteLine("Загальний мінімальний елемент: " + minElement);
            Console.WriteLine("Загальна сума усіх елементів: " + sum);
            Console.WriteLine("Загальний добуток усіх елементів: " + product);
            Console.WriteLine("Сума парних елементів масиву A: " + evenSum);
            Console.WriteLine("Сума непарних стовпців масиву B: " + oddColumnsSum);

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}