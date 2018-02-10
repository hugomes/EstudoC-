using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0208ModificadoresAcesso.Lib
{
    class Veiculo
    {
        public string Marca;
        private string Modelo;
        protected string AnoFabricacao;

        void InfoVeiculo() {
            Marca = "FIAT";
            Console.WriteLine(Marca);
            Modelo = "Palio";
        }
    }
}
