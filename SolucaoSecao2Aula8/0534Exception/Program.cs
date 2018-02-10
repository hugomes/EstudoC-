using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0534Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 1: ");
            string digitado = Console.ReadLine();

            if (digitado == "1")
            {
                Console.WriteLine("Correto!");
            }
            else {
                Console.WriteLine("Errado!");
            }

            Console.ReadKey();
        }
    }
}
