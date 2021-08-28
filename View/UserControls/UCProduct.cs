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
    public partial class UCProduct : UserControl
    {
        private ProductController productController;
        public TextBox TxtName { get => txtName; }
        public TextBox TxtPrice { get => txtPrice; }
        public ComboBox CMBGender { get => cmbGender; }
        public TextBox TxtBrand { get => txtBrand; }

        public UCProduct(ProductController productController)
        {
            InitializeComponent();
            this.productController = productController;
            this.productController.InitNewProduct(this);
        }

      
        private void UCProduct_Load_1(object sender, EventArgs e)
        {
           

        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            productController.Save(this);
        }
    }
}
