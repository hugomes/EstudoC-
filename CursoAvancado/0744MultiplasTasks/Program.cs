using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace _0744MultiplasTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Task> taskList = new List<Task>();
            taskList.Add(Task.Factory.StartNew(Metodo01));
            taskList.Add(Task.Factory.StartNew(Metodo01));
            taskList.Add(Task.Factory.StartNew(Metodo01));
            taskList.Add(Task.Factory.StartNew(Metodo01));

            Task.WaitAll(taskList.ToArray());

            string[] urls = new string[] { "http://www.google.com", "http://www.microsoft.com", "http://www.yahoo.com"};
            var listaUrls = from end in urls select Download(end); 
            Task.WaitAll(listaUrls.ToArray());

            Console.WriteLine("Finalizado!");
            Console.ReadLine();
        }

        static void Metodo01()
        {
            for (int i = 0; i < 100; i++) {
                Console.WriteLine("Task: "+Task.CurrentId+" - "+i);
            }
        }

        public static async Task Download(string endereco) {
            WebClient web = new WebClient();
            string html = await web.DownloadStringTaskAsync(endereco);
            Console.WriteLine("Página: " + endereco);
        }
    }
}
