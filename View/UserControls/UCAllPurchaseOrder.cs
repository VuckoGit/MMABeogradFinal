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
    public partial class UCAllPurchaseOrder : UserControl
    {
        private PurchaseOrderController purchaseOrderController;
        public DataGridView DgvAllPrurchaseOrders { get => dgvAllPrurchaseOrders; }
        public UCAllPurchaseOrder()
        {
            InitializeComponent();
        }
        public UCAllPurchaseOrder(PurchaseOrderController purchaseOrderController)
        {
            InitializeComponent();
            this.purchaseOrderController = purchaseOrderController;
            purchaseOrderController.InitUCAllPurchaseOrder(this);
        }

        private void dgvAllPrurchaseOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            purchaseOrderController.ChoosePurchaseOrder(DgvAllPrurchaseOrders);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            purchaseOrderController.Search(txtSearch);

        }


    }
}
