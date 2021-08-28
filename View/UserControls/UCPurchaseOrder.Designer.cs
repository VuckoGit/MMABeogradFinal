
namespace View.UserControls
{
    partial class UCPurchaseOrder
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
            this.btnSavePurchaseOrder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPurchaseOrderItems = new System.Windows.Forms.DataGridView();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txtDateOfReception = new System.Windows.Forms.TextBox();
            this.lblDateofReception = new System.Windows.Forms.Label();
            this.lblReceptionList = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrderItems)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCanceled
            // 
            this.cbCanceled.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCanceled.AutoSize = true;
            this.cbCanceled.Location = new System.Drawing.Point(482, 555);
            this.cbCanceled.Name = "cbCanceled";
            this.cbCanceled.Size = new System.Drawing.Size(89, 21);
            this.cbCanceled.TabIndex = 37;
            this.cbCanceled.Text = "Canceled";
            this.cbCanceled.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Comment:";
            // 
            // txtComment
            // 
            this.txtComment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtComment.Location = new System.Drawing.Point(454, 53);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(187, 74);
            this.txtComment.TabIndex = 34;
            // 
            // cmbManufacturer
            // 
            this.cmbManufacturer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbManufacturer.FormattingEnabled = true;
            this.cmbManufacturer.Location = new System.Drawing.Point(147, 99);
            this.cmbManufacturer.Name = "cmbManufacturer";
            this.cmbManufacturer.Size = new System.Drawing.Size(132, 24);
            this.cmbManufacturer.TabIndex = 33;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(106, 555);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(132, 22);
            this.txtTotal.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 559);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Total";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(22, 101);
            this.lblManufacturer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(96, 17);
            this.lblManufacturer.TabIndex = 30;
            this.lblManufacturer.Text = "Manufacturer:";
            // 
            // btnSavePurchaseOrder
            // 
            this.btnSavePurchaseOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSavePurchaseOrder.Location = new System.Drawing.Point(25, 598);
            this.btnSavePurchaseOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnSavePurchaseOrder.Name = "btnSavePurchaseOrder";
            this.btnSavePurchaseOrder.Size = new System.Drawing.Size(151, 28);
            this.btnSavePurchaseOrder.TabIndex = 29;
            this.btnSavePurchaseOrder.Text = " Save";
            this.btnSavePurchaseOrder.UseVisualStyleBackColor = true;
            this.btnSavePurchaseOrder.Click += new System.EventHandler(this.btnSavePurchaseOrder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.dgvPurchaseOrderItems);
            this.groupBox1.Controls.Add(this.btnRemoveItem);
            this.groupBox1.Controls.Add(this.btnAddItem);
            this.groupBox1.Location = new System.Drawing.Point(14, 149);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(635, 383);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Purchase Odrder Items:";
            // 
            // dgvPurchaseOrderItems
            // 
            this.dgvPurchaseOrderItems.AllowUserToAddRows = false;
            this.dgvPurchaseOrderItems.AllowUserToDeleteRows = false;
            this.dgvPurchaseOrderItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvPurchaseOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseOrderItems.Location = new System.Drawing.Point(11, 68);
            this.dgvPurchaseOrderItems.Name = "dgvPurchaseOrderItems";
            this.dgvPurchaseOrderItems.RowHeadersWidth = 51;
            this.dgvPurchaseOrderItems.RowTemplate.Height = 24;
            this.dgvPurchaseOrderItems.Size = new System.Drawing.Size(601, 308);
            this.dgvPurchaseOrderItems.TabIndex = 3;
            this.dgvPurchaseOrderItems.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchaseOrderItems_CellEndEdit_1);
            this.dgvPurchaseOrderItems.CellErrorTextChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchaseOrderItems_CellErrorTextChanged);
            this.dgvPurchaseOrderItems.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvPurchaseOrderItems_DataError);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveItem.Location = new System.Drawing.Point(148, 33);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(159, 28);
            this.btnRemoveItem.TabIndex = 2;
            this.btnRemoveItem.Text = "Remove item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddItem.Location = new System.Drawing.Point(8, 33);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(132, 28);
            this.btnAddItem.TabIndex = 1;
            this.btnAddItem.Text = "Add item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // txtDateOfReception
            // 
            this.txtDateOfReception.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDateOfReception.Location = new System.Drawing.Point(147, 62);
            this.txtDateOfReception.Margin = new System.Windows.Forms.Padding(4);
            this.txtDateOfReception.Name = "txtDateOfReception";
            this.txtDateOfReception.Size = new System.Drawing.Size(132, 22);
            this.txtDateOfReception.TabIndex = 27;
            // 
            // lblDateofReception
            // 
            this.lblDateofReception.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDateofReception.AutoSize = true;
            this.lblDateofReception.Location = new System.Drawing.Point(22, 62);
            this.lblDateofReception.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateofReception.Name = "lblDateofReception";
            this.lblDateofReception.Size = new System.Drawing.Size(121, 17);
            this.lblDateofReception.TabIndex = 26;
            this.lblDateofReception.Text = "Date of reception:";
            // 
            // lblReceptionList
            // 
            this.lblReceptionList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReceptionList.AutoSize = true;
            this.lblReceptionList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceptionList.Location = new System.Drawing.Point(17, 9);
            this.lblReceptionList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceptionList.Name = "lblReceptionList";
            this.lblReceptionList.Size = new System.Drawing.Size(197, 29);
            this.lblReceptionList.TabIndex = 25;
            this.lblReceptionList.Text = "Purchase Order";
            // 
            // UCPurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbCanceled);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.cmbManufacturer);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblManufacturer);
            this.Controls.Add(this.btnSavePurchaseOrder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDateOfReception);
            this.Controls.Add(this.lblDateofReception);
            this.Controls.Add(this.lblReceptionList);
            this.Name = "UCPurchaseOrder";
            this.Size = new System.Drawing.Size(686, 646);
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
        private System.Windows.Forms.Button btnSavePurchaseOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.TextBox txtDateOfReception;
        private System.Windows.Forms.Label lblDateofReception;
        private System.Windows.Forms.Label lblReceptionList;
        private System.Windows.Forms.DataGridView dgvPurchaseOrderItems;
    }
}
