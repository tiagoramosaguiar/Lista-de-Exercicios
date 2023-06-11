using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_1
{
    public class Funcoes
    {
        public void PermitirDouble(TextBox textBox, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == ',' && (textBox.Text.Contains(",")) || !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == ','));
        }

        public void PermitirDoubleNegativo(TextBox textBox, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == '-' && (textBox.Text.Contains("-") || textBox.SelectionStart != 0)) || (e.KeyChar == ',' && (textBox.Text.Contains(","))) || !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == ',' || e.KeyChar == '-');
        }

        public void PermitirInt(KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        public void PermitirIntNegativo(TextBox textBox, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == '-' && (textBox.Text.Contains("-") || textBox.SelectionStart != 0)) || !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '-');
        }

        public void PermitirString(KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        public void LimparControles(Control form)
        {
            foreach (Control controle in form.Controls)
            {
                if (controle is TextBox)
                {
                    ((TextBox)controle).Text = "";
                }
                else if (controle is ComboBox)
                {
                    ((ComboBox)controle).SelectedIndex = -1;
                }
                else if (controle.HasChildren)
                {
                    LimparControles(controle);
                }
            }
        }
    }
}
