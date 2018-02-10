using System;
using _0849Biblioteca.Model;
using _0849Biblioteca.Arquivo;
using System.Collections.Generic;

namespace _0849Projeto.Telas
{
    class ManterCliente
    {
        public void CadastrarCliente()
        {
            Console.Clear();
            Console.WriteLine("CADASTRAR CLIENTE");

            Cliente cliente = new Cliente();

            Console.Write("Nome: ");
            cliente.Nome = Console.ReadLine();

            Console.Write("Data de nascimento: ");
            cliente.DataNascimento = DateTime.Parse(Console.ReadLine());

            Console.Write("Telefone: ");
            cliente.Telefone = Console.ReadLine();

            Console.Write("CPF: ");
            cliente.Cpf = Console.ReadLine();

            Console.Write("RG: ");
            cliente.Rg = Console.ReadLine();

            Console.Write("CEP: ");
            cliente.Cep = Console.ReadLine();

            Console.Write("Endereço: ");
            cliente.Endereco = Console.ReadLine();

            Console.Write("Cidade: ");
            cliente.Cidade = Console.ReadLine();

            Console.Write("Estado: ");
            cliente.Estado = Console.ReadLine();

            GerenciadorArquivos ga = new GerenciadorArquivos();
            ga.GravarArquivo("cliente", cliente);
        }

        public void ListarClientes() {
            GerenciadorArquivos ga = new GerenciadorArquivos();
            List<Cliente> cliente = ga.LerArquivo("cliente");
        }

    }
}
