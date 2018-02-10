using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _0640Thread
{
    class Program
    {
        static ManualResetEvent manualResetEvent;
        static AutoResetEvent autoResetEvent;

        static void Main(string[] args)
        {
            manualResetEvent = new ManualResetEvent(false);
            autoResetEvent = new AutoResetEvent(false);

            Thread t1 = new Thread(Executa01);
            t1.Start();
            Thread t2 = new Thread(Executa02);
            t2.Start();

            Thread.Sleep(5000);
            manualResetEvent.Set();
            manualResetEvent.Reset();
            autoResetEvent.Set();

            Thread.Sleep(5000);
            manualResetEvent.Set();
            autoResetEvent.Set();



            Console.ReadKey();
        }

        public static void Executa01()
        {
            Console.WriteLine("01 - Executa 01");
            manualResetEvent.WaitOne(1000);
            Console.WriteLine("02 - Executa 01");
            Console.WriteLine("03 - Executa 01");
            manualResetEvent.WaitOne(1000);
            Console.WriteLine("04 - Executa 01");
        }
        public static void Executa02()
        {
            Console.WriteLine("01 - Executa 02");
            autoResetEvent.WaitOne();
            Console.WriteLine("02 - Executa 02");
            Console.WriteLine("03 - Executa 02");
            autoResetEvent.WaitOne();
            Console.WriteLine("04 - Executa 02");
        }
    }
}
