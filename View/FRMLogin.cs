using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Controller;

namespace View
{
    public partial class FRMLogin : Form
    {
        private LoginController loginController;
        
        public FRMLogin()
        {
           
            InitializeComponent();
            txtUsername.Text = "luka";
            txtPassword.Text = "luka";
            

        }

        public FRMLogin(LoginController loginController)
        {
            this.loginController = loginController;
            InitializeComponent();
            txtUsername.Text = "luka";
            txtPassword.Text = "luka";
        }

       

        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (loginController.Connect())
                loginController.Login(txtUsername, txtPassword, this);
        }

        private void FRMLogin_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
