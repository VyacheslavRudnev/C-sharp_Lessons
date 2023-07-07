using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
//Завдання 4
//Дано 2 масиви розмірності M і N відповідно.
//Необхідно переписати до третього масиву загальні
//елементи перших двох масивів без повторень.
            Console.WriteLine("Practice/Mod02/ex04\n");
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            int[] ArrM = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] ArrN = {2, 4, 6, 8, 11, 13, 15};
            int size = 0;
            int[] ArrS = new int[size];
            Console.Write($"Початковий масив ArrM: ");
            for (int i = 0; i < ArrM.Length; i++)
            {
                Console.Write(ArrM[i] + " ");
            }
            Console.WriteLine();
            Console.Write($"\nПочатковий масив ArrN: ");
            for (int i = 0; i < ArrN.Length; i++)
            {
                Console.Write(ArrN[i] + " ");
            }
            Console.WriteLine();
            Console.Write($"\nМасив ArrS з однаковими елементами: ");
            for (int i = 0; i < ArrM.Length; i++)
            {
                for (int j = 0; j < ArrN.Length; j++)
                {
                    if (ArrM[i] == ArrN[j])
                    {
                        size++;
                        Array.Resize(ref ArrS, size);
                        ArrS[size - 1] = ArrM[i];
                        Console.Write(ArrS[size - 1] + " ");
                    }
                }
            }
            Console.Write($"\n\nМасив ArrS з унікальними елементами:");
            for(int i=0;i<ArrM.Length;i++)
            {
                bool flag = true;
                for(int j=0;j<ArrN.Length;j++)
                {
                    if (ArrM[i] == ArrN[j])
                    {
                        flag = false;
                        break;
                    }
                }
                if(flag)
                {
                    size++;
                    Array.Resize(ref ArrS, size);
                    ArrS[size - 1] = ArrM[i];
                    Console.Write(ArrS[size - 1] + " ");
                }
            }
            for (int i = 0; i < ArrN.Length; i++)
            {
                bool flag = true;
                for (int j = 0; j < ArrM.Length; j++)
                {
                    if (ArrN[i] == ArrM[j])
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    size++;
                    Array.Resize(ref ArrS, size);
                    ArrS[size - 1] = ArrN[i];
                    Console.Write(ArrS[size - 1] + " ");
                }
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}