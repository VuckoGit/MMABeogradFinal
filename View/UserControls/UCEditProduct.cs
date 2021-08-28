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
using Domain;

namespace View.UserControls
{
    public partial class UCEditProduct : UserControl
    {
       

        private ProductController productController;
        public TextBox TxtProductId { get { return txtProductId; }  }
        public TextBox TxtName { get { return txtName; } }
        public TextBox TxtPrice { get { return txtPrice; } }
        public ComboBox CMBGender { get { return cmbGender; } }
        public TextBox TxtBrand { get { return txtBrand; } }
        public UCEditProduct(ProductController productController)
        {
            InitializeComponent();
               this.productController = productController;
            this.productController.InitEditProduct(this);


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            productController.EditProduct(this);
        }
    }
}
