using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _2_Even_Fibonacci_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int t = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                long n = Convert.ToInt64(Console.ReadLine());
                Function(n);

            }


        }

        public static void Function(long n_limit)
        {
            List<long> list = new List<long>();

            list.Add(0);
            list.Add(1);

            for (int i = 0; i < n_limit; ++i)
            {
                if (list[list.Count - 2] + list[list.Count - 1] < n_limit )
                {
                    list.Add(list[list.Count - 2] + list[list.Count - 1]);

                }
            }

            list.Remove(0);
            list.Remove(1);

            Console.WriteLine("Even Fibonacci numbers under limit: " + n_limit);


            for (int i = 0; i < list.Count(); ++i)
            {
                Console.WriteLine(list[i] + " ");
            }



            for (int i = 0; i < list.Count(); ++i)
            {

                if (list[i] % 2 == 0 && list[i] < n_limit)
                {

                    continue;

                }
                else
                {
                    list.RemoveAt(i);
                    --i;
                }


            }

             Console.WriteLine();
             Console.WriteLine("Even Fibonacci numbers: ");
             for (int i = 0; i < list.Count(); ++i)
             {
                 Console.WriteLine(list[i] + " ");
             }
 
            long sum = 0;

            for (int i = 0; i < list.Count(); ++i)
            {
                if (list[i] < n_limit)
                {
                    sum += list[i];
                }
            }

            Console.WriteLine("Sum: " + sum);

            //Console.WriteLine(sum);





        }


    }

    


}
