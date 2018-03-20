using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace Bai02_Client
{
    public partial class Form1 : Form
    {
        Socket client;
        IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9050);
        EndPoint ep;
        byte[] nhan = new byte[1024];
        string k = "0";
        string b = "1";
        string ba = "2";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            ep = ipep;
        }
        static int XuLyKetQuaKEO(string client, string keo, string bua, string bao)
        {
            if (client == keo)
                return 0;
            else if (client == bua)
                return -1;
            return 1;
        }
        static int XuLyKetQuaBUA(string client, string keo, string bua, string bao)
        {
            if (client == bua)
                return 0;
            else if (client == bao)
                return -1;
            return 1;
        }

        static int XuLyKetQuaBAO(string client, string keo, string bua, string bao)
        {
            if (client == bao)
                return 0;
            else if (client == keo)
                return -1;
            return 1;
        }
        public void XuLyServerTraVe(string s)
        {
            if (s == "0")
                txtServer.Text = "Keo";
            else if (s == "1")
                txtServer.Text = "Bua";
            else
                txtServer.Text = "Bao";
        }
        private void btnKeo_Click(object sender, EventArgs e)
        {
            txtSelection.Text = btnKeo.Text;
            client.SendTo(Encoding.ASCII.GetBytes(k), ep);
            nhan = new byte[1024];
            int rec = client.ReceiveFrom(nhan, ref ep);
            string stringData = Encoding.UTF8.GetString(nhan, 0, rec);
            int i = XuLyKetQuaKEO(stringData, k, b, ba);
            if (i == 0)
                txtResult.Text = "Hoa";
            else if (i == -1)
                txtResult.Text = "Thua";
            else
                txtResult.Text = "Thang";
            XuLyServerTraVe(stringData);
        }

        private void btnBua_Click(object sender, EventArgs e)
        {
            txtSelection.Text = btnBua.Text;
            client.SendTo(Encoding.ASCII.GetBytes(b), ep);
            nhan = new byte[1024];
            int rec = client.ReceiveFrom(nhan, ref ep);
            string stringData = Encoding.UTF8.GetString(nhan, 0, rec);
            int i = XuLyKetQuaBUA(stringData, k, b, ba);
            if (i == 0)
                txtResult.Text = "Hoa";
            else if (i == -1)
                txtResult.Text = "Thua";
            else
                txtResult.Text = "Thang";
            XuLyServerTraVe(stringData);
        }

        private void btnBao_Click(object sender, EventArgs e)
        {
            txtSelection.Text = btnBao.Text;
            client.SendTo(Encoding.ASCII.GetBytes(ba), ep);
            nhan = new byte[1024];
            int rec = client.ReceiveFrom(nhan, ref ep);
            string stringData = Encoding.UTF8.GetString(nhan, 0, rec);
            int i = XuLyKetQuaBAO(stringData, k, b, ba);
            if (i == 0)
                txtResult.Text = "Hoa";
            else if (i == -1)
                txtResult.Text = "Thua";
            else
                txtResult.Text = "Thang";
            XuLyServerTraVe(stringData);
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            client.Close();
        }
    }
}
