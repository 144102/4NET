using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = PopulateList(0,10);
            Print(inputList);
            Print(inputList.OrderBy(n => n).ToList());
            Print(inputList.OrderBy(n => n.ToString()).ToList());
            Print(inputList.Where(n => n % 2 == 0).ToList());
            //  foreach (var n in inputList.OrderBy(n => n))

            Console.ReadLine();
        }
        
        static List<int> PopulateList(int min, int max)
        {
            var list = new List<int>();
            var r = new Random();
            for(var i = min; i < max; i++)
            {
                list.Add(r.Next(1, 100));
            }
            return list;
        }

        static void Print(List<int> list)
        {
            var output = String.Empty;
            for(var i=0; i < list.Count; i++)
            {
                output = String.Concat(output,list[i]);
                if (i + 1 != list.Count)
                {
                    output =  String.Concat(output, " ");
                }
            }
            Console.WriteLine(output);

        }

    }

}
