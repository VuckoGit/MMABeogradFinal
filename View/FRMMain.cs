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
using Domain;
namespace View
{
    public partial class FRMMain : Form
    {
        internal readonly MainController mainController;

        public FRMMain(MainController mainController,User user)
        {
            InitializeComponent();
            this.mainController = mainController;
            lblWelcome.Text = $"Welcome, {user.Username}";
        }

        public void SetPanel(UserControl userControl)
        {
            pnlMainContainer.Controls.Clear();
            userControl.Parent = pnlMainContainer;
            userControl.Dock = DockStyle.Fill;

        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCProduct(this);
        }
        private void AddNewmanufacturerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCManufacturer(this);
        }

        private void FRMMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainController.CloseMainForm();
        }

        private void searchProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCAllProducts(this);

        }

        private void editProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCAllProducts(this);
        }


        private void addNewPurchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCPurchaseOrder(this);
        }

        private void searchPurchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCAllPurchaseOrder(this);
        }

        private void cancelationPurchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCAllPurchaseOrder(this);
        }

        private void addNewReceprionListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCReceptionList(this);
        }

        private void searchReceptionListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCAllReceptionList(this);
        }

        private void cancelationOfReceptionListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainController.OpenUCAllReceptionList(this);
        }
    }
}
