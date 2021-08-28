
namespace View.UserControls
{
    partial class UCCancelReceptionList
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
            this.txtReceptionListId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCanceled = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.cmbManufacturer = new System.Windows.Forms.ComboBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.btnCancelPurchaseOrder = new System.Windows.Forms.Button();
            this.txtDateOfReception = new System.Windows.Forms.TextBox();
            this.lblDateofReception = new System.Windows.Forms.Label();
            this.lblReceptionList = new System.Windows.Forms.Label();
            this.dgvReceptionListItems = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbPurchaseOrder = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceptionListItems)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtReceptionListId
            // 
            this.txtReceptionListId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtReceptionListId.Enabled = false;
            this.txtReceptionListId.Location = new System.Drawing.Point(163, 58);
            this.txtReceptionListId.Name = "txtReceptionListId";
            this.txtReceptionListId.Size = new System.Drawing.Size(132, 22);
            this.txtReceptionListId.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 67;
            this.label3.Text = "Reception List Id:";
            // 
            // cbCanceled
            // 
            this.cbCanceled.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCanceled.AutoSize = true;
            this.cbCanceled.Enabled = false;
            this.cbCanceled.Location = new System.Drawing.Point(501, 584);
            this.cbCanceled.Name = "cbCanceled";
            this.cbCanceled.Size = new System.Drawing.Size(89, 21);
            this.cbCanceled.TabIndex = 66;
            this.cbCanceled.Text = "Canceled";
            this.cbCanceled.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 64;
            this.label1.Text = "Comment:";
            // 
            // txtComment
            // 
            this.txtComment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtComment.Enabled = false;
            this.txtComment.Location = new System.Drawing.Point(473, 82);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(187, 74);
            this.txtComment.TabIndex = 63;
            // 
            // cmbManufacturer
            // 
            this.cmbManufacturer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbManufacturer.Enabled = false;
            this.cmbManufacturer.FormattingEnabled = true;
            this.cmbManufacturer.Location = new System.Drawing.Point(163, 147);
            this.cmbManufacturer.Name = "cmbManufacturer";
            this.cmbManufacturer.Size = new System.Drawing.Size(132, 24);
            this.cmbManufacturer.TabIndex = 62;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(125, 584);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(132, 22);
            this.txtTotal.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 588);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 60;
            this.label2.Text = "Total";
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
            // lblManufacturer
            // 
            this.lblManufacturer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(38, 149);
            this.lblManufacturer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(96, 17);
            this.lblManufacturer.TabIndex = 59;
            this.lblManufacturer.Text = "Manufacturer:";
            // 
            // btnCancelPurchaseOrder
            // 
            this.btnCancelPurchaseOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelPurchaseOrder.Location = new System.Drawing.Point(44, 627);
            this.btnCancelPurchaseOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelPurchaseOrder.Name = "btnCancelPurchaseOrder";
            this.btnCancelPurchaseOrder.Size = new System.Drawing.Size(151, 28);
            this.btnCancelPurchaseOrder.TabIndex = 58;
            this.btnCancelPurchaseOrder.Text = "Cancel";
            this.btnCancelPurchaseOrder.UseVisualStyleBackColor = true;
            this.btnCancelPurchaseOrder.Click += new System.EventHandler(this.btnCancelPurchaseOrder_Click);
            // 
            // txtDateOfReception
            // 
            this.txtDateOfReception.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDateOfReception.Enabled = false;
            this.txtDateOfReception.Location = new System.Drawing.Point(163, 118);
            this.txtDateOfReception.Margin = new System.Windows.Forms.Padding(4);
            this.txtDateOfReception.Name = "txtDateOfReception";
            this.txtDateOfReception.Size = new System.Drawing.Size(132, 22);
            this.txtDateOfReception.TabIndex = 56;
            // 
            // lblDateofReception
            // 
            this.lblDateofReception.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDateofReception.AutoSize = true;
            this.lblDateofReception.Location = new System.Drawing.Point(38, 119);
            this.lblDateofReception.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateofReception.Name = "lblDateofReception";
            this.lblDateofReception.Size = new System.Drawing.Size(121, 17);
            this.lblDateofReception.TabIndex = 55;
            this.lblDateofReception.Text = "Date of reception:";
            // 
            // lblReceptionList
            // 
            this.lblReceptionList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReceptionList.AutoSize = true;
            this.lblReceptionList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceptionList.Location = new System.Drawing.Point(36, 13);
            this.lblReceptionList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceptionList.Name = "lblReceptionList";
            this.lblReceptionList.Size = new System.Drawing.Size(268, 29);
            this.lblReceptionList.TabIndex = 54;
            this.lblReceptionList.Text = "Cancel Reception List";
            // 
            // dgvReceptionListItems
            // 
            this.dgvReceptionListItems.AllowUserToAddRows = false;
            this.dgvReceptionListItems.AllowUserToDeleteRows = false;
            this.dgvReceptionListItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvReceptionListItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceptionListItems.Enabled = false;
            this.dgvReceptionListItems.Location = new System.Drawing.Point(11, 68);
            this.dgvReceptionListItems.Name = "dgvReceptionListItems";
            this.dgvReceptionListItems.RowHeadersWidth = 51;
            this.dgvReceptionListItems.RowTemplate.Height = 24;
            this.dgvReceptionListItems.Size = new System.Drawing.Size(601, 308);
            this.dgvReceptionListItems.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.dgvReceptionListItems);
            this.groupBox1.Controls.Add(this.btnRemoveItem);
            this.groupBox1.Controls.Add(this.btnAddItem);
            this.groupBox1.Location = new System.Drawing.Point(33, 178);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(635, 383);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reception List Items:";
            // 
            // cmbPurchaseOrder
            // 
            this.cmbPurchaseOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbPurchaseOrder.Enabled = false;
            this.cmbPurchaseOrder.FormattingEnabled = true;
            this.cmbPurchaseOrder.Location = new System.Drawing.Point(163, 87);
            this.cmbPurchaseOrder.Name = "cmbPurchaseOrder";
            this.cmbPurchaseOrder.Size = new System.Drawing.Size(132, 24);
            this.cmbPurchaseOrder.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 69;
            this.label4.Text = "Purchase order: ";
            // 
            // UCCancelReceptionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbPurchaseOrder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtReceptionListId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCanceled);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.cmbManufacturer);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblManufacturer);
            this.Controls.Add(this.btnCancelPurchaseOrder);
            this.Controls.Add(this.txtDateOfReception);
            this.Controls.Add(this.lblDateofReception);
            this.Controls.Add(this.lblReceptionList);
            this.Controls.Add(this.groupBox1);
            this.Name = "UCCancelReceptionList";
            this.Size = new System.Drawing.Size(700, 668);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceptionListItems)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReceptionListId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbCanceled;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.ComboBox cmbManufacturer;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Button btnCancelPurchaseOrder;
        private System.Windows.Forms.TextBox txtDateOfReception;
        private System.Windows.Forms.Label lblDateofReception;
        private System.Windows.Forms.Label lblReceptionList;
        private System.Windows.Forms.DataGridView dgvReceptionListItems;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbPurchaseOrder;
        private System.Windows.Forms.Label label4;
    }
}
