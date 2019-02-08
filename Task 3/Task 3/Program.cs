using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for ( int i =0; i<n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            int[] b = new int[n * 2];
            int k = -1;
            for ( int i = 0; i < n * 2; i++)
            {
                if ( i%2 == 0)
                {
                    k++;
                }
                b[i] = a[k];
            }
            for (int i = 0; i < n * 2; i++)
            {
                Console.Write(b[i]);
                Console.Write(' ');
            }

            Console.WriteLine("\n Для продолжения нажмите любую клавишу...");
            Console.ReadKey(true);
        }
    }
}
