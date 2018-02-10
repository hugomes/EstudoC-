using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0522Delegate.Library
{
    public class FotoFiltro
    {
        public void Colorir(Foto foto)
        {
            Console.WriteLine("Colorir: " + foto.Nome);
        }

        public void GerarThumb(Foto foto)
        {
            Console.WriteLine("GerarThumb: " + foto.Nome);
        }

        public void PretoBranco(Foto foto)
        {
            Console.WriteLine("PretoBranco: "+ foto.Nome);
        }

        public void Redimensionar(Foto foto)
        {
            Console.WriteLine("Redimensionar: " + foto.Nome);
        }

    }
}
