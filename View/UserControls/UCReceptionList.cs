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
    public partial class UCReceptionList : UserControl
    {
        public ReceptionListController receptionListController;
        public DataGridView DgvReceptionListItems { get => dgvReceptionListItems; }

        public TextBox TXTReceptionListDate { get => txtDateOfReception; }

        public TextBox TXTComment { get => txtComment; }

        public TextBox TXTTotal { get => txtTotal; }

        public ComboBox CMBManufacturer { get => cmbManufacturer; }
        public ComboBox CMBPurchaseOrder { get => cmbPurchaseOrder; }

        public CheckBox CBCanceled { get => cbCanceled; }

        public UCReceptionList()
        {
            InitializeComponent();
        }
        public UCReceptionList(ReceptionListController receptionListController)
        {
            this.receptionListController = receptionListController;
            InitializeComponent();
           
            cbCanceled.Enabled = false;
            dgvReceptionListItems.CellEndEdit += dgvReceptionListItems_CellEndEdit_1;
            receptionListController.InitForm(this);
        }
        private void btnSaveReceptionList_Click(object sender, EventArgs e)
        {
            receptionListController.SaveReceptionList();
        }

        
        private void btnAddItem_Click_1(object sender, EventArgs e)
        {
            receptionListController.AddReceptionListItem();
        }

        private void btnRemoveItem_Click_1(object sender, EventArgs e)
        {
            receptionListController.RemoveItem(dgvReceptionListItems);
        }

        private void dgvReceptionListItems_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
            receptionListController.UpdateReceptionListItemTotal(e.RowIndex);
        }

        private void dgvReceptionListItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvReceptionListItems_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show($"{dgvReceptionListItems.Columns[e.ColumnIndex].Name} error!");

        }
    }
}
