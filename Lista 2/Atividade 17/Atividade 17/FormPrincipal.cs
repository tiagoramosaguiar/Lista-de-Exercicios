using System.Media;

namespace Atividade_17
{
    public partial class FormPrincipal : Form
    {

        Funcoes Funcoes = new Funcoes();
        double precoProduto, valorAVista, valorCartao, valor2X, valor3X;
        int condicaoPagamento;

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
                if (ComboCondicaoPagamento.SelectedIndex == -1)
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show("Erro! Selecione o código de pagamento.", "Pagamentos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                precoProduto = Convert.ToDouble(TextPrecoProduto.Text);
                condicaoPagamento = Convert.ToInt32(ComboCondicaoPagamento.Text);

                if (precoProduto == 0)
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show("Erro! O preço do produto deve ser diferente de zero.", "Pagamentos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                switch (condicaoPagamento)
                {
                    case 1:
                        valorAVista = precoProduto * 0.9;
                        MessageBox.Show($"À vista em dinheiro ou cheque, com 10% de desconto: R$ {valorAVista:f}.", "Pagamentos");
                        break;
                    case 2:
                        valorCartao = precoProduto * 0.95;
                        MessageBox.Show($"À vista com cartão de crédito, com 5% de desconto: R$ {valorCartao:f}.", "Pagamentos");
                        break;
                    case 3:
                        valor2X = precoProduto / 2;
                        MessageBox.Show($"Em 2 vezes, preço normal de etiqueta sem juros: R$ {valor2X:f}.", "Pagamentos");
                        break;
                    case 4:
                        valor3X = precoProduto * 1.1 / 3;
                        MessageBox.Show($"Em 3 vezes, preço de etiqueta com acréscimo de 10%: R$ {valor3X:f}.", "Pagamentos");
                        break;
                }

                Funcoes.LimparControles(this);
                TextPrecoProduto.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro! Preencha todos os campos.", "Pagamentos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Erro! Valor inserido muito grande.", "Pagamentos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}