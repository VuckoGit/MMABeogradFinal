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

namespace Server
{
    public partial class FRMServer : Form
    {

        private Server s;
        public FRMServer()
        {
            InitializeComponent();
        }
        private void FRMServer_Load_1(object sender, EventArgs e)
        {
            brnStart.Enabled = true;
            btnStop.Enabled = false;
          
        }
    
        private void brnStart_Click(object sender, EventArgs e)
        {
            try
            {
                s = new Server();
                s.Start();
                Thread thread = new Thread(s.Listen);
                thread.IsBackground = true;
                thread.Start();
                brnStart.Enabled = false;
                btnStop.Enabled = true;
                s.Users.ListChanged += Users_ListChanged;
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Users_ListChanged(object sender, ListChangedEventArgs e)
        {
           
            dgvClient.Invoke(new Action(() => dgvClient.DataSource = s.Users.ToList()));
           
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
          
          
                s.Stop();
          
                brnStart.Enabled = true;
                btnStop.Enabled = false;
           

        }

        private void FRMServer_FormClosed_1(object sender, FormClosedEventArgs e)
        {
           //  Environment.Exit(0);

        }

        
    }
}
