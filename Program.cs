using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace stressslbl
{
    class Program
    {
        private static string sss;

        public static void ConsumeCPU(int percentage)
        {
            if (percentage < 0 || percentage > 100)
                throw new ArgumentException("percentage");
            Stopwatch watch = new Stopwatch();
            watch.Start();
            while (true)
            {
                // Make the loop go on for "percentage" milliseconds then sleep the 
                // remaining percentage milliseconds. So 40% utilization means work 40ms and sleep 60ms
                if (watch.ElapsedMilliseconds > percentage)
                {
                    Thread.Sleep(100 - percentage);
                    watch.Reset();
                    watch.Start();
                }
            }
        }
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("enter number % to stresss cpu");
               sss = Console.ReadLine();
                try
                { if (sss != string.Empty)
                    {
                        for (int hj = 0; hj < 8; hj++)
                        {
                            Thread ghn = new Thread(pjk);
                            ghn.Start();
                        }


                    }
                    else
                { break; } 
                }
                catch { }
            }
        }

        private static void pjk()
        {
            ConsumeCPU(int.Parse(sss));
        }
    }
}
