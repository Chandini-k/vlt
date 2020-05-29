using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class prd
    {
        public string prdname { get; set; }
        public int qty { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("Csv.txt");
            string[] word;
            List<string> validlines = new List<string>();
            foreach (string line in lines)
            {
                word = line.Split(',');
                List<prd> objs = new List<prd>();
                prd p1 = new prd();
                p1.prdname = word[2];
                p1.qty = Convert.ToInt32(word[3]);
                objs.Add(p1);
                var res =
                          (from i in objs
                           group i by i.prdname into f
                           select new
                           {
                               pname = f.Key,
                               AverageNumbers = f.Average(x => x.qty),
                           }).Distinct();
                FileStream fs = new FileStream("outputfile.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                foreach (var r in res)
                {
                    Console.WriteLine(r.pname + "," + r.AverageNumbers);
                    sw.WriteLine(r.pname + "," + r.AverageNumbers);
                }
                sw.Flush();
                fs.Close();
                Console.WriteLine("Content written to the File");
                Console.ReadLine();
            }
        }
    }
}
