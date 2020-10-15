using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program2
    {
        static void Truc()
        {
            Console.WriteLine("Введите переменную A: ");
            string A = Console.ReadLine(); //число
            Console.WriteLine("Введите переменную n: ");
            int n = Convert.ToInt32(Console.ReadLine()); //разрядность
            char[] owner = A.ToCharArray();
            int sum= 0;
            int st = 0;
            for (int i = owner.Length - 1; i >= 0; i--)
            {
                var temp = Math.Pow(Convert.ToDouble(n), Convert.ToDouble(st++));
                var tm = Convert.ToInt32(owner[i].ToString());
                sum += tm  * (int)temp;
            }
            Console.WriteLine(sum);


        }
        static void Main(string[] args)
        {
            Truc();
            /*
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
            */
            Console.ReadLine();



        }
    }
}
