using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0849Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            while (opcao != 5)
            {
                Console.WriteLine("O que deseja fazer? \n(1) Cadastrar Cliente \n(2) Listar Cliente \n(3) Cadastrar Funcionário \n(4) Listar Funcionário \n(5) Sair)");
                opcao = int.Parse(Console.ReadLine());

                Telas.ManterCliente manterCliente = new Telas.ManterCliente();
                Telas.ManterFuncionario manterFuncionario = new Telas.ManterFuncionario();
                switch (opcao) {
                    case 1:
                        manterCliente.CadastrarCliente();
                        break;
                    case 2:
                        manterCliente.ListarClientes();
                        break;
                    case 3:
                        manterFuncionario.CadastrarFuncionario();
                        break;
                    case 4:
                        manterFuncionario.ListarFuncionarios();
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Comando não encontrado.");
                        break;

                }
            }
        }
    }
}
