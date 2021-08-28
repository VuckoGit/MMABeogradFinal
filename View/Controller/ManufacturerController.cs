using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Helpers;
using Domain;
using View.Exceptions;

namespace View.Controller
{
   public class ManufacturerController
    {
       

        internal void SaveManufacturer(TextBox txtName, TextBox txtTaxID, TextBox txtEmail, TextBox txtPhone, TextBox txtAccount, TextBox txtAddress)
        {
            if (UserControlHelpers.EmptyFieldValidation(txtName) &
                UserControlHelpers.EmptyFieldValidation(txtTaxID) &
               UserControlHelpers.EmptyFieldValidation(txtEmail) & 
                UserControlHelpers.IsValidEmailAdress(txtEmail) &
                UserControlHelpers.EmptyFieldValidation(txtPhone) &
                UserControlHelpers.EmptyFieldValidation(txtAccount) &
                UserControlHelpers.EmptyFieldValidation(txtAddress))
            {
                Manufacturer m = new Manufacturer();
                m.Name = txtName.Text;
                m.TaxId = txtTaxID.Text;
                m.Email = txtEmail.Text;
                m.Phone = txtPhone.Text;
                m.Account = txtAccount.Text;
                m.Address = txtAddress.Text;
    
                try
             {
                Communication.Communication.Instance.SaveManufacturer(m);
                MessageBox.Show("Manufacturer is saved!");
             }
             catch (SystemOperationException ex)
             {
                MessageBox.Show("Manufacturer is not saved\n" + ex.Message);
             }
            }
            else
            {
                MessageBox.Show("Error in fild validation, try again!");
                return;

            }
        }
        
    }
}
