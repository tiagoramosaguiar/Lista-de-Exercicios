using System.Media;

namespace Atividade_11
{
    public partial class FormPrincipal : Form
    {

        Funcoes Funcoes = new Funcoes();
        int horas, minutos, minutosPassados;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void TextHoras_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirInt(e);
        }

        private void TextMinutos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirInt(e);
        }

        private void ButtonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                horas = Convert.ToInt32(TextHoras.Text);
                minutos = Convert.ToInt32(TextMinutos.Text);

                if (horas == 0)
                {
                    minutosPassados = minutos;
                }
                else if (horas > 0 && horas <= 24 && minutos >= 0 && minutos <= 59)
                {
                    minutosPassados = horas * 60 + minutos;

                    if (minutosPassados > 1440)
                    {
                        SystemSounds.Hand.Play();
                        MessageBox.Show("Erro! Horário inválido.", "Minutos Passados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show("Erro! Horário inválido.", "Minutos Passados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show($"Desde a meia-noite passaram-se {minutosPassados} minutos.", "Minutos Passados");
                Funcoes.LimparControles(this);
                TextHoras.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro! Preencha todos os campos.", "Minutos Passados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Erro! Valor inserido muito grande.", "Minutos Passados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}