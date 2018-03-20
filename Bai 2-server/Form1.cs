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

namespace Bai02_Server
{
    public partial class Form1 : Form
    {
        Socket newsock;
        Socket client;
        IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 9050);
        IPEndPoint clientep;
        EndPoint ep;
        byte[] data;
        string k = "0";
        string b = "1";
        string ba = "2";
        public Form1()
        {
            InitializeComponent();
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
        private void Form1_Load(object sender, EventArgs e)
        {
            newsock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            newsock.Bind(ipep);
            ep = ipep;
        }

        private void btnKeo_Click(object sender, EventArgs e)
        {
            txtSelection.Text = btnKeo.Text;
            data = new byte[1024];
            int rec = newsock.ReceiveFrom(data, ref ep);
            string stringData = Encoding.UTF8.GetString(data, 0, rec);
            int i = XuLyKetQuaKEO(stringData, k, b, ba);
            if (i == 0)
                txtResult.Text = "Hoa";
            else if (i == -1)
                txtResult.Text = "Thua";
            else
                txtResult.Text = "Thang";
            //data = Encoding.UTF8.GetBytes(k);
            newsock.SendTo(Encoding.UTF8.GetBytes(k), ep);
        }

        private void btnBua_Click(object sender, EventArgs e)
        {
            txtSelection.Text = btnBua.Text;
            data = new byte[1024];
            int rec = newsock.ReceiveFrom(data, ref ep);
            string stringData = Encoding.UTF8.GetString(data, 0, rec);
            int i = XuLyKetQuaBUA(stringData, k, b, ba);
            if (i == 0)
                txtResult.Text = "Hoa";
            else if (i == -1)
                txtResult.Text = "Thua";
            else
                txtResult.Text = "Thang";
            // byte[] gui = Encoding.UTF8.GetBytes(b);
            newsock.SendTo(Encoding.UTF8.GetBytes(b), ep);
        }

        private void btnBao_Click(object sender, EventArgs e)
        {
            txtSelection.Text = btnBao.Text;
            data = new byte[1024];
            int rec = newsock.ReceiveFrom(data, ref ep);
            string stringData = Encoding.UTF8.GetString(data, 0, rec);
            int i = XuLyKetQuaBAO(stringData, k, b, ba);
            if (i == 0)
                txtResult.Text = "Hoa";
            else if (i == -1)
                txtResult.Text = "Thua";
            else
                txtResult.Text = "Thang";
            //byte[] gui = Encoding.UTF8.GetBytes(ba);
            newsock.SendTo(Encoding.UTF8.GetBytes(ba), ep);
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            newsock.Close();
        }
    }
}
