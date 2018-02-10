using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0536CriandoExcecao
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new MinhaException("10");
            }
            catch (MinhaException me)
            {
                Console.WriteLine(me.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Source);
            }
            Console.ReadKey();
        }
    }
}
