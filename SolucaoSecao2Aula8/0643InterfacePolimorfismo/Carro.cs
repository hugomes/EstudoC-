using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0643InterfacePolimorfismo
{
    class Carro : Veiculo,ITransporte
    {
        public void Andar(Veiculo veiculo)
        {
            Console.WriteLine(veiculo.Marca + " andando...");
        }
    }
}
