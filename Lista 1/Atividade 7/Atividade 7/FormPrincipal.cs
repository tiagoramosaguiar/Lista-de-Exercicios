using System.Media;

namespace Atividade_7
{
    public partial class FormPrincipal : Form
    {

        Funcoes Funcoes = new Funcoes();
        int dia, mes, diasPercorridos;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void TextDia_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirInt(e);
        }

        private void TextMes_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirInt(e);
        }

        private void ButtonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                dia = Convert.ToInt32(TextDia.Text);
                mes = Convert.ToInt32(TextMes.Text);

                if (dia == 0 || dia > 30)
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show("Erro! Dia inválido.", "Dias do ano", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (mes == 0 || mes > 12)
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show("Erro! Mês inválido.", "Dias do ano", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                diasPercorridos = (mes - 1) * 30 + dia;

                MessageBox.Show($"Passaram-se {diasPercorridos} dias desde o início do ano.", "Dias do ano");
                Funcoes.LimparControles(this);
                TextDia.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro! Preencha todos os campos.", "Dias do ano", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Erro! Valor inserido muito grande.", "Dias do ano", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}