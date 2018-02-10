using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0427ClasseAbstrata.Lib
{
    abstract class Veiculo
    {
        abstract public String Marca { get; set; }
        abstract public void Acelerar(byte impulso);
    }
}
