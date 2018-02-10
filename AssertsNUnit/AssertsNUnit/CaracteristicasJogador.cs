using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssertsNUnit
{
    public class CaracteristicasJogador
    {
        public int Vida { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public bool Novato { get; set; }
        public List<string> Armas { get; set; }

        public CaracteristicasJogador()
        {
            Vida = 100;
            Nome = GerarNome();
            Novato = true;
            CriarArmasIniciais();
        }

        public void Dormir()
        {
            var random = new Random();
            //aumentar a vida do jogador
            var aumentarVida = random.Next(1, 101);
            Vida += aumentarVida;
        }

        public void PerderVida(int perderVida)
        {
            Vida = Math.Max(1, Vida -= perderVida);
        }

        //escolher nome do jogador de maneira randomica
        private string GerarNome()
        {
            var nomes = new[] { "Hugo", "Carlos", "Mario" };
            return nomes[new Random().Next(0, nomes.Length)];
        }

        //criar e atribuir armas para o jogador
        private void CriarArmasIniciais()
        {
            Armas = new List<string>{ "Revólver", "Faca", "Metralahadora", "Granada" };
        }
    }
}
