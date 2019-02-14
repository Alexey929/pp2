using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //File.Create(@"C:\Users\123\source\repos\Week2\path\TextFile.txt");
            var TextFile = File.Create(@"C:\Users\123\source\repos\Week2\path\TextFile.txt");
            TextFile.Close();
            File.Copy(@"C:\Users\123\source\repos\Week2\path\TextFile.txt", @"C:\Users\123\source\repos\Week2\path1\TextFile.txt");
            File.Delete(@"C:\Users\123\source\repos\Week2\path\TextFile.txt");
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey(true);
        }
    }
}
