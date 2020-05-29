using System;using System.Collections.Generic;using System.Linq;
namespace SubSequenceRemoval{    class Program    {        static void Main(string[] args)        {            Console.WriteLine("Enter n:");            int n = Convert.ToInt32(Console.ReadLine());            int[] a = new int[n];            for (int i = 0; i < n; i++)            {                a[i] = Convert.ToInt32(Console.ReadLine());            }            List<int> li = new List<int>();            List<int> li1 = new List<int>();            for (int i = 0; i < n; i++)            {                if (!li.Contains(a[i]))                    li.Add(a[i]);                else                    li1.Add(a[i]);            }            Console.WriteLine("Output");            List<int> arr = li1.ToList();            var ac = arr.OrderBy(d => d);            if(arr.SequenceEqual(ac))
            {
                foreach(var e in arr)
                {
                    Console.WriteLine(e);
                }
            }            else
            {
                Console.WriteLine("-1");
            }            Console.ReadLine();        }    }}