using System;
using System.Collections.Generic;
using System.Threading;

namespace Core_Killer
{
    class Program
    {
        Random rand = new Random();
        static List<Thread> threads = new List<Thread>();

        public void KillCore()
        {
            long num = 0;
            while (true)
            {
                num += rand.Next(100, 1000);
                if (num > 1000000) { num = 0; }
            }
        }

        public static void Main(string[] args)
        {
            Program prog = new Program();
            while (true)
            {
                threads.Add(new Thread(new ThreadStart(prog.KillCore)));
            }
        }
    }
}
