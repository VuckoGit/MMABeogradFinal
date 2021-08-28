using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Exceptions;
using View.Helpers;

namespace View.Controller
{
    public class LoginController
    {
        internal void Login(TextBox txtUsername, TextBox txtPassword, FRMLogin FRMLogin)
        {
            if (!UserControlHelpers.
                EmptyFieldValidation(txtUsername)
                | !UserControlHelpers.EmptyFieldValidation(txtPassword))
            {
                return;
            }
            try
            {
                User k = Communication.Communication.Instance.Login(txtUsername.Text, txtPassword.Text);
                if (k == null)
                {
                    MessageBox.Show($"This user does not exist");
                    return;
                }
                
                MainCoordinator.Instance.User = k;
                MessageBox.Show($"User: {k.FirstName} {k.LastName} successfully connected!");
                MainCoordinator.Instance.OpenMainForm();
                FRMLogin.Dispose();
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal bool Connect()
        {
            try
            {
                Communication.Communication.Instance.Connect();
                return true;
            }
            catch (SocketException)
            {
                MessageBox.Show("Error connecting to server!");
                return false;
            }
        }


    }
}
