using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;

namespace _0742Tasks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            //string link = txbLink.Text = "http://www.google.com";

            //WebClient webClient = new WebClient();
            //txtResultado.Text = webClient.DownloadString(link);
            //Uri url = new Uri(link);
            //string task = await webClient.DownloadStringTaskAsync(url);
            //txtResultado.Text = task.ToString();

            txtResultado.Text += Task.Run(() => Metodo1()).Result;
            txtResultado.Text += Task.Run(() => Metodo1()).Result;
            txtResultado.Text += Task.Factory.StartNew(Metodo1).Result;
        }

        string texto = "";
        public string Metodo1()
        {
            for (int i = 0; i < 100; i++) {
                texto += "\n"+i+" - Task: "+Task.CurrentId;
            }
            return texto;
        }
    }
}
