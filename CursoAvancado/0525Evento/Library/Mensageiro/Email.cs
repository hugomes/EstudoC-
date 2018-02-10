using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0525Evento.Library.Mensageiro
{
    public class Email
    {
        public void EnviarMensagem(object sender, VideoEventArgs args)
        {
            Console.WriteLine("Mensagem de email enviada com o vídeo " + args.Video.Nome);
        }
    }
}
