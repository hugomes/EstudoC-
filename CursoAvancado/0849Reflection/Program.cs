using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0849Reflection.Model;

namespace _0849Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario() { Nome = "Hugo", Email = "hugo@email.com", Senha = "123" };
            Log.GravarUsuario(usuario);
            Log.Gravar(usuario);

            Usuario usuario2 = (Usuario)usuario.Clone();
            usuario2.Nome = "Mario";
            Log.GravarUsuario(usuario2);
            Log.Gravar(usuario2);

            Carro carro = new Carro() { Marca = "FIAT", Modelo = "Uno" };
            Log.Gravar(carro);

            Log.ListaLog();

            Log.ApresentarLog();

            Console.WriteLine("Gravado");
            Console.ReadKey();
        }
    }
}
