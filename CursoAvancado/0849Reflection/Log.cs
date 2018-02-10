using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0849Reflection.Model;

namespace _0849Reflection
{
    class Log
    {
        public static List<object> listaObjetos = new List<object>();

        public static void Gravar(object obj)
        {
            listaObjetos.Add(obj);
        }

        public static void ListaLog()
        {
            foreach (object obj in listaObjetos)
            {
                Console.WriteLine("Log da classe " + obj.GetType().Name);
                foreach (var prop in obj.GetType().GetProperties())
                {
                    Console.WriteLine("Propriedade: "+prop.Name+" = " + prop.GetValue(obj));
                }
            }
        }
         
        public static List<Usuario> listaUsuario = new List<Usuario>();
        public static List<Carro> listaCarro = new List<Carro>();

        public static void GravarUsuario(Usuario usuario)
        {
            listaUsuario.Add(usuario);
        }

        public static void GravarCarro(Carro carro)
        {
            listaCarro.Add(carro);
        }

        public static void ApresentarLog()
        {
            foreach (Usuario usuario in listaUsuario)
            {
                Console.WriteLine("Nome: " + usuario.Nome);
            }
            foreach (Carro carro in listaCarro)
            {
                Console.WriteLine("Marca: " + carro.Marca);
            }
        }
    }
}
