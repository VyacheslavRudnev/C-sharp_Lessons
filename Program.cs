using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
//Завдання 4
//Створіть додаток, який здійснює операції над матри-
//цями:
//- Множення матриці на число;
//- Додавання матриць;
//- Добуток матриць.
            Console.WriteLine("HW/Mod02/ex04\n");
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            int[,] matrix1 = new int[3, 3];
            Random rnd = new Random();
            Console.WriteLine("Matrix 1: ");
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    matrix1[i, j] = rnd.Next(1, 10);
                    Console.Write(matrix1[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int[,] matrix2 = new int[3, 3];
            Console.WriteLine("Matrix 2: ");
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    matrix2[i, j] = rnd.Next(1, 10);
                    Console.Write(matrix2[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Множення матриці на число");
            Console.Write("Введіть число для множення: ");
            int Number = Convert.ToInt32(Console.ReadLine());
            int[,] result = MultiplyByNumber(matrix1, Number);
            Console.WriteLine($"\nРезультат множення першої матриці на {Number}: ");
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write(result[i, j] + " ");
                }
                Console.WriteLine();
            }

            int[,] result2 = MultiplyByNumber(matrix2, Number);
            Console.WriteLine($"\nРезультат множення другої матриці на {Number}: ");
            for (int i = 0; i < result2.GetLength(0); i++)
            {
                for (int j = 0; j < result2.GetLength(1); j++)
                {
                    Console.Write(result2[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nДодавання матриць");
            int[,] result3 = AddMatrices(matrix1, matrix2);
            for (int i = 0; i < result3.GetLength(0); i++)
            {
                for (int j = 0; j < result3.GetLength(1); j++)
                {
                    Console.Write(result3[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nМноження матриць");
            int[,] result4 = MultiplyMatrices(matrix1, matrix2);
            for (int i = 0; i < result4.GetLength(0); i++)
            {
                for (int j = 0; j < result4.GetLength(1); j++)
                {
                    Console.Write(result4[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
        static int[,] MultiplyByNumber(int[,] matrix, int scalar)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix[i, j] * scalar;
                }
            }

            return result;
        }
        static int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
        {
            int rows = matrix1.GetLength(0);
            int cols = matrix1.GetLength(1);
            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return result;
        }
        static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
        {
            int rows = matrix1.GetLength(0);
            int cols = matrix1.GetLength(1);
            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix1[i, j] * matrix2[i, j];
                }
            }
            return result;
        }
    }
}