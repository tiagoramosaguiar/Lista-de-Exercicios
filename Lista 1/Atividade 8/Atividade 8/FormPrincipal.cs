namespace Atividade_8
{
    public partial class FormPrincipal : Form
    {

        Funcoes Funcoes = new Funcoes();
        int quantCamisetasP, quantCamisetasM, quantCamisetasG;
        double valorArrecadado;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void TextCamisetasP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirInt(e);
        }

        private void TextCamisetasM_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirInt(e);
        }

        private void TextCamisetasG_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirInt(e);
        }

        private void ButtonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                quantCamisetasP = Convert.ToInt32(TextCamisetasP.Text);
                quantCamisetasM = Convert.ToInt32(TextCamisetasM.Text);
                quantCamisetasG = Convert.ToInt32(TextCamisetasG.Text);

                valorArrecadado = quantCamisetasP * 10 + quantCamisetasM * 12 + quantCamisetasG * 15;

                MessageBox.Show($"Será arrecadado R$ {valorArrecadado:f} de camisetas vendidas.", "Camisetas");
                Funcoes.LimparControles(this);
                TextCamisetasP.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro! Preencha todos os campos.", "Camisetas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Erro! Valor inserido muito grande.", "Camisetas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}