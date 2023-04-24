namespace Atividade_6
{
    public partial class FormPrincipal : Form
    {

        Funcoes Funcoes = new Funcoes();
        int codigoProduto;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void TextCodigoClassificacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirInt(e);
        }

        private void ButtonLerCodigo_Click(object sender, EventArgs e)
        {
            try
            {
                codigoProduto = Convert.ToInt32(TextCodigoProduto.Text);

                if (codigoProduto == 1)
                {
                    MessageBox.Show("Alimento não perecível.", "Classificar produtos");
                }
                else if (codigoProduto >= 2 && codigoProduto <= 4)
                {
                    MessageBox.Show("Alimento perecível.", "Classificar produtos");
                }
                else if (codigoProduto >= 5 && codigoProduto <= 6)
                {
                    MessageBox.Show("Vestuário.", "Classificar produtos");
                }
                else if (codigoProduto == 7)
                {
                    MessageBox.Show("Higiene pessoal.", "Classificar produtos");
                }
                else if (codigoProduto >= 8 && codigoProduto <= 10)
                {
                    MessageBox.Show("Utensílios domésticos.", "Classificar produtos");
                }
                else
                {
                    System.Media.SystemSounds.Hand.Play();
                    MessageBox.Show("Código inválido.", "Classificar produtos");
                }

                Funcoes.LimparControles(this);
                TextCodigoProduto.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro! Preencha todos os campos.", "Classificar produtos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Erro! Valor inserido muito grande.", "Classificar produtos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}