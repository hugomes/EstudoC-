using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using _0203SerializarXMLBiblioteca;
using System.Xml.Serialization;
using System.Xml;

namespace _0203SerializarXML
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

            XmlSerializer serializer = new XmlSerializer(typeof(Usuario));
            string path = "C:\\Users\\Pessoal\\Documents\\visual studio 2015\\Projects\\CursoAvancado\\0203SerializarXML\\Arquivos\\ArquivoSerializado.xml";
            StreamWriter stream = new StreamWriter(path);
            serializer.Serialize(stream, usuario);
            stream.Close();

            StreamReader reader = new StreamReader(path);
            Usuario novoUsuario = (Usuario)serializer.Deserialize(reader);

            string i = "";
        }
    }
}
