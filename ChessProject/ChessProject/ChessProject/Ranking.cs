using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessProject
{
    public partial class Ranking : Form
    {
        public Ranking()
        {
            InitializeComponent();
        }

        private async void Ranking_Load(object sender, EventArgs e)
        {
            if (Login.username.Length == 0)
            {
                return;
            }
            string sendString = Login.username;
            List<byte> fullPackage = new List<byte>();
            fullPackage.Add(0);
            fullPackage.Add(7);
            fullPackage.AddRange(Encoding.UTF8.GetBytes(sendString));
            Login.clientSocket.Send(fullPackage.ToArray());

            byte[] recvBytes = new byte[300];

            await Task.Run(() =>
            {
                //trycatch
                Login.clientSocket.Receive(recvBytes, 0, 300, System.Net.Sockets.SocketFlags.None);
            });

            if (recvBytes[0] != 0)
            {
                string recvData = Encoding.UTF8.GetString(recvBytes, 0, recvBytes.Length).Trim();
                string[] stringArr = recvData.Split(' ');
                lblTop1.Text = stringArr[0];
                lblTop2.Text = stringArr[2];
                lblTop3.Text = stringArr[4];
                lblCurUser.Text = stringArr[6];
                lblUserPoint.Text = stringArr[7];
                lblUserRank.Text = stringArr[8];
            }
            else
            {
                MessageBox.Show("Load bảng xếp hạng thất bại!");
                return;
            }
        }
    }
}
