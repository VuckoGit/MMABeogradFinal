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
    public partial class UCManufacturer : UserControl
    {
        private readonly ManufacturerController manufacturerController;

        public UCManufacturer(ManufacturerController manufacturerController)
        {
            this.manufacturerController = manufacturerController;
            InitializeComponent();
        }

       
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            manufacturerController.SaveManufacturer(txtName, txtTaxID, txtEmail, txtPhone, txtAccount, txtAddress);
        }
    }
}
