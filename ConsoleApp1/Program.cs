using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program2
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Введите переменную A: " );
            int A  = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите переменную n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> m = new List<int>();


            int k = A / n;
            int t = A % n;

            //m.Insert(0,t);
            m.Add(t);
            
            
            //---------------------------

            while (k >= n)
            {
                t = k % n;
                k = k / n;
                m.Add(t);
            }
            m.Add(k);
            for (int i = 0; i < m.Count; i++)
            {
                Console.Write(m[i]);
            }
            Console.ReadLine();



        }
    }
}
