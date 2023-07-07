using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
//Завдання 3
//Користувач вводить рядок із клавіатури.Необхідно
//зашифрувати цей рядок, використовуючи шифр Цезаря.
//Окрім механізму шифрування, реалізуйте механізм
//розшифрування.
            Console.WriteLine("HW/Mod02/ex03\n");
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Введіть рядок для шифрування (англійською):");
            string input = Console.ReadLine();

            Console.WriteLine("Введіть ключ шифрування: ");
            int key = Convert.ToInt32(Console.ReadLine());

            string encryptedText = Encrypt(input, key);
            Console.WriteLine("Зашифрований рядок: " + encryptedText);

            string decryptedText = Decrypt(encryptedText, key);
            Console.WriteLine("Розшифрований рядок: " + decryptedText);

            Console.WriteLine();
            Console.ReadKey();
        }
        // Метод шифрування
        static string Encrypt(string text, int key)
        {
            char[] encryptedChars = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                char originalChar = text[i];

                if (char.IsUpper(originalChar))
                {
                    char encryptedChar = (char)(((originalChar - 'A' + key) % 26) + 'A');
                    encryptedChars[i] = encryptedChar;
                }
                else if (char.IsLower(originalChar))
                {
                    char encryptedChar = (char)(((originalChar - 'a' + key) % 26) + 'a');
                    encryptedChars[i] = encryptedChar;
                }
                else
                {
                    encryptedChars[i] = originalChar;
                }
            }
            string encryptedText = new string(encryptedChars);
            return encryptedText;
        }

        static string Decrypt(string text, int key)
        {
            char[] decryptedChars = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                char encryptedChar = text[i];

                if (char.IsUpper(encryptedChar))
                {
                    char decryptedChar = (char)(((encryptedChar - 'A' - key + 26) % 26) + 'A');
                    decryptedChars[i] = decryptedChar;
                }
                else if (char.IsLower(encryptedChar))
                {
                    char decryptedChar = (char)(((encryptedChar - 'a' - key + 26) % 26) + 'a');
                    decryptedChars[i] = decryptedChar;
                }
                else
                {
                    decryptedChars[i] = encryptedChar;
                }
            }
            string decryptedText = new string(decryptedChars);
            return decryptedText;
        }
    }
}