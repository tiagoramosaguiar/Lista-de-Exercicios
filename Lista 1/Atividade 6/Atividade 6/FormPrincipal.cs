namespace Atividade_6
{
    public partial class FormPrincipal : Form
    {

        Funcoes Funcoes = new Funcoes();
        double pesoPrato, valorPagamento;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void TextPesoPrato_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirDouble(TextPesoPrato, e);
        }

        private void ButtonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                pesoPrato = Convert.ToDouble(TextPesoPrato.Text);

                valorPagamento = pesoPrato * 28;

                MessageBox.Show($"O valor a pagar � de R$ {valorPagamento:f}.", "Bem-B�o");
                Funcoes.LimparControles(this);
                TextPesoPrato.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro! Preencha todos os campos.", "Bem-B�o", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Erro! Valor inserido muito grande.", "Bem-B�o", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}