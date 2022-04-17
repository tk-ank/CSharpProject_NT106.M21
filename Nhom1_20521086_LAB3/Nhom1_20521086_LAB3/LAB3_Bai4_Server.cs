using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom1_20521086_LAB3
{
    public partial class LAB3_Bai4_Server : Form
    {
        IPEndPoint IP;
        Socket server;
        List<Socket> clientList;

        //private Thread listenThread;
        //private TcpListener tcpListener;
        //private bool stopChatServer = true;
        //private Dictionary<string, TcpClient> dict = new Dictionary<string, TcpClient>();
        //private string mess;

        public LAB3_Bai4_Server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        void Connect()
        {
            clientList = new List<Socket>();
            IPEndPoint IP = new IPEndPoint(IPAddress.Any, 8080);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            server.Bind(IP);
            Thread Listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(1000);
                        Socket client = server.Accept();
                        clientList.Add(client);
                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start();
                    }
                }
                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, 8080);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }
            });
            Listen.IsBackground = true;
            Listen.Start();
            foreach (Socket item in clientList)
            {
                Send(item);
            }
            AddMessage("Đã kết nối");            
        }

        void Send(Socket client)
        {
            if (client != null)
            {
                client.Send(Serialize("Đã kết nối"));
            }
        }

        void Receive(object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    string ms = (string)Deserialize(data);
                    foreach (Socket Item in clientList)
                    {
                        if (Item != null && Item != client)
                        {
                            Item.Send(Serialize(data));
                        }
                    }
                    AddMessage(ms);
                }
            }
            catch
            {
                clientList.Remove(client);
                client.Close();
            }
        }

        void AddMessage(string s)
        {
            MessageShow.Items.Add(new ListViewItem() { Text = s });
        }

        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj);
            return stream.ToArray();
        }

        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();
            return formatter.Deserialize(stream);
        }

        //public void Listen()
        //{
        //    try
        //    {
        //        tcpListener = new TcpListener(new IPEndPoint(IPAddress.Any, 8080));
        //        tcpListener.Start();
        //        while (!stopChatServer)
        //        {
        //            TcpClient client = tcpListener.AcceptTcpClient();
        //            StreamReader sr = new StreamReader(client.GetStream());
        //            StreamWriter sw = new StreamWriter(client.GetStream());
        //            sw.AutoFlush = true;
        //            string username = sr.ReadLine();
        //            if (username == null)
        //                sw.WriteLine("Enter a UserName");
        //            else if (!dict.ContainsKey(username))
        //            {
        //                Thread clientThread = new Thread(() => ClientRecv(username, client));
        //                dict.Add(username, client);
        //                clientThread.Start();
        //            }
        //            else
        //                sw.WriteLine("UserName already exists");
        //        }
        //    }
        //    catch (SocketException skex)
        //    {
        //        MessageBox.Show(skex.Message);
        //    }
        //}

        //public void ClientRecv(string username, TcpClient tcpClient)
        //{
        //    StreamReader sr = new StreamReader(tcpClient.GetStream());
        //    while (!stopChatServer)
        //    {
        //        Application.DoEvents();
        //        try
        //        {
        //            mess = sr.ReadLine();
        //            string ms = $"{username}[{DateTime.Now:dd/MM/yyyy hh:mm tt}]:{mess}";
        //            foreach (TcpClient otherClient in dict.Values)
        //            {
        //                StreamWriter sw = new StreamWriter(otherClient.GetStream());
        //                sw.WriteLine(ms);
        //                sw.AutoFlush = true;
        //            }
        //            Content.Invoke((MethodInvoker)delegate ()
        //            {
        //                if (ms[ms.Length - 1] == '\n')
        //                    Content.Text += ms.ToString();
        //                else
        //                    Content.Text += ms.ToString() + "\r\n";
        //            });
        //        }
        //        catch (Exception)
        //        {
        //            return;
        //        }
        //    }
        //}

        private void LAB3_Bai4_Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            
            //stopChatServer = false;
            //listenThread = new Thread(new ThreadStart(Listen));
            //listenThread.Start();
            //MessageBox.Show("Listening...");
            btnListen.Enabled = false;
            btnStop.Enabled = true;
            Connect();
        }
    }
}
