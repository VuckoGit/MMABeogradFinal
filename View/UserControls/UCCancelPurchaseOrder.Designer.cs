
namespace View.UserControls
{
    partial class UCCancelPurchaseOrder
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbCanceled = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.cmbManufacturer = new System.Windows.Forms.ComboBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.btnCancelPurchaseOrder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPurchaseOrderItems = new System.Windows.Forms.DataGridView();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txtDateOfPurchaseOrder = new System.Windows.Forms.TextBox();
            this.lblDateofReception = new System.Windows.Forms.Label();
            this.lbReceptionList = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPurchaseOrderId = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrderItems)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCanceled
            // 
            this.cbCanceled.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCanceled.AutoSize = true;
            this.cbCanceled.Enabled = false;
            this.cbCanceled.Location = new System.Drawing.Point(546, 612);
            this.cbCanceled.Name = "cbCanceled";
            this.cbCanceled.Size = new System.Drawing.Size(89, 21);
            this.cbCanceled.TabIndex = 50;
            this.cbCanceled.Text = "Canceled";
            this.cbCanceled.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 48;
            this.label1.Text = "Comment:";
            // 
            // txtComment
            // 
            this.txtComment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtComment.Enabled = false;
            this.txtComment.Location = new System.Drawing.Point(518, 110);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(187, 74);
            this.txtComment.TabIndex = 47;
            // 
            // cmbManufacturer
            // 
            this.cmbManufacturer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbManufacturer.Enabled = false;
            this.cmbManufacturer.FormattingEnabled = true;
            this.cmbManufacturer.Location = new System.Drawing.Point(211, 156);
            this.cmbManufacturer.Name = "cmbManufacturer";
            this.cmbManufacturer.Size = new System.Drawing.Size(132, 24);
            this.cmbManufacturer.TabIndex = 46;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(170, 612);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(132, 22);
            this.txtTotal.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 616);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "Total";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(86, 158);
            this.lblManufacturer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(96, 17);
            this.lblManufacturer.TabIndex = 43;
            this.lblManufacturer.Text = "Manufacturer:";
            // 
            // btnCancelPurchaseOrder
            // 
            this.btnCancelPurchaseOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelPurchaseOrder.Location = new System.Drawing.Point(89, 655);
            this.btnCancelPurchaseOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelPurchaseOrder.Name = "btnCancelPurchaseOrder";
            this.btnCancelPurchaseOrder.Size = new System.Drawing.Size(151, 28);
            this.btnCancelPurchaseOrder.TabIndex = 42;
            this.btnCancelPurchaseOrder.Text = "Cancel";
            this.btnCancelPurchaseOrder.UseVisualStyleBackColor = true;
            this.btnCancelPurchaseOrder.Click += new System.EventHandler(this.btnCancelPurchaseOrder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.dgvPurchaseOrderItems);
            this.groupBox1.Controls.Add(this.btnRemoveItem);
            this.groupBox1.Controls.Add(this.btnAddItem);
            this.groupBox1.Location = new System.Drawing.Point(78, 206);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(635, 383);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Purchase Odrder Items:";
            // 
            // dgvPurchaseOrderItems
            // 
            this.dgvPurchaseOrderItems.AllowUserToAddRows = false;
            this.dgvPurchaseOrderItems.AllowUserToDeleteRows = false;
            this.dgvPurchaseOrderItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvPurchaseOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseOrderItems.Enabled = false;
            this.dgvPurchaseOrderItems.Location = new System.Drawing.Point(11, 68);
            this.dgvPurchaseOrderItems.Name = "dgvPurchaseOrderItems";
            this.dgvPurchaseOrderItems.RowHeadersWidth = 51;
            this.dgvPurchaseOrderItems.RowTemplate.Height = 24;
            this.dgvPurchaseOrderItems.Size = new System.Drawing.Size(601, 308);
            this.dgvPurchaseOrderItems.TabIndex = 3;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveItem.Enabled = false;
            this.btnRemoveItem.Location = new System.Drawing.Point(148, 33);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(159, 28);
            this.btnRemoveItem.TabIndex = 2;
            this.btnRemoveItem.Text = "Remove item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddItem.Enabled = false;
            this.btnAddItem.Location = new System.Drawing.Point(8, 33);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(132, 28);
            this.btnAddItem.TabIndex = 1;
            this.btnAddItem.Text = "Add item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            // 
            // txtDateOfPurchaseOrder
            // 
            this.txtDateOfPurchaseOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDateOfPurchaseOrder.Enabled = false;
            this.txtDateOfPurchaseOrder.Location = new System.Drawing.Point(211, 119);
            this.txtDateOfPurchaseOrder.Margin = new System.Windows.Forms.Padding(4);
            this.txtDateOfPurchaseOrder.Name = "txtDateOfPurchaseOrder";
            this.txtDateOfPurchaseOrder.Size = new System.Drawing.Size(132, 22);
            this.txtDateOfPurchaseOrder.TabIndex = 40;
            // 
            // lblDateofReception
            // 
            this.lblDateofReception.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDateofReception.AutoSize = true;
            this.lblDateofReception.Location = new System.Drawing.Point(86, 119);
            this.lblDateofReception.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateofReception.Name = "lblDateofReception";
            this.lblDateofReception.Size = new System.Drawing.Size(115, 17);
            this.lblDateofReception.TabIndex = 39;
            this.lblDateofReception.Text = "Date of ordering:";
            // 
            // lbReceptionList
            // 
            this.lbReceptionList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbReceptionList.AutoSize = true;
            this.lbReceptionList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReceptionList.Location = new System.Drawing.Point(81, 41);
            this.lbReceptionList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbReceptionList.Name = "lbReceptionList";
            this.lbReceptionList.Size = new System.Drawing.Size(285, 29);
            this.lbReceptionList.TabIndex = 38;
            this.lbReceptionList.Text = "Cancel Purchase Order";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 52;
            this.label3.Text = "Purchase Order Id:";
            // 
            // txtPurchaseOrderId
            // 
            this.txtPurchaseOrderId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPurchaseOrderId.Enabled = false;
            this.txtPurchaseOrderId.Location = new System.Drawing.Point(211, 86);
            this.txtPurchaseOrderId.Name = "txtPurchaseOrderId";
            this.txtPurchaseOrderId.Size = new System.Drawing.Size(132, 22);
            this.txtPurchaseOrderId.TabIndex = 53;
            // 
            // UCCancelPurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtPurchaseOrderId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCanceled);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.cmbManufacturer);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblManufacturer);
            this.Controls.Add(this.btnCancelPurchaseOrder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDateOfPurchaseOrder);
            this.Controls.Add(this.lblDateofReception);
            this.Controls.Add(this.lbReceptionList);
            this.Name = "UCCancelPurchaseOrder";
            this.Size = new System.Drawing.Size(815, 688);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrderItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbCanceled;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.ComboBox cmbManufacturer;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Button btnCancelPurchaseOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPurchaseOrderItems;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.TextBox txtDateOfPurchaseOrder;
        private System.Windows.Forms.Label lblDateofReception;
        private System.Windows.Forms.Label lbReceptionList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPurchaseOrderId;
    }
}
