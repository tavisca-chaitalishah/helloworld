using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApplication
{
    public partial class ChatApplicationWindow : Form
    {
        TcpClient _clientSocket = new TcpClient();
        private string dataToPrint = null;
        NetworkStream serverStream = default(NetworkStream);
        public ChatApplicationWindow()
        {
            InitializeComponent();
        }
        private void _ButtonToConnectToServer_Click(object sender, EventArgs e)
        {
            dataToPrint = "Connected To Chat Application";
            TransferMessageFromClientToServerAndOtherClients();
            _clientSocket.Connect("127.0.0.1", 8080);
            serverStream = _clientSocket.GetStream();
            WriteTextFromTextBox(_nameOfClientTextBox);
            CreateThread();
        }
        private void CreateThread()
        {
            Thread clientThread = new Thread(getMessage);
            clientThread.Start();
        }
        private void getMessage()
        {
            while (true)
            {
                serverStream = _clientSocket.GetStream();
                int bufferSize = _clientSocket.ReceiveBufferSize;
                byte[] inStream = new byte[bufferSize];
                serverStream.Read(inStream, 0, bufferSize);
                dataToPrint = "" + Encoding.ASCII.GetString(inStream);
                TransferMessageFromClientToServerAndOtherClients();
            }
        }

        private void TransferMessageFromClientToServerAndOtherClients()
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(TransferMessageFromClientToServerAndOtherClients));
            else
                _groupConversationTextBox.Text = _groupConversationTextBox.Text + Environment.NewLine + " >> " + dataToPrint;

        }

        private void _SendButton_Click(object sender, EventArgs e)
        {
            WriteTextFromTextBox(_enterMessageTextBox);
        }

        private void WriteTextFromTextBox(TextBox textBox)
        {
            byte[] outStream = Encoding.ASCII.GetBytes(textBox.Text + "$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
        }
    }
}
