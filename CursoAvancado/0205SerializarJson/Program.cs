using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using _0203SerializarXMLBiblioteca;

namespace _0205SerializarJson
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario()
            {
                Nome = "Hugo Gomes",
                Cpf = "94873664539",
                Email = "email@teste.com"
            };

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string objetoSerializado = serializer.Serialize(usuario);

            Usuario novoUsuario = (Usuario)serializer.Deserialize(objetoSerializado, typeof(Usuario));

            Console.ReadKey();
        }
    }
}
