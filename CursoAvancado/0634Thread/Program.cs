using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _0634Thread
{
    class Program
    {
        static object VariavelControle = 0;
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread t1 = new Thread(()=>ThreadRepeticao(i));
                t1.IsBackground = true;
                t1.Start();
            }

            Console.ReadKey();
        }

        static void ThreadRepeticao(int num) {
            for (int i = 0; i < 1000; i++) {
                lock (VariavelControle) {
                    Console.WriteLine(Thread.CurrentThread.ManagedThreadId+" Thread: "+ num +" - num:" + i);
                }
            }
        }
    }
}
