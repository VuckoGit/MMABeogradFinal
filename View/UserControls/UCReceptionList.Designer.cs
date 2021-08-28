
namespace View.UserControls
{
    partial class UCReceptionList
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
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveReceptionList = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.dgvReceptionListItems = new System.Windows.Forms.DataGridView();
            this.txtDateOfReception = new System.Windows.Forms.TextBox();
            this.lblDateofReception = new System.Windows.Forms.Label();
            this.lblReceptionList = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.cmbManufacturer = new System.Windows.Forms.ComboBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCanceled = new System.Windows.Forms.CheckBox();
            this.cmbPurchaseOrder = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceptionListItems)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(112, 603);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(132, 22);
            this.txtTotal.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 607);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Total";
            // 
            // btnSaveReceptionList
            // 
            this.btnSaveReceptionList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveReceptionList.Location = new System.Drawing.Point(31, 646);
            this.btnSaveReceptionList.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveReceptionList.Name = "btnSaveReceptionList";
            this.btnSaveReceptionList.Size = new System.Drawing.Size(151, 28);
            this.btnSaveReceptionList.TabIndex = 13;
            this.btnSaveReceptionList.Text = " Save";
            this.btnSaveReceptionList.UseVisualStyleBackColor = true;
            this.btnSaveReceptionList.Click += new System.EventHandler(this.btnSaveReceptionList_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnRemoveItem);
            this.groupBox1.Controls.Add(this.btnAddItem);
            this.groupBox1.Controls.Add(this.dgvReceptionListItems);
            this.groupBox1.Location = new System.Drawing.Point(20, 197);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(635, 383);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reception List Items:";
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
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click_1);
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
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click_1);
            // 
            // dgvReceptionListItems
            // 
            this.dgvReceptionListItems.AllowUserToAddRows = false;
            this.dgvReceptionListItems.AllowUserToDeleteRows = false;
            this.dgvReceptionListItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvReceptionListItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceptionListItems.Location = new System.Drawing.Point(8, 69);
            this.dgvReceptionListItems.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReceptionListItems.Name = "dgvReceptionListItems";
            this.dgvReceptionListItems.RowHeadersWidth = 51;
            this.dgvReceptionListItems.Size = new System.Drawing.Size(619, 297);
            this.dgvReceptionListItems.TabIndex = 0;
            this.dgvReceptionListItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReceptionListItems_CellContentClick);
            this.dgvReceptionListItems.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReceptionListItems_CellEndEdit_1);
            this.dgvReceptionListItems.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvReceptionListItems_DataError);
            // 
            // txtDateOfReception
            // 
            this.txtDateOfReception.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDateOfReception.Location = new System.Drawing.Point(153, 110);
            this.txtDateOfReception.Margin = new System.Windows.Forms.Padding(4);
            this.txtDateOfReception.Name = "txtDateOfReception";
            this.txtDateOfReception.Size = new System.Drawing.Size(132, 22);
            this.txtDateOfReception.TabIndex = 11;
            // 
            // lblDateofReception
            // 
            this.lblDateofReception.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDateofReception.AutoSize = true;
            this.lblDateofReception.Location = new System.Drawing.Point(28, 110);
            this.lblDateofReception.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateofReception.Name = "lblDateofReception";
            this.lblDateofReception.Size = new System.Drawing.Size(121, 17);
            this.lblDateofReception.TabIndex = 10;
            this.lblDateofReception.Text = "Date of reception:";
            // 
            // lblReceptionList
            // 
            this.lblReceptionList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReceptionList.AutoSize = true;
            this.lblReceptionList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceptionList.Location = new System.Drawing.Point(23, 18);
            this.lblReceptionList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceptionList.Name = "lblReceptionList";
            this.lblReceptionList.Size = new System.Drawing.Size(180, 29);
            this.lblReceptionList.TabIndex = 9;
            this.lblReceptionList.Text = "Reception List";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(28, 149);
            this.lblManufacturer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(96, 17);
            this.lblManufacturer.TabIndex = 14;
            this.lblManufacturer.Text = "Manufacturer:";
            // 
            // cmbManufacturer
            // 
            this.cmbManufacturer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbManufacturer.FormattingEnabled = true;
            this.cmbManufacturer.Location = new System.Drawing.Point(153, 147);
            this.cmbManufacturer.Name = "cmbManufacturer";
            this.cmbManufacturer.Size = new System.Drawing.Size(132, 24);
            this.cmbManufacturer.TabIndex = 18;
            // 
            // txtComment
            // 
            this.txtComment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtComment.Location = new System.Drawing.Point(460, 62);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(187, 74);
            this.txtComment.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Comment:";
            // 
            // cbCanceled
            // 
            this.cbCanceled.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCanceled.AutoSize = true;
            this.cbCanceled.Location = new System.Drawing.Point(488, 603);
            this.cbCanceled.Name = "cbCanceled";
            this.cbCanceled.Size = new System.Drawing.Size(89, 21);
            this.cbCanceled.TabIndex = 22;
            this.cbCanceled.Text = "Canceled";
            this.cbCanceled.UseVisualStyleBackColor = true;
            // 
            // cmbPurchaseOrder
            // 
            this.cmbPurchaseOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbPurchaseOrder.FormattingEnabled = true;
            this.cmbPurchaseOrder.Location = new System.Drawing.Point(153, 70);
            this.cmbPurchaseOrder.Name = "cmbPurchaseOrder";
            this.cmbPurchaseOrder.Size = new System.Drawing.Size(132, 24);
            this.cmbPurchaseOrder.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Purchase order: ";
            // 
            // UCReceptionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbPurchaseOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCanceled);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.cmbManufacturer);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblManufacturer);
            this.Controls.Add(this.btnSaveReceptionList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDateOfReception);
            this.Controls.Add(this.lblDateofReception);
            this.Controls.Add(this.lblReceptionList);
            this.Name = "UCReceptionList";
            this.Size = new System.Drawing.Size(722, 685);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceptionListItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaveReceptionList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.DataGridView dgvReceptionListItems;
        private System.Windows.Forms.TextBox txtDateOfReception;
        private System.Windows.Forms.Label lblDateofReception;
        private System.Windows.Forms.Label lblReceptionList;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.ComboBox cmbManufacturer;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbCanceled;
        private System.Windows.Forms.ComboBox cmbPurchaseOrder;
        private System.Windows.Forms.Label label3;
    }
}
