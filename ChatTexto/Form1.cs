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
using System.Net.Sockets;


namespace ChatTexto
{
    public partial class Form1 : Form
    {

        Socket sock;
        EndPoint local, remoto;
        byte[] buffer;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Ajustando Socket
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            sock.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            //Pegar ip

            txtIPMeu.Text = RetornaIPLocal();
            txtIPOutro.Text = RetornaIPLocal();



        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            //Binda o socket

            local = new IPEndPoint(IPAddress.Parse(txtIPMeu.Text), Convert.ToInt32(txtPortaMeu.Text));
            sock.Bind(local);

            //Conecta com o IP remoto
            remoto = new IPEndPoint(IPAddress.Parse(txtIPOutro.Text), Convert.ToInt32(txtPortaOutro.Text));
            sock.Connect(remoto);

            //Porta
            buffer = new byte[1500];
            sock.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref remoto, new AsyncCallback(MessageCallBack), buffer);

        }

        private void MessageCallBack(IAsyncResult resultado)
        {
            try
            {
                byte[] dadosRecebidos = new byte[1500];
                dadosRecebidos = (byte[])resultado.AsyncState;

                //Convertendo byte para string
                ASCIIEncoding enconde = new ASCIIEncoding();
                string mensagemRecebida = enconde.GetString(dadosRecebidos);

                //Adicionando na caixa de texto para ver
                lstChat.Items.Add(DateTime.Now.ToString("H:mm:ss") + " Amiguinho: " + mensagemRecebida);

                buffer = new byte[1500];
                sock.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref remoto, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            //Converte a mensagem em string para byte[]

            ASCIIEncoding enconde = new ASCIIEncoding();
            byte[] mandaMensagem = new byte[1500];
            mandaMensagem = enconde.GetBytes(txtEnviar.Text);

            //Enviando a mensagem encodada
            sock.Send(mandaMensagem);

            //Acrescenta na caixa de texto
            lstChat.Items.Add(DateTime.Now.ToString("H:mm:ss") + " Eu: " + txtEnviar.Text);
            txtEnviar.Text = "";
        }

        private string RetornaIPLocal()
        {
            IPHostEntry host;

            host = Dns.GetHostEntry(Dns.GetHostName());
            
            foreach(IPAddress ip in host.AddressList)
            {
                if(ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }


            return "127.0.0.1";
        }




    }
}
