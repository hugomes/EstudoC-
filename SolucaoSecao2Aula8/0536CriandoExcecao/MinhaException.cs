using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0536CriandoExcecao
{
    class MinhaException : Exception
    {
        string linhaErro;

        public MinhaException(string linha) : base("Erro!")
        {
             
        }
    }
}
