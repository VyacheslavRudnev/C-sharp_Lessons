using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Practice/Mod02/ex04");
            Console.WriteLine();
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            int[] ArrM = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] ArrN = {2, 4, 6, 8, 11, 13, 15};
            int size = 0;
            int[] ArrS = new int[size];
            
            for (int i = 0; i < ArrM.Length; i++)
            {
                for (int j = 0; j < ArrN.Length; j++)
                {
                    if (ArrM[i] != ArrN[j])
                    {
                        int k = 0;
                        ArrS[k] = ArrM[i];
                        k++;
                    }
                  
                }
               
            }


            for (int i = 0; i < ArrN.Length; i++)
            {
                for (int j = 0; j < ArrM.Length; j++)
                {
                    if (ArrN[i] != ArrM[j])
                    {
                        ArrS[k] = ArrN[i];
                        k++;
                    }
                }
            }
            for (k = 0; k < ArrS.Length; k++)
            {
                Console.Write(ArrS[k] + " ");
            }



            Console.WriteLine();
            Console.ReadKey();
        }
    }
}