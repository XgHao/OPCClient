using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPCClient
{
    public partial class FrmClient : Form
    {
        public FrmClient()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 刷新节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            IPHostEntry iPHostEntry = Dns.GetHostEntry(Environment.MachineName);
            var iplist = iPHostEntry.AddressList.Where(ip => ip.AddressFamily == AddressFamily.InterNetwork).ToList();
            cbB_SvrNode.DataSource = iplist;
        }
    }
}
