using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0534LancandoException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Pessoa pessoa = new Pessoa();
                pessoa.SetCep("ASD");
            }
            catch (FormatException forExcep)
            {
                Console.WriteLine("Format exception capturada: " + forExcep.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro capturado: " + e.Message);
            }
            finally
            {
                Console.WriteLine("FIM");
            }
            Console.ReadKey();
        }
    }
}
