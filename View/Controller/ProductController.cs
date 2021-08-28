using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public class ProductController
    {
        private UCAllProducts allProducts;
        private UCProduct ucProduct;
        private UCEditProduct ucEditProduct;
        private BindingList<Product> Products = new BindingList<Product>();
        internal FRMMain frmMain;
        internal Product product;
        List<string> genders = new List<string>(new string[] { "Male", "Female" });

        public ProductController()
        {
          
        }
        public ProductController(FRMMain frmMain)
        {
            this.frmMain = frmMain;
        }
        public ProductController(FRMMain frmMain, Product product)
        {
            this.frmMain = frmMain;
            this.product = product;
        }

        internal void InitNewProduct(UCProduct uCProducts)
        {
            ucProduct = uCProducts;
            ucProduct.CMBGender.DataSource = genders;


        }
        internal void InitEditProduct(UCEditProduct uCEditProducts)
        {
            ucEditProduct = uCEditProducts;
            ucEditProduct.TxtProductId.Text = product.ProductId.ToString();
            ucEditProduct.TxtName.Text = product.Name;
            ucEditProduct.TxtPrice.Text = product.Price.ToString();
            ucEditProduct.CMBGender.DataSource = genders;
            ucEditProduct.CMBGender.SelectedItem = product.Gender;
            ucEditProduct.TxtBrand.Text = product.Brand;

        }

        internal void InitUCAllProducts(UCAllProducts uCAllProducts)
        {
            allProducts = uCAllProducts;
            try
            {
                allProducts.DgvProducts.DataSource = Communication.Communication.Instance.GetAllProducts();
                allProducts.DgvProducts.Columns["Self"].Visible = false;
                allProducts.DgvProducts.Columns["Name"].Visible = false;

                allProducts.DgvProducts.Columns["DisplayName"].HeaderText = "Products";
                MessageBox.Show("System loaded list of products");

            }
            catch (SystemOperationException)
            {

                MessageBox.Show("System can't load list of products");
           
            }
        }
        internal void Save(UCProduct ucProduct)
        {
            if (UserControlHelpers.EmptyFieldValidation(ucProduct.TxtName) &
                UserControlHelpers.DoubleFieldValidation(ucProduct.TxtPrice) &
                UserControlHelpers.ComboBoxSelectedValidation(ucProduct.CMBGender) &
                UserControlHelpers.EmptyFieldValidation(ucProduct.TxtBrand))
            {

                try
                {
                    Product p = new Product
                    {
                        Name = ucProduct.TxtName.Text,
                        Price = Double.Parse(ucProduct.TxtPrice.Text),
                        Gender = ucProduct.CMBGender.SelectedItem.ToString(),
                        Brand = ucProduct.TxtBrand.Text

                    };

                    Communication.Communication.Instance.SaveProduct(p);
                    MessageBox.Show("Product is saved");


                }
                catch (SystemOperationException ex)
                {
                    MessageBox.Show("Product is not saved\n" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Error in fild validation, try again!");
                return;

            }
        }

        internal void EditProduct(UCEditProduct ucEditProduct)
        {
            if (UserControlHelpers.IntValidation(ucEditProduct.TxtProductId)&
                UserControlHelpers.EmptyFieldValidation(ucEditProduct.TxtName) &
                  UserControlHelpers.DoubleFieldValidation(ucEditProduct.TxtPrice) &
                  UserControlHelpers.ComboBoxSelectedValidation(ucEditProduct.CMBGender) &
                  UserControlHelpers.EmptyFieldValidation(ucEditProduct.TxtBrand))
            {

                try
                {
                    Product p = new Product
                    {
                        ProductId = int.Parse(ucEditProduct.TxtProductId.Text),
                        Name = ucEditProduct.TxtName.Text,
                        Price = Double.Parse(ucEditProduct.TxtPrice.Text),
                        Gender = ucEditProduct.CMBGender.Text,
                        Brand = ucEditProduct.TxtBrand.Text

                    };

                    Communication.Communication.Instance.EditProduct(p);
                    MessageBox.Show("Product is edited");


                }
                catch (SystemOperationException ex)
                {
                    MessageBox.Show("Product is not edited\n" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Error in fild validation, try again!");
                return;

            }
        }

        internal void ChooseProduct(DataGridView dgvProduct)
        {
            try
            {
                DataGridViewRow row = dgvProduct.SelectedRows[0];
                Product product = (Product)row.DataBoundItem;
                MessageBox.Show($"You chose {product.ProductId} {product.Name}");
 
                frmMain.mainController.OpenUCEditProduct(frmMain, product);
                MessageBox.Show($"System found product information");
            }
            catch (Exception ex)
            {

                MessageBox.Show("System can't find product information ");
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
                allProducts.DgvProducts.DataSource = Communication.Communication.Instance.Search(txtSearch.Text);
                allProducts.DgvProducts.Columns["DisplayName"].HeaderText = "Name";

                MessageBox.Show("System find products with searching parameter!");


            }
            catch (SystemOperationException)
            {
                MessageBox.Show("System can't find the product with searching parameter!");
            }
        }
    }
}
