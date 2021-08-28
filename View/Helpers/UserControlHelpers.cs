using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Helpers
{
    public static class UserControlHelpers
    {
        public static bool EmptyFieldValidation(TextBox txt)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.BackColor = Color.LightCoral;
                return false;
            }
            else
            {
                txt.BackColor = Color.White;
                return true;
            }
        }

        public static bool DoubleFieldValidation(TextBox txt)
        {
            if (!double.TryParse(txt.Text, out double _))
            {
                txt.BackColor = Color.LightCoral;
                return false;
            }
            else
            {
                txt.BackColor = Color.White;
                return true;
            }
        }

        public static bool IntValidation(TextBox txt)
        {
            if (!int.TryParse(txt.Text, out int _))
            {
                txt.BackColor = Color.LightCoral;
                return false;
            }
            else
            {
                txt.BackColor = Color.White;
                return true;
            }
        }
        public static bool DateValidation(TextBox txt)
        {
            if (!DateTime.TryParseExact(txt.Text, "dd.MM.yyyy. HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out _)
)
            {
                txt.BackColor = Color.LightCoral;
                return false;
            }
            else
            {
                txt.BackColor = Color.White;
                return true;
            }
        }
        public static bool ComboBoxSelectedValidation(ComboBox cmb)
        {
            if (cmb.SelectedIndex==-1)
            {
                cmb.BackColor = Color.LightCoral;
                return false;
            }
            else
            {
                cmb.BackColor = Color.White;
                return true;
            }
        }
        public static bool IsValidEmailAdress(TextBox email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email.Text);
                email.BackColor = Color.White;
                return true;
            }
            catch
            {
                email.BackColor = Color.LightCoral;
                return false;
            }
        }
    }
}
