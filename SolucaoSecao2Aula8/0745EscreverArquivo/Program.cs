using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _0745EscreverArquivo
{
    class Program
    {
        static private string caminho = "C:\\Users\\Pessoal\\Documents\\Arquivo\\arquivo.txt";
        static private string caminho2 = "C:\\Users\\Pessoal\\Documents\\Arquivo\\arquivo2.txt";
        static void Main(string[] args)
        {
            StreamWriter arquivo = new StreamWriter(caminho);

            arquivo.WriteLine("Este é o meu primeiro arquivo");
            arquivo.WriteLine("Segunda linha. \nTerceira linha.");

            arquivo.Close();

            Console.WriteLine("Arquivo Gravado");

            String todoTexto = File.ReadAllText(caminho);
            String[] texto = File.ReadAllLines(caminho);

            Console.WriteLine("Quantidade de linhas: " + texto.Length);

            int numLinha = 1;
            foreach (string linha in texto)
            {
                Console.WriteLine("Linha "+numLinha+": "+linha);
                numLinha++;
            }

            Console.WriteLine(todoTexto);

            //UsarUsing();

            Console.ReadKey();
        }

        //public static void UsarUsing()
        //{
        //    using (StreamWriter arquivo = new StreamWriter(caminho2))
        //    {
        //        arquivo.WriteLine("Este é o meu segundo arquivo");
        //        arquivo.WriteLine("Segunda linha. \nTerceira linha.");
        //    }
        //}
    }
}
