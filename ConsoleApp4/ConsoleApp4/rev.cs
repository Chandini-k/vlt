using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class rev
    {
        
        public static void Main()
        {
            int[] array = { 2, 4, 6, 8 };

            int n = array.Length-1;
            string str = null;
            while(n>=0)
            {
                str = str + array[n];
                n--;
            }
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
