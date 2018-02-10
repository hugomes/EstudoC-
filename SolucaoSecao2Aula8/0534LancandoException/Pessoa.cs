using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0534LancandoException
{
    class Pessoa
    {
        private string Nome;
        private string Cpf;
        private string Cep;

        public void SetCep(string cep) {
            int resultado;
            int.Parse(cep);
            if (int.TryParse(cep, out resultado))
            {
                Cep = cep;
            }
            else {
                throw new Exception("CEP Inválido!");
            }
        }
    }
}
