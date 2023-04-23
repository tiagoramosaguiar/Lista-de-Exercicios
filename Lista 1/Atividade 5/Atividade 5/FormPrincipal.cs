namespace Atividade_5
{
    public partial class FormPrincipal : Form
    {

        Funcoes Funcoes = new Funcoes();
        double precoLitro, valorPagamento, litrosAbast;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void TextPrecoLitro_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirDouble(TextPrecoLitro, e);
        }

        private void TextValorPagamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirDouble(TextValorPagamento, e);
        }

        private void ButtonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                precoLitro = Convert.ToDouble(TextPrecoLitro.Text);
                valorPagamento = Convert.ToDouble(TextValorPagamento.Text);

                if (precoLitro == 0 || valorPagamento == 0)
                {
                    System.Media.SystemSounds.Hand.Play();
                    MessageBox.Show("Erro! Todos os campos devem ser diferentes de zero.", "Litros Abastecidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                litrosAbast = valorPagamento / precoLitro;

                MessageBox.Show($"Foram abastecidos {litrosAbast:f} litros de gasolina no tanque.", "Litros Abastecidos");
                Funcoes.LimparControles(this);
                TextPrecoLitro.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro! Preencha todos os campos.", "Litros Abastecidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Erro! Valor inserido muito grande.", "Litros Abastecidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}