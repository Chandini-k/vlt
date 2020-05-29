using System;
using System.Collections;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no of exp");
            int n = int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("Enter exp");
                string exp = Console.ReadLine();
                bool res = BalancedorNot(exp);
                if (res)
                {
                    Console.WriteLine("Balanced");
                }
                else
                    Console.WriteLine("Not Balanced");
            }
            Console.ReadLine();
        }

        public static bool BalancedorNot(string exp)
        {
            char[] a = exp.ToCharArray();//convert string to character array
            bool result = true;
            Stack s = new Stack();
            foreach(var e in a)
            {
                string str = e.ToString();
                switch(str)
                {
                    case "[":s.Push(str);
                             if(s.Count>0)
                             {
                               if (s.Peek().ToString() == "[")
                               {
                                s.Pop();
                               }
                              else
                              {
                                result = false;
                              }
                        }
                        break;
                    case "(":
                        s.Push(str);
                        if (s.Count > 0)
                        {
                            if (s.Peek().ToString() == "(")
                            {
                                s.Pop();
                            }
                            else
                            {
                                result = false;
                            }
                        }
                        break;
                    case "{":
                        s.Push(str);
                        if (s.Count > 0)
                        {
                            if (s.Peek().ToString() == "{")
                            {
                                s.Pop();
                            }
                            else
                            {
                                result = false;
                            }
                        }
                        break;
                    default: result = false;
                        break;
          
                }
            }
            return result;
        }
    }
}
