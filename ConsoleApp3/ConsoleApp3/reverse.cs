using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class reverse
    {
        private static void swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        public static void Main()
        {
            int[] array = { 2, 4, 6, 8 };

            int n = array.Length;
            for (int i=0; i<n/2; i++)
            {
                swap(array, i, n-i-1);
            }

            Console.WriteLine(String.Join(',', array));
        }

    }
}
