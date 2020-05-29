using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "mark";
            string str2 = "marcus";

            Console.WriteLine("str1 = '{0}'", str1);
            Console.WriteLine("str2 = '{0}'", str2);

            Console.WriteLine("After using String.Copy...");
            str2 = String.Copy(str1);

            Console.WriteLine("str1 = '{0}'", str1);
            Console.WriteLine("str2 = '{0}'", str2);
            Console.ReadLine();
        }
    }
}
