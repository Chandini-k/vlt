using System;
using System.Text.RegularExpressions;


namespace rev
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int num = 123;
    //        int n = num;
    //        int result = 0;
    //        while (num > 0)
    //        {
    //            result = result * 10 + num % 10;
    //            num /= 10;
    //        }
    //        int newNumber = int.Parse(result.ToString() + n.ToString());
    //        Console.WriteLine(newNumber);
    //        Console.ReadLine();
    //    }
    //}
    //class program
    //{
    //    public static double AverageWordLength(string str)
    //    {
    //        decimal total = 0;
    //        string[] arr = str.Split(' ');
    //        foreach (string s in arr)
    //        {
    //            Match m = Regex.Match(s, @"[a-zA-Z]*");
    //            total += m.Length;
    //        }
    //        decimal result = total / arr.Length;
    //        string d=Math.Round(result, 2).ToString("0.00");
    //        double res = double.Parse(d);
    //        return res;
    //    }
    //    public static void Main()
    //    {
    //        Console.WriteLine(AverageWordLength("I want to go home"));
    //        Console.ReadLine();
    //    }
    //}
    class program
    {
        public static string AverageWordLength(string s1,string s2)
        {
            string s3="";
            for(int i=s1.Length;i>0;i--)
            {
                for(int j=s2.Length;j>0;j--)
                {
                    if(i!=j)
                    {
                        break;
                    }
                }
                s3 += i;
            }
            return s3;
        }
        public static void Main()
        {
            string str1 = "abcdefg";
            string str2 = "adgefg";
            Console.WriteLine(AverageWordLength(str1,str2));
            Console.ReadLine();
        }
    }
}
