using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Exceptions;
using View.Helpers;
using View.UserControls;

namespace View.Controller
{
   public class PurchaseOrderController
    {
        internal PurchaseOrder purchaseOrder;
        private UCPurchaseOrder ucPurchaseOrder;
        private UCAllPurchaseOrder allPurchaseOrder;
        private UCCancelPurchaseOrder UCCancelPurchaseOrder;
        private BindingList<PurchaseOrder> purchaseOrders = new BindingList<PurchaseOrder>();
        private BindingList<PurchaseOrderItem> bindingPurchaseOrderItems = new BindingList<PurchaseOrderItem>();
        internal FRMMain frmMain;
            
        public PurchaseOrderController()
        {
           

        }
        public PurchaseOrderController(FRMMain frmMain)
        {
            this.frmMain = frmMain;
        }
        public PurchaseOrderController(FRMMain frmMain, PurchaseOrder purchaseOrder)
        {
            this.frmMain = frmMain;
            this.purchaseOrder = purchaseOrder;
        }

        internal void InitUCCancelPurchaseOrder(UCCancelPurchaseOrder uCCancelPurchaseOrder)
        {
            this.UCCancelPurchaseOrder = uCCancelPurchaseOrder;
            UCCancelPurchaseOrder.TxtPurchaseOrderId.Text = purchaseOrder.PurchaseOrderId.ToString();
            UCCancelPurchaseOrder.TxtPurchaseOrderDate.Text = purchaseOrder.PurchaseOrderDate.ToString();
            UCCancelPurchaseOrder.TxtComment.Text = purchaseOrder.Comment;
            UCCancelPurchaseOrder.TxtTotal.Text = purchaseOrder.Total.ToString();
            UCCancelPurchaseOrder.CmbManufacturer.DataSource = Communication.Communication.Instance.GetAllManufacuturers();
            UCCancelPurchaseOrder.CmbManufacturer.SelectedItem = purchaseOrder.Manufacturer;
            UCCancelPurchaseOrder.DGVPurchaseOrderItems.DataSource = Communication.Communication.Instance.LoadPurchaseOrderItems(purchaseOrder);
            if (purchaseOrder.Canceled == "Yes")
            {
                UCCancelPurchaseOrder.CbCanceled.Checked = true;
                UCCancelPurchaseOrder.BTNCancel.Enabled = false;
            }
            else
            {
                UCCancelPurchaseOrder.CbCanceled.Checked = false;
            }
           
        }

        internal void InitForm(UCPurchaseOrder uCPurchaseOrder)
        {
            ucPurchaseOrder = uCPurchaseOrder;
            ucPurchaseOrder.TXTPurchaseOrderDate.Text = DateTime.Now.ToString("dd.MM.yyyy. HH:mm");
            ucPurchaseOrder.CMBManufacturer.DataSource = Communication.Communication.Instance.GetAllManufacuturers();
            InitDataGridView(ucPurchaseOrder.DgvPurchaseOrderItems);
        }

       

        private void InitDataGridView(DataGridView dgvItems)
        {
            dgvItems.DataSource = bindingPurchaseOrderItems;
            dgvItems.Columns["Amount"].ReadOnly = true;
            dgvItems.Columns["PurchaseOrderItemId"].ReadOnly = true;
            dgvItems.Columns["PurchaseOrderId"].Visible = false;
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

        internal void InitUCAllPurchaseOrder(UCAllPurchaseOrder uCAllPurchaseOrder)
        {
            allPurchaseOrder = uCAllPurchaseOrder;
            try
            {
                allPurchaseOrder.DgvAllPrurchaseOrders.DataSource = Communication.Communication.Instance.GetallPurchaseOrder();
               allPurchaseOrder.DgvAllPrurchaseOrders.Columns["PurchaseOrderDate"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                MessageBox.Show("System loaded list of purchase orders");

            }
            catch (SystemOperationException)
            {

                MessageBox.Show("System can't load list of purchase orders");

            }
        }
        public void SavePurchaseOrder()
        {

            if (!UserControlHelpers.EmptyFieldValidation(ucPurchaseOrder.TXTPurchaseOrderDate)
                || !UserControlHelpers.ComboBoxSelectedValidation(ucPurchaseOrder.CMBManufacturer)
                || !UserControlHelpers.DateValidation(ucPurchaseOrder.TXTPurchaseOrderDate)
                || !UserControlHelpers.EmptyFieldValidation(ucPurchaseOrder.TXTComment)
                || !UserControlHelpers.DateValidation(ucPurchaseOrder.TXTPurchaseOrderDate)
                || !UserControlHelpers.EmptyFieldValidation(ucPurchaseOrder.TXTTotal)
                || !UserControlHelpers.DoubleFieldValidation(ucPurchaseOrder.TXTTotal)
                || bindingPurchaseOrderItems.Count == 0 || bindingPurchaseOrderItems.Any(poi => poi.Product== null))
            {
                MessageBox.Show("Error! All fields must be filled properly");
                return;
            }
            try
            {
         
                PurchaseOrder purchaseOrder = new PurchaseOrder
                {
                    PurchaseOrderDate = DateTime.ParseExact(ucPurchaseOrder.TXTPurchaseOrderDate.Text, "dd.MM.yyyy. HH:mm", CultureInfo.InvariantCulture),
                    Manufacturer = (Manufacturer)ucPurchaseOrder.CMBManufacturer.SelectedItem,
                    Comment = ucPurchaseOrder.TXTComment.Text,

                    PurchaseOrderItems = bindingPurchaseOrderItems.ToList(),
                   
                    Total = double.Parse(ucPurchaseOrder.TXTTotal.Text)
               
                };
                
                if (ucPurchaseOrder.CBCanceled.Checked)
                {
                    purchaseOrder.Canceled = "Yes";
                }
                else
                {
                    purchaseOrder.Canceled = "No";
                }

                Communication.Communication.Instance.SavePurchaseOrder(purchaseOrder);
                MessageBox.Show("System saved purchase order!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show("System can't save purchase order!\n" + ex.Message);
                
            }
        }

        internal void AddPurchaseOrderItem()
        {
            bindingPurchaseOrderItems.Add(new PurchaseOrderItem()
            {
                PurchaseOrderItemId = bindingPurchaseOrderItems.Count + 1
            });  
          
        }

        internal void UpdatePurchaseOrderItemTotal(int index)
        {
            PurchaseOrderItem ii = bindingPurchaseOrderItems[index];
            if (ii.Product != null)
            {
                ii.Amount = ii.Quantity * ii.Product.Price;
            }
            double sum = 0;
            ucPurchaseOrder.DgvPurchaseOrderItems.Refresh();
            foreach(PurchaseOrderItem pi in bindingPurchaseOrderItems) {
                sum += pi.Amount;
            }
            ucPurchaseOrder.TXTTotal.Text = $"{sum}";
        }

        
       
        internal void RemoveItem(DataGridView dgvItems)
        {
            if (dgvItems.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvItems.SelectedRows[0];
                PurchaseOrderItem item = (PurchaseOrderItem)row.DataBoundItem;
                bindingPurchaseOrderItems.Remove(item);
                for (int i = 0; i < bindingPurchaseOrderItems.Count; i++)
                {
                    bindingPurchaseOrderItems[i].PurchaseOrderItemId = i + 1;
                }
            }
        }

        internal void ChoosePurchaseOrder(DataGridView dgvAllPrurchaseOrders)
        {
            try
            {
                DataGridViewRow row = dgvAllPrurchaseOrders.SelectedRows[0];
                PurchaseOrder purchaseOrder = (PurchaseOrder)row.DataBoundItem;
                frmMain.mainController.OpenUCCancelPurchaseOrder(frmMain, purchaseOrder);
                MessageBox.Show($"System found purchase order information");
            }
            catch (Exception ex)
            {

                MessageBox.Show("System can't find purchase order information ");
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
                allPurchaseOrder.DgvAllPrurchaseOrders.DataSource = Communication.Communication.Instance.SearchPurchaseOrder(txtSearch.Text);
                

                MessageBox.Show("System find purchase orders with searching parameter!");


            }
            catch (SystemOperationException)
            {
                MessageBox.Show("System can't find purchase order with searching parameter!");
            }
        }
        internal void CancelPurchaseOrder(UCCancelPurchaseOrder uCCancelPurchaseOrder)
        {
             try
                {
                    PurchaseOrder po = new PurchaseOrder
                    {
                        PurchaseOrderId = int.Parse(uCCancelPurchaseOrder.TxtPurchaseOrderId.Text)
                    };

                    Communication.Communication.Instance.CancelPurchaseOrder(po);
                    MessageBox.Show("System canceled purchase order");


            }
            catch (SystemOperationException ex)
                {
                MessageBox.Show("System can't cancel purchase order" + ex.Message);
                }
            }
    }
}
