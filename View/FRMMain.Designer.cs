
using System;

namespace View
{
    partial class FRMMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMMain));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.editProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelationOfReceptionListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchReceptionListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewReceprionListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receptionListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelationPurchaseOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPurchaseOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPurchaseOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewManufacturerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMainContainer = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlMainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(675, 634);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(191, 29);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, User";
            // 
            // editProfileToolStripMenuItem
            // 
            this.editProfileToolStripMenuItem.Name = "editProfileToolStripMenuItem";
            this.editProfileToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.editProfileToolStripMenuItem.Text = "Edit profile";
            // 
            // cancelationOfReceptionListToolStripMenuItem
            // 
            this.cancelationOfReceptionListToolStripMenuItem.Name = "cancelationOfReceptionListToolStripMenuItem";
            this.cancelationOfReceptionListToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.cancelationOfReceptionListToolStripMenuItem.Text = "Cancelation of the reception list";
            this.cancelationOfReceptionListToolStripMenuItem.Click += new System.EventHandler(this.cancelationOfReceptionListToolStripMenuItem_Click);
            // 
            // searchReceptionListToolStripMenuItem
            // 
            this.searchReceptionListToolStripMenuItem.Name = "searchReceptionListToolStripMenuItem";
            this.searchReceptionListToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.searchReceptionListToolStripMenuItem.Text = "Search reception list";
            this.searchReceptionListToolStripMenuItem.Click += new System.EventHandler(this.searchReceptionListToolStripMenuItem_Click);
            // 
            // addNewReceprionListToolStripMenuItem
            // 
            this.addNewReceprionListToolStripMenuItem.Name = "addNewReceprionListToolStripMenuItem";
            this.addNewReceprionListToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.addNewReceprionListToolStripMenuItem.Text = "Add new reception list";
            this.addNewReceprionListToolStripMenuItem.Click += new System.EventHandler(this.addNewReceprionListToolStripMenuItem_Click);
            // 
            // receptionListToolStripMenuItem
            // 
            this.receptionListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewReceprionListToolStripMenuItem,
            this.searchReceptionListToolStripMenuItem,
            this.cancelationOfReceptionListToolStripMenuItem});
            this.receptionListToolStripMenuItem.Name = "receptionListToolStripMenuItem";
            this.receptionListToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.receptionListToolStripMenuItem.Text = "Reception list";
            // 
            // cancelationPurchaseOrderToolStripMenuItem
            // 
            this.cancelationPurchaseOrderToolStripMenuItem.Name = "cancelationPurchaseOrderToolStripMenuItem";
            this.cancelationPurchaseOrderToolStripMenuItem.Size = new System.Drawing.Size(316, 26);
            this.cancelationPurchaseOrderToolStripMenuItem.Text = "Cancelation of the purchase order";
            this.cancelationPurchaseOrderToolStripMenuItem.Click += new System.EventHandler(this.cancelationPurchaseOrderToolStripMenuItem_Click);
            // 
            // editPurchaseOrderToolStripMenuItem
            // 
            this.editPurchaseOrderToolStripMenuItem.Name = "editPurchaseOrderToolStripMenuItem";
            this.editPurchaseOrderToolStripMenuItem.Size = new System.Drawing.Size(316, 26);
            this.editPurchaseOrderToolStripMenuItem.Text = "Search purchase order";
            this.editPurchaseOrderToolStripMenuItem.Click += new System.EventHandler(this.searchPurchaseOrderToolStripMenuItem_Click);
            // 
            // addNewPurchaseOrderToolStripMenuItem
            // 
            this.addNewPurchaseOrderToolStripMenuItem.Name = "addNewPurchaseOrderToolStripMenuItem";
            this.addNewPurchaseOrderToolStripMenuItem.Size = new System.Drawing.Size(316, 26);
            this.addNewPurchaseOrderToolStripMenuItem.Text = "Add new purchase order";
            this.addNewPurchaseOrderToolStripMenuItem.Click += new System.EventHandler(this.addNewPurchaseOrderToolStripMenuItem_Click);
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewPurchaseOrderToolStripMenuItem,
            this.editPurchaseOrderToolStripMenuItem,
            this.cancelationPurchaseOrderToolStripMenuItem});
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.orderToolStripMenuItem.Text = "Purchase order";
            // 
            // editProductToolStripMenuItem
            // 
            this.editProductToolStripMenuItem.Name = "editProductToolStripMenuItem";
            this.editProductToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.editProductToolStripMenuItem.Text = "Edit product";
            this.editProductToolStripMenuItem.Click += new System.EventHandler(this.editProductToolStripMenuItem_Click);
            // 
            // searchProductToolStripMenuItem
            // 
            this.searchProductToolStripMenuItem.Name = "searchProductToolStripMenuItem";
            this.searchProductToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.searchProductToolStripMenuItem.Text = "Search product";
            this.searchProductToolStripMenuItem.Click += new System.EventHandler(this.searchProductToolStripMenuItem_Click);
            // 
            // addNewProductToolStripMenuItem
            // 
            this.addNewProductToolStripMenuItem.Name = "addNewProductToolStripMenuItem";
            this.addNewProductToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.addNewProductToolStripMenuItem.Text = "Add new product";
            this.addNewProductToolStripMenuItem.Click += new System.EventHandler(this.addNewProductToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewProductToolStripMenuItem,
            this.searchProductToolStripMenuItem,
            this.editProductToolStripMenuItem});
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.productToolStripMenuItem.Text = "Product";
            // 
            // addNewManufacturerToolStripMenuItem
            // 
            this.addNewManufacturerToolStripMenuItem.Name = "addNewManufacturerToolStripMenuItem";
            this.addNewManufacturerToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.addNewManufacturerToolStripMenuItem.Text = "Add new manufacturer";
            this.addNewManufacturerToolStripMenuItem.Click += new System.EventHandler(this.AddNewmanufacturerToolStripMenuItem_Click);
            // 
            // unosToolStripMenuItem
            // 
            this.unosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewManufacturerToolStripMenuItem});
            this.unosToolStripMenuItem.Name = "unosToolStripMenuItem";
            this.unosToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.unosToolStripMenuItem.Text = "Manufacturer";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosToolStripMenuItem,
            this.productToolStripMenuItem,
            this.orderToolStripMenuItem,
            this.receptionListToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1103, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(304, 299);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(452, 263);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pnlMainContainer
            // 
            this.pnlMainContainer.Controls.Add(this.pictureBox1);
            this.pnlMainContainer.Controls.Add(this.lblWelcome);
            this.pnlMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlMainContainer.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMainContainer.Name = "pnlMainContainer";
            this.pnlMainContainer.Size = new System.Drawing.Size(1103, 924);
            this.pnlMainContainer.TabIndex = 3;
            // 
            // FRMMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 924);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlMainContainer);
            this.Name = "FRMMain";
            this.Text = "FRMMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRMMain_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlMainContainer.ResumeLayout(false);
            this.pnlMainContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.ToolStripMenuItem editProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelationOfReceptionListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchReceptionListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewReceprionListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receptionListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelationPurchaseOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPurchaseOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPurchaseOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewManufacturerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlMainContainer;
    }
}