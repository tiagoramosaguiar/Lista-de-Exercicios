namespace Atividade_12
{
    public partial class FormPrincipal : Form
    {

        Funcoes Funcoes = new Funcoes();
        double valorReais, valorDolares, valorEuros, valorLibras;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void TextValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirDouble(TextValor, e);
        }

        private void ButtonConverter_Click(object sender, EventArgs e)
        {
            try
            {
                valorReais = Convert.ToDouble(TextValor.Text);

                if (valorReais == 0)
                {
                    System.Media.SystemSounds.Hand.Play();
                    MessageBox.Show("Erro! O valor em R$ deve ser diferente de zero.", "Conversor de Moedas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                valorDolares = valorReais / 4.20;
                valorEuros = valorReais / 4.50;
                valorLibras = valorReais / 4.90;

                MessageBox.Show($"Valor em dólares: $ {valorDolares:f}.\n\nValor em euros: € {valorEuros:f}.\n\nValor em libras: £ {valorLibras:f}.", "Conversor de Moedas");
                Funcoes.LimparControles(this);
                TextValor.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro! Preencha todos os campos.", "Conversor de Moedas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Erro! Valor inserido muito grande.", "Conversor de Moedas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}