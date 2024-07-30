using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Helper
{
    public class TextBoxValidation
    {
        public static bool IsTextBoxEmpty(TextBox textBox)
        {
            return !string.IsNullOrWhiteSpace(textBox.Text);
        }
        public static void onlyNumber(object sender, KeyPressEventArgs e, TextBox textBox)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if(textBox.Text.Length >= 11 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
