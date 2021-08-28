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
    public partial class UCCancelPurchaseOrder : UserControl
    {
        private PurchaseOrderController purchaseOrderController;
        public TextBox TxtPurchaseOrderId { get { return txtPurchaseOrderId; } }
        public TextBox TxtPurchaseOrderDate { get { return txtDateOfPurchaseOrder; } }
        public TextBox TxtTotal { get { return txtTotal; } }
        public TextBox TxtComment { get { return txtComment; } }
        public ComboBox CmbManufacturer { get { return cmbManufacturer; }  }
        public Button BTNCancel { get => btnCancelPurchaseOrder; }
        public CheckBox CbCanceled { get { return cbCanceled; } }
        public DataGridView DGVPurchaseOrderItems { get => dgvPurchaseOrderItems; }

        public UCCancelPurchaseOrder(PurchaseOrderController purchaseOrderController)
        {
            InitializeComponent();

            this.purchaseOrderController = purchaseOrderController;
            purchaseOrderController.InitUCCancelPurchaseOrder(this);
            

        }

       

        private void btnCancelPurchaseOrder_Click(object sender, EventArgs e)
        {
            purchaseOrderController.CancelPurchaseOrder(this);
            purchaseOrderController.frmMain.mainController.OpenUCAllPurchaseOrder(purchaseOrderController.frmMain);

        }
    }
}
