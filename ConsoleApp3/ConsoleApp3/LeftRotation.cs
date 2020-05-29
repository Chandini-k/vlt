using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class LeftRotation
    { 
            //string left = string.Join(
            //    " ", arr.Take(rot).ToArray()
            //);
            //string right = string.Join(
            //    " ", arr.Skip(rot).ToArray()
            //);
            //return right + ' ' + left;
            public static int[] rotLeft(int[] a, int d)
            {
                for (int intI = 0; intI < d; intI++)
                {
                    int temp = a[0];

                    for (int intK = 0; intK < a.Length - 1; intK++)
                    {
                        a[intK] = a[intK + 1];
                    }

                    a[a.Length - 1] = temp;
                }

                return a;
            }

        static void Main(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            int[] a_temp = Convert.ToInt32(Console.ReadLine()).Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            // rotate and return as string
            int result = rotLeft(k, a);
            // print result        
            Console.WriteLine(result);
        }
    }
}
