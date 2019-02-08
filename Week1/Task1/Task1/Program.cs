using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool f(int b)
            {
                if (b == 1)
                {
                    return false;
                }
                int k = 0;
                for (int i = 2; i < b; i++)
                {
                    if (b % i == 0) { k++; }
                }
                if (k == 0)
                {
                    return true;
                }

                else return false;
            }
            int cnt = 0;
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];//new int array
            for ( int i=0; i < n; i++)
            {
               a[i] = int.Parse(Console.ReadLine());
            }
            for ( int i = 0; i <n; i++)
            {
                if ( f(a[i])== true)
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
            for ( int i = 0; i < n; i++)
            {
                if ( f(a[i]) == true)
                {
                    Console.Write(a[i]);
                    Console.Write(' ');
                }
            }

            
            Console.WriteLine("\n Для продолжения нажмите любую клавишу...");
            Console.ReadKey(true);

        }
    }
}
