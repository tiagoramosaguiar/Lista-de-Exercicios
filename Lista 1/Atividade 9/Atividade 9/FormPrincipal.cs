namespace Atividade_9
{
    public partial class FormPrincipal : Form
    {

        Funcoes Funcoes = new Funcoes();
        double precoProduto, valorAVista, valor5X, valor10X;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void TextPrecoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirDouble(TextPrecoProduto, e);
        }

        private void ButtonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                precoProduto = Convert.ToDouble(TextPrecoProduto.Text);

                if (precoProduto == 0)
                {
                    System.Media.SystemSounds.Hand.Play();
                    MessageBox.Show("Erro! O preço do produto deve ser diferente de zero.", "Vendas Parceladas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                valorAVista = precoProduto * 0.9;
                valor5X = precoProduto / 5;
                valor10X = precoProduto * 1.2 / 10;

                MessageBox.Show($"Valor com 10% de desconto para pagamento à vista: R$ {valorAVista:f}.\n\nValor da prestação para parcelamento sem juros, em 5x: R$ {valor5X:f}.\n\nValor da prestação para parcelamento com juros, em 10x, com 20% de acréscimo no valor do produto: R$ {valor10X:f}.", "Vendas Parceladas");
                Funcoes.LimparControles(this);
                TextPrecoProduto.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro! Preencha todos os campos.", "Vendas Parceladas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Erro! Valor inserido muito grande.", "Vendas Parceladas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}