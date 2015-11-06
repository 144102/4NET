using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> lli = PopulateList();

            // on démarre le chrono
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            // long traitement, jusqu'à 1.2*10^9 multiplications.
            // en ordonné traditionnel
            OrderedWork(lli);

            stopWatch.Stop();            
            Trace.WriteLine(string.Format("traditionnel : {0}ms",stopWatch.ElapsedMilliseconds));
            stopWatch.Restart();

            // en parallèle
            ParallelWork(lli);

            stopWatch.Stop();
            Trace.WriteLine(string.Format("parallèle : {0}ms", stopWatch.ElapsedMilliseconds));


        }

        static List<List<int>> PopulateList()
        {
            var lli = new List<List<int>>();
            Random r = new Random();
            for (int i = 0; i < 2000; i++)
            {
                List<int> li = new List<int>();
                for (int j = 0; j < 2000; j++)
                {
                    li.Add(r.Next(20, 300));
                }
                lli.Add(li);
            }
            return lli;
        }

        static void OrderedWork(List<List<int>> lli)
        {
            lli.ForEach(n => n.ForEach(el => Enumerable.Range(1, el).Aggregate((a, b) => a * b)));
        }

        static void ParallelWork(List<List<int>> lli)
        {
            lli.ForEach(n => n.AsParallel().ForAll(el => Enumerable.Range(1, el).Aggregate((a, b) => a * b)));
        }
    }
}
