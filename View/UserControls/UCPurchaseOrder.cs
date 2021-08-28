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
    public partial class UCPurchaseOrder : UserControl
    {
        public PurchaseOrderController purchaseOrderController;
        public DataGridView DgvPurchaseOrderItems { get => dgvPurchaseOrderItems; }


        public TextBox TXTPurchaseOrderDate { get => txtDateOfReception; }

        public TextBox TXTComment { get => txtComment; }

        public TextBox TXTTotal { get => txtTotal; }

        public ComboBox CMBManufacturer { get => cmbManufacturer; }

        public CheckBox CBCanceled { get => cbCanceled; }

        public UCPurchaseOrder()
        {
            InitializeComponent();
        }
        public UCPurchaseOrder(PurchaseOrderController purchaseOrderController)
        {
            this.purchaseOrderController = purchaseOrderController;
            InitializeComponent();
           
            cbCanceled.Enabled = false;

            dgvPurchaseOrderItems.CellEndEdit += dgvPurchaseOrderItems_CellEndEdit;
            purchaseOrderController.InitForm(this);
        }
        private void btnSavePurchaseOrder_Click(object sender, EventArgs e)
        {
            purchaseOrderController.SavePurchaseOrder();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            purchaseOrderController.AddPurchaseOrderItem();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            purchaseOrderController.RemoveItem(dgvPurchaseOrderItems);
        }

        private void dgvPurchaseOrderItems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            purchaseOrderController.UpdatePurchaseOrderItemTotal(e.RowIndex);

        }

        private void dgvPurchaseOrderItems_CellErrorTextChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPurchaseOrderItems_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
          //if(e.ColumnIndex == dgvPurchaseOrderItems.Columns["Quantity"].Index)
          //  {
          //      if (!double.TryParse(dgvPurchaseOrderItems.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out _)){
                   
          //      }
          //  }
        }

        private void dgvPurchaseOrderItems_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show($"{dgvPurchaseOrderItems.Columns[e.ColumnIndex].Name} error!");
            
        }
    }
}
