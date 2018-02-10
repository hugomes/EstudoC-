using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace _0847Validacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario() { Nome = "Hu", Email="hugo", Senha="1234" };
            ValidationContext context = new ValidationContext(usuario);
            List<ValidationResult> resultados = new List<ValidationResult>();
            bool retorno = Validator.TryValidateObject(usuario, context, resultados, true);

            if (!retorno) {
                foreach (var erro in resultados) {
                    Console.WriteLine("Erro: " + erro.ErrorMessage);
                }
            }
            Console.ReadKey();
        }
    }
}
