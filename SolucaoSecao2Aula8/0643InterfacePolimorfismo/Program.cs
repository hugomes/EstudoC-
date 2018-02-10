using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0643InterfacePolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            carro.Marca = "FIAT";

            SobreVeiculo(carro);

            SobreTransporte(carro, carro);

            Console.ReadKey();

        }

        static void SobreVeiculo(Veiculo veiculo) {
            Console.WriteLine("Veículo: " + veiculo.Marca);
        }

        static void SobreTransporte(Veiculo veiculo, ITransporte transporte)
        {
            transporte.Andar(veiculo);
        }
    }
}
