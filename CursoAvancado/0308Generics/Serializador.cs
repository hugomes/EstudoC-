using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;

namespace _0308Generics
{
    public class Serializador 
    {
        public static void Serializar(object obj)
        {
            string path = @"C:\Users\Pessoal\Documents\visual studio 2015\Projects\CursoAvancado\0308Generics\Library\"+ obj.GetType().Name+".txt";
            StreamWriter writer = new StreamWriter(path);

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            writer.Write(serializer.Serialize(obj));

            writer.Close();
        }

        public static T Desserializar<T>()
        {
            string path = @"C:\Users\Pessoal\Documents\visual studio 2015\Projects\CursoAvancado\0308Generics\Library\" + typeof(T).Name + ".txt";
            StreamReader reader = new StreamReader(path);
            string conteudo = reader.ReadToEnd();

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            return serializer.Deserialize<T>(conteudo);
        }
    }
}
