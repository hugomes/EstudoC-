using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0849Biblioteca.Model
{
    [Serializable]
    public sealed class Funcionario : Pessoa
    {
        public DateTime DataContratacao { get; set; }
        public double Salario { get; set; }
        public string Cargo { get; set; }
    }
}
