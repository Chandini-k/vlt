using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, max, min;
            int[] a = new int[5];
            Console.WriteLine("Enter array of ele");
            for (int i = 0; i < 5; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            max = a[0];
            min = a[0];
            for (int i = 0; i < 5; i++)
            {
                if (max < a[i])
                    max = a[i];
                if (min > a[i])
                    min = a[i];
                sum = sum + a[i];
            }
            int MinSum = sum - max;
            Console.WriteLine("Min Sum :" +MinSum );
            int MaxSum = sum -min;
            Console.WriteLine("Max Sum :" + MaxSum);
            Console.ReadLine();
        }
    }
}
