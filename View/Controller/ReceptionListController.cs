using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using View.Exceptions;
using View.Helpers;
using View.UserControls;

namespace View.Controller
{
    public class ReceptionListController
    {
        internal ReceptionList receptionList;
        private UCReceptionList ucReceptionList;
        private UCAllReceptionList allReceptionList;
        private UCCancelReceptionList UCCancelReceptionList;
        private BindingList<ReceptionList> receptionLists = new BindingList<ReceptionList>();
        private BindingList<ReceptionListItem> bindingReceptionListItems = new BindingList<ReceptionListItem>();
        internal FRMMain frmMain;

        public ReceptionListController()
        {


        }
        public ReceptionListController(FRMMain frmMain)
        {
            this.frmMain = frmMain;
        }
        public ReceptionListController(FRMMain frmMain, ReceptionList receptionList)
        {
            this.frmMain = frmMain;
            this.receptionList = receptionList;
        }

        internal void InitUCCancelReceptionList(UCCancelReceptionList uCCancelReceptionList)
        {
            this.UCCancelReceptionList = uCCancelReceptionList;
            UCCancelReceptionList.TxtReceptionListId.Text = receptionList.ReceptionListId.ToString();
            UCCancelReceptionList.TxtReceptionListDate.Text = receptionList.ReceptionDate.ToString();
            UCCancelReceptionList.TxtComment.Text = receptionList.Comment;
            UCCancelReceptionList.TxtTotal.Text = receptionList.Total.ToString();
            UCCancelReceptionList.CmbPurchaseOrder.DataSource = Communication.Communication.Instance.GetallPurchaseOrder();
             UCCancelReceptionList.CmbPurchaseOrder.SelectedItem = receptionList.PurchaseOrder;
            UCCancelReceptionList.CmbPurchaseOrder.DisplayMember = "PurchaseOrderId";
            UCCancelReceptionList.CmbManufacturer.DataSource = Communication.Communication.Instance.GetAllManufacuturers();
            UCCancelReceptionList.CmbManufacturer.SelectedItem = receptionList.Manufacturer;
             UCCancelReceptionList.DGVReceptionListItems.DataSource = Communication.Communication.Instance.LoadReceptionListItems(receptionList);
            if (receptionList.Canceled == "Yes")
            {
                UCCancelReceptionList.CbCanceled.Checked = true;
                UCCancelReceptionList.BTNCancel.Enabled = false;
            }
            else
            {
                UCCancelReceptionList.CbCanceled.Checked = false;
            }
           
        }

        internal void InitForm(UCReceptionList uCReceptionList)
        {
            ucReceptionList = uCReceptionList;
            ucReceptionList.TXTReceptionListDate.Text = DateTime.Now.ToString("dd.MM.yyyy. HH:mm");
            ucReceptionList.CMBPurchaseOrder.DataSource = Communication.Communication.Instance.GetallPurchaseOrder();
            ucReceptionList.CMBPurchaseOrder.DisplayMember = "PurchaseOrderId";
            ucReceptionList.CMBManufacturer.DataSource = Communication.Communication.Instance.GetAllManufacuturers();
            InitDataGridView(ucReceptionList.DgvReceptionListItems);
        }



        private void InitDataGridView(DataGridView dgvItems)
        {
            dgvItems.DataSource = bindingReceptionListItems;
            dgvItems.Columns["Amount"].ReadOnly = true;
            dgvItems.Columns["ReceptionListItemId"].ReadOnly = true;
            dgvItems.Columns["ReceptionListId"].Visible = false;
            dgvItems.Columns["Product"].Visible = false;
            DataGridViewComboBoxColumn colProduct = new DataGridViewComboBoxColumn();
            colProduct.DataSource = Communication.Communication.Instance.GetAllProducts();
            colProduct.HeaderText = "Product";
            //!!
            colProduct.DataPropertyName = "Product";
            colProduct.ValueMember = "Self";
            colProduct.DisplayMember = "Name";
            //!!
            dgvItems.Columns.Add(colProduct);
        }

        internal void InitUCAllReceptionList(UCAllReceptionList uCAllReceptionList)
        {
            allReceptionList = uCAllReceptionList;
            try
            {
               allReceptionList.DgvAllReceptionLists.DataSource = Communication.Communication.Instance.GetAllReceptionList();
                allReceptionList.DgvAllReceptionLists.Columns["ReceptionDate"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";

                MessageBox.Show("System loaded list of reception lists");

            }
            catch (SystemOperationException)
            {

                MessageBox.Show("System can't load list of reception lists");

            }
        }
        public void SaveReceptionList()
        {

            if (!UserControlHelpers.EmptyFieldValidation(ucReceptionList.TXTReceptionListDate)
                || !UserControlHelpers.ComboBoxSelectedValidation(ucReceptionList.CMBPurchaseOrder)
                || !UserControlHelpers.ComboBoxSelectedValidation(ucReceptionList.CMBManufacturer)
                || !UserControlHelpers.DateValidation(ucReceptionList.TXTReceptionListDate)
                || !UserControlHelpers.EmptyFieldValidation(ucReceptionList.TXTComment)
                || !UserControlHelpers.DateValidation(ucReceptionList.TXTReceptionListDate)
                || !UserControlHelpers.EmptyFieldValidation(ucReceptionList.TXTTotal)
                || !UserControlHelpers.DoubleFieldValidation(ucReceptionList.TXTTotal)
                || bindingReceptionListItems.Count == 0 || bindingReceptionListItems.Any(rli => rli.Product == null))
            {
                MessageBox.Show("Error! All fields must be filled properly");
                return;
            }
            try
            {


                ReceptionList receptionList = new ReceptionList
                {
                    ReceptionDate = DateTime.ParseExact(ucReceptionList.TXTReceptionListDate.Text, "dd.MM.yyyy. HH:mm", CultureInfo.InvariantCulture),
                    PurchaseOrder = (PurchaseOrder)ucReceptionList.CMBPurchaseOrder.SelectedItem,
                    Manufacturer = (Manufacturer)ucReceptionList.CMBManufacturer.SelectedItem,
                    Comment = ucReceptionList.TXTComment.Text,
                    ReceptionListItems = bindingReceptionListItems.ToList(),

                    Total = double.Parse(ucReceptionList.TXTTotal.Text)

                };
                
                if (ucReceptionList.CBCanceled.Checked)
                {
                    receptionList.Canceled = "Yes";
                }
                else
                {
                    receptionList.Canceled = "No";
                }

                 Communication.Communication.Instance.SaveReceptionList(receptionList);
                MessageBox.Show("System saved reception list!");

            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show("System can't save reception list!\n" + ex.Message);

            }
        }

        internal void AddReceptionListItem()
        {
            bindingReceptionListItems.Add(new ReceptionListItem()
            {
                ReceptionListItemId = bindingReceptionListItems.Count + 1
            });

        }

        internal void UpdateReceptionListItemTotal(int index)
        {
            ReceptionListItem ii = bindingReceptionListItems[index];
            if (ii.Product != null)
            {
                ii.Amount = ii.Quantity * ii.Product.Price;
            }
            double sum = 0;
            ucReceptionList.DgvReceptionListItems.Refresh();
            foreach (ReceptionListItem pi in bindingReceptionListItems)
            {
                sum += pi.Amount;
            }
            ucReceptionList.TXTTotal.Text = $"{sum}";
        }



        internal void RemoveItem(DataGridView dgvItems)
        {
            if (dgvItems.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvItems.SelectedRows[0];
                ReceptionListItem item = (ReceptionListItem)row.DataBoundItem;
                bindingReceptionListItems.Remove(item);
                for (int i = 0; i < bindingReceptionListItems.Count; i++)
                {
                    bindingReceptionListItems[i].ReceptionListItemId = i + 1;
                }
            }
        }

        internal void ChooseReceptionList(DataGridView dgvAllPrurchaseOrders)
        {
            try
            {
                DataGridViewRow row = dgvAllPrurchaseOrders.SelectedRows[0];
                ReceptionList receptionList = (ReceptionList)row.DataBoundItem;
                frmMain.mainController.OpenUCCancelReceptionList(frmMain, receptionList);
                MessageBox.Show($"System found reception list information");

            }
            catch (Exception ex)
            {

                MessageBox.Show("System can't find reception list information ");
                Console.WriteLine(ex.Message);
            }
        }

        internal void Search(TextBox txtSearch)
        {
            if (!UserControlHelpers.EmptyFieldValidation(txtSearch))
            {
                MessageBox.Show("Put a valid search parameter!");

                return;
            }
            try
            {
                allReceptionList.DgvAllReceptionLists.DataSource = Communication.Communication.Instance.SearchReceptionList(txtSearch.Text);


                MessageBox.Show("System find reception lists with searching parameter!");


            }
            catch (SystemOperationException)
            {
                MessageBox.Show("System can't find reception list with searching parameter!");
            }
        }
        internal void CancelReceptionList(UCCancelReceptionList uCCancelReceptionList)
        {
            try
            {
                ReceptionList po = new ReceptionList
                {
                    ReceptionListId = int.Parse(uCCancelReceptionList.TxtReceptionListId.Text)
                };

                Communication.Communication.Instance.CancelReceptionList(po);
                MessageBox.Show("System canceled reception list ");
                


            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show("System can't cancel reception list\n" + ex.Message);
            }
        }



    }
}
