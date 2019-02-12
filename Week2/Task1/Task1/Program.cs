using System;
using System.IO;
namespace Task1
{
    class Program
    {

        public static bool palindrome(string s)
        {
            char[] letter = new char[s.Length];
            letter = s.ToCharArray();
            int length = s.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (letter[i] != letter[length - i - 1])
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            string direction = (@"C:\Users\123\source\repos\Week2\input1.txt");
            string check = File.ReadAllText(direction);
             if (palindrome(check) == true)
             {
                 Console.WriteLine("Yes");
             }
             else if (palindrome(check) ==  false)
             {
                 Console.WriteLine("No");
             }
            
            Console.ReadKey();
        }
    }
}