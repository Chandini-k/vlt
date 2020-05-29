//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp13
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string filename = Console.ReadLine();
//            string[] readText = File.ReadAllLines(filename + ".txt");
//            foreach(var s in readText)
//            {
//                if (s.Contains("gif") == true)
//                {
//                    string[] abc = s.Split(' ');
//                    foreach (var e in abc)
//                    {
//                        if(e.Contains("gif"))
//                        Console.WriteLine(e);
//                    }
//                }
//            }
//            foreach (int value in list)
//            {
//                Console.WriteLine("Before: {0}", value);
//            }
//            // Step 2: get distinct elements and convert into a list again.
//            List<int> distinct = list.Distinct().ToList();
//            foreach (int value in distinct)
//            {
//                Console.WriteLine("After: {0}", value);
//            }
//            Console.ReadLine();
//        }
//    }
//}


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilePrograms
{
    public class host
    {
        public string name { get; set; }
        public int count { get; set; }
    }
    class GifFilerequest
    {
        public static List<host> hosts = new List<host>();
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines("Gif.txt");
            List<string> validLines = new List<string>();
            foreach (string line in lines)
            {
                if (line.Contains("GET") && line.Contains("200") && line.Contains(".gif"))
                {
                    int index = line.IndexOf(" HTTP");
                    int indexPrev = -1;
                    for (int i = index; i >= 35; i--)
                    {

                        if ('/'.CompareTo(line[i]) == 0)
                        {
                            indexPrev = i + 1;
                            break;
                        }
                    }

                    if (!validLines.Contains(line.Substring(indexPrev, index - indexPrev)))
                    {


                        validLines.Add(line.Substring(indexPrev, index - indexPrev));
                    }

                }
            }
            File.WriteAllLines("giflog.txt", validLines);
            Console.ReadLine();
        }
    }

}

