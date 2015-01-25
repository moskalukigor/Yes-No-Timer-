using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics; 

namespace Yes_No_Timer_
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int time = r.Next(2000,5000);
            Stopwatch st = new Stopwatch();
            st.Start();
            while (st.ElapsedMilliseconds <= time) { }
            st.Stop();
            st = Starttimer();
            Console.WriteLine(st.Elapsed.ToString());
        }
        static Stopwatch Starttimer()
        {
            Console.WriteLine("s");
            Stopwatch st = new Stopwatch();
            st.Start();
            Console.ReadKey(true);
            st.Stop();
            
            return st;
        }
    }
}
