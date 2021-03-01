using System;
using System.Windows.Forms;
using System.Net;

namespace Kalkulator_IP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            IPNetwork ipNetwork = IPNetwork.Parse(textBox1.Text + "/" + textBox2.Text);

            ipAddress.Text = textBox1.Text;
            netMask.Text = ipNetwork.Netmask.ToString();
            broadcast.Text = ipNetwork.Broadcast.ToString();
            networkIp.Text = ipNetwork.Network.ToString() + "/" + ipNetwork.Cidr.ToString();
            firstHost.Text = ipNetwork.FirstUsable.ToString();
            lastHost.Text = ipNetwork.LastUsable.ToString();
            hosts.Text = (ipNetwork.Total - 2).ToString();
        }
    }
}
