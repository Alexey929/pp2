﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        public static bool isprime( int a)
        {
            int k = 0;
            for  ( int i=2; i < a; i++)
            {
                if (a%i == 0)
                {
                    k++;
                }
            }
            if (k == 0) return true;
            else return false;
        }


        static void Main(string[] args)
        {
            string s = File.ReadAllText(@"C: \Users\123\source\repos\Week2\input2.txt");
            int [] a = new int[s.Length];
            string[] str = new string[s.Length];
            str = s.Split();
            for (int i = 0; i < str.Length; i++)
            {
                a[i] = int.Parse(str[i]);
            }
            StreamWriter sw = new StreamWriter(@"C:\Users\123\source\repos\Week2\output2.txt");
            for ( int i = 0; i < str.Length; i++)
            {
                if (isprime(a[i]) == true)
                {
                    sw.Write(a[i]);
                    sw.Write(' ');
                }
            }
            sw.Close();
            Console.ReadKey();
            
        }
    }
}
