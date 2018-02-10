using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0208ModificadoresAcesso.Lib;

namespace _0208ModificadoresAcesso
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo veiculo = new Veiculo();
            Carro carro = new Carro();
            Caminhao caminhao = new Caminhao();

            caminhao.Marca = "Volvo";
            carro.Marca = "FIAT";
            
        }
    }
}
