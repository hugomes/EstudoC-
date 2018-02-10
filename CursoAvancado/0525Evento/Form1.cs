using _0525Evento.Library;
using _0525Evento.Library.Mensageiro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0525Evento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVideoEncode_Click(object sender, EventArgs e)
        {
            Video video = new Video() { Nome = "video1.wmv" };
            VideoEncode vid = new VideoEncode();
            vid.EncodedDelegate += new Email().EnviarMensagem;
            vid.EncodedDelegate += new Sms().EnviarMensagem;

            vid.Encode(video);
        }
    }
}
