using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0308Generics.Library;

namespace _0308Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro
            {
                Marca = "FIAT",
                Modelo = "Uno"
            };

            Casa casa = new Casa
            {
                Cidade = "Recife",
                Endereco = "Aflitos"
            };

            Usuario usuario = new Usuario
            {
                Email = "maria@email.com",
                Nome = "Maria",
                Senha = "maria123"
            };

            Serializador.Serializar(carro);
            Serializador.Serializar(casa);
            Serializador.Serializar(usuario);

            Carro carro2 = Serializador.Desserializar<Carro>();
            Usuario usuario2 = Serializador.Desserializar<Usuario>();
            Casa casa2 = Serializador.Desserializar<Casa>();

            Console.ReadKey();
        }
    }
}
