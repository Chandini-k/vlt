using System;
using System.Collections.Generic;
using System.IO;
namespace ConsoleApp10
{
    class Solution
    {
        static void Main(String[] args)
        {
            var queries = int.Parse(Console.ReadLine());
            var stack1 = new Stack<int>();
            var stack2 = new Stack<int>();
            var queueStack1 = false;

            for (int i = 0; i <queries; i++)
            {
                var value = Console.ReadLine().Split(' ');
                var queryType = int.Parse(value[0]);
                switch (queryType)
                {
                    case 1:
                        if (stack1.Count == 0 && stack2.Count == 0)
                        {
                            stack1.Push(int.Parse(value[1]));
                            queueStack1 = true;
                        }
                        else
                            stack2.Push(int.Parse(value[1]));

                        break;
                    case 2:
                        if (queueStack1 == true)
                        {
                            stack1.Pop();
                            if (stack2.Count != 0 && stack1.Count == 0)
                                queueStack1 = false;
                        }
                        else
                        {
                            if (stack2.Count > 0)
                            {
                                while (stack2.Count > 1)
                                    stack1.Push(stack2.Pop());

                                stack2.Pop();
                                queueStack1 = true;
                            }

                        }
                        break;
                    case 3:
                        if (queueStack1 == true)
                            Console.WriteLine(stack1.Peek());
                        else
                        {
                            if (stack2.Count > 0)
                            {
                                while (stack2.Count > 0)
                                    stack1.Push(stack2.Pop());

                                queueStack1 = true;
                                Console.WriteLine(stack1.Peek());
                            }

                        }
                        break;
                }
            }
            Console.ReadLine();
        }

    }
}
