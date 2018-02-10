using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using _0849Biblioteca.Model;

namespace _0849Biblioteca.Arquivo
{
    public class GerenciadorArquivos
    {
        public void GravarArquivo(string nome, object obj) {
            string caminho = "C:\\Users\\Pessoal\\Documents\\"+nome+".txt";
            BinaryFormatter bf = new BinaryFormatter();

            if (File.Exists(caminho))
            {
                using (FileStream fs = new FileStream(caminho, FileMode.Append, FileAccess.Write)) {
                    bf.Serialize(fs, obj);
                }
            }
            else
            {
                using (FileStream fs = new FileStream(caminho, FileMode.Create, FileAccess.Write))
                {
                    bf.Serialize(fs, obj);
                }
            }
        }

        public List<Cliente> LerArquivo(string nome) {
            string caminho = "C:\\Users\\Pessoal\\Documents\\" + nome + ".txt";
            BinaryFormatter bf = new BinaryFormatter();

            List<Cliente> objList = new List<Cliente>();

            if (File.Exists(caminho))
            {
                using (FileStream fs = new FileStream(caminho, FileMode.Open, FileAccess.Read))
                {
                    objList = (List<Cliente>)bf.Deserialize(fs);
                }
            }

            return objList;
        }
    }
}
