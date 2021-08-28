using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.Controller;
using Domain;

namespace View
{
   public class MainCoordinator
    {
        private MainController mainController = new MainController();
        private LoginController loginController = new LoginController();
        private FRMLogin frmLogin;
        private FRMMain frmMain;
        public User User { get; set; }

        private static MainCoordinator instance;
        private MainCoordinator() { }

        public static MainCoordinator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MainCoordinator();
                }
                return instance;
            }
        }

        public void OpenLoginForm()
        {
            frmLogin = new FRMLogin(loginController);
            frmLogin.Show();
        }

        public void OpenMainForm()
        {

            frmMain = new FRMMain(mainController,User);
            frmMain.Show();
        }
    }


}
