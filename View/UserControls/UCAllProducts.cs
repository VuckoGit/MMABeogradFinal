using Domain;
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
    public partial class UCAllProducts : UserControl
    {
        private ProductController productController;
        public UCAllProducts(ProductController productController)
        {
            InitializeComponent();
            this.productController = productController;
            productController.InitUCAllProducts(this);
        }
        public DataGridView DgvProducts { get => dgvProducts;  }
       
        private void dgvProducts_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvProducts_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
               

        }

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            productController.ChooseProduct(DgvProducts);
             
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            productController.Search(txtSearch);
        }
    }
}
