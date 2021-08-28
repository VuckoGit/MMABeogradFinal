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

namespace View.UserControls
{
    public partial class UCCancelReceptionList : UserControl
    {
        private ReceptionListController  receptionListController;
        public TextBox TxtReceptionListId { get { return txtReceptionListId; } }
        public TextBox TxtReceptionListDate { get { return txtDateOfReception; } }
        public TextBox TxtTotal { get { return txtTotal; } }
        public TextBox TxtComment { get { return txtComment; } }
        public ComboBox CmbPurchaseOrder { get { return cmbPurchaseOrder; } }
        public ComboBox CmbManufacturer { get { return cmbManufacturer; } }

        public CheckBox CbCanceled { get { return cbCanceled; } }
        public DataGridView DGVReceptionListItems { get => dgvReceptionListItems; }
        public Button BTNCancel { get => btnCancelPurchaseOrder; }
        public UCCancelReceptionList(ReceptionListController receptionListController)
        {
            InitializeComponent();

            this.receptionListController = receptionListController;
            receptionListController.InitUCCancelReceptionList(this);

        }


        private void btnCancelPurchaseOrder_Click(object sender, EventArgs e)
        {
            receptionListController.CancelReceptionList(this);
            receptionListController.frmMain.mainController.OpenUCAllReceptionList(receptionListController.frmMain);

        }
    }
}
