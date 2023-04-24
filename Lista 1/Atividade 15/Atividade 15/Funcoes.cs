using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_15
{
    public class Funcoes
    {
        public void PermitirDouble(TextBox textBox, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ',' ? true : e.KeyChar == ',' && textBox.Text.Contains(",") ? true : false;
        }

        public void PermitirInt(KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar) && e.KeyChar != 8);
        }

        public void PermitirString(KeyPressEventArgs e)
        {
            e.Handled = (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32);
        }

        public void LimparControles(Control ctrl)
        {
            foreach (Control control in ctrl.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Text = "";
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
                else if (control.HasChildren)
                {
                    LimparControles(control);
                }
            }
        }
    }
}
