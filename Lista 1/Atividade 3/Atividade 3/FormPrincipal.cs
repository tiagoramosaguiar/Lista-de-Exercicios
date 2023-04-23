namespace Atividade_3
{
    public partial class FormPrincipal : Form
    {

        Funcoes Funcoes = new Funcoes();
        int quantBroas, quantPaes;
        double valorArrecadado, valorPoupanca;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void TextQuantPaes_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirInt(e);
        }

        private void TextQuantBroas_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirInt(e);
        }

        private void ButtonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                quantPaes = Convert.ToInt32(TextQuantPaes.Text);
                quantBroas = Convert.ToInt32(TextQuantBroas.Text);

                valorArrecadado = quantPaes * 0.12 + quantBroas * 1.50;
                valorPoupanca = valorArrecadado * 0.1;

                MessageBox.Show($"Foram arrecadados R$ {valorArrecadado:f}.\nO valor a ser guardado na poupança é de R$ {valorPoupanca:f}.", "Hotpão");
                Funcoes.LimparControles(this);
                TextQuantPaes.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro! Preencha todos os campos.", "Hotpão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Erro! Valor inserido muito grande.", "Hotpão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}