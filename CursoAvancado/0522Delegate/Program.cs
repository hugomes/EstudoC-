using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0522Delegate.Library;

namespace _0522Delegate
{
    class Program
    {
        delegate int Calcula(int a, int b);
        static void Main(string[] args)
        {
            Calcula calc = new Calcula(Soma);
            int resultado = calc(30, 20);

            Soma(10, 20);
            Subtrair(30, 10);


            Foto foto = new Foto() { Nome = "fotografia", TamanhoX = 200, TamanhoY = 300 };
            FotoProcessador.filtros = new FotoFiltro().GerarThumb;
            FotoProcessador.Processador(foto);

            FotoProcessador.filtros = new FotoFiltro().Colorir;
            FotoProcessador.filtros += new FotoFiltro().Redimensionar;
            FotoProcessador.Processador(foto);

            Console.ReadKey();

        }

        static int Soma(int a, int b)
        {
            return a + b;
        }
        static int Subtrair(int a, int b)
        {
            return a - b;
        }
    }
}
