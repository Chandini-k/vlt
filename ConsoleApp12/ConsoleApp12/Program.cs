using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] d = new int[n];
            Console.WriteLine("Enter t");
            int t,Count=0;
            t = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number");
            for(int i=0;i<n;i++)
            {
                d[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if(d[i]+d[i+1]+d[i+2]<=t)
                {
                    if (d[i]<d[i + 1]&&d[i+1]<d[i+2])
                    {
                        Count++;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
