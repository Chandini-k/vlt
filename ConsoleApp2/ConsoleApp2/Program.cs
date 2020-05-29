using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> l1 = new List<int>();
            //l1.Add(1);
            //l1.Add(2);
            //foreach(int e in l1)
            //{
            //    Console.WriteLine(e);
            //}
            //ArrayList a = new ArrayList();
            //a.Add(1);
            //a.Add("Chandu");
            //Console.WriteLine(a[1]);
            //int[,] array = new int[3, 2];
            Console.WriteLine("Enter no of rows and col for an array");
            int m = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[m, n];
            Console.WriteLine("Enter an array");
            for (int i=0;i<m;i++)
            {
                for(int j=0;j<n;j++)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Array");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("a[{0},{1}]={2} ", i,j,array[i, j]);
                }
            }
            Console.ReadLine();
        }
    }
}
