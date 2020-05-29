using System;
using System.Linq;

namespace Reverse
{
    public class Class1
    {
        public static void main(string[] args)
        {

            int num = 123;
            int result = 0;
            while (num > 0)
            {
                result = result * 10 + num % 10;
                num /= 10;
            }
            int newNumber = int.Parse(result.ToString() + num.ToString());
            Console.WriteLine(newNumber);
            Console.ReadLine();
        }
    }
}
