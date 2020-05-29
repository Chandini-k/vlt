using System;
using System.Linq;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            Console.WriteLine("Enter array of ele");
            for(int i=0;i<5;i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int sum = array.Sum();
            int min = array.Min();
            int max = array.Max();
            int SumMin = sum - max;
            Console.WriteLine("Minimum Sum : " +SumMin);
            int SumMax = sum - min;
            Console.WriteLine("Max Sum : " + SumMax);
            Console.ReadLine();
        }
    }
}
