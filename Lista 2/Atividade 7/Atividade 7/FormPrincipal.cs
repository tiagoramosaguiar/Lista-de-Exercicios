namespace Atividade_7
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

                switch (codigoProduto)
                {
                    case 1:
                        MessageBox.Show("Alimento n�o perec�vel.", "Classificar produtos");
                        break;
                    case 2:
                    case 3:
                    case 4:
                        MessageBox.Show("Alimento perec�vel.", "Classificar produtos");
                        break;
                    case 5:
                    case 6:
                        MessageBox.Show("Vestu�rio.", "Classificar produtos");
                        break;
                    case 7:
                        MessageBox.Show("Higiene pessoal.", "Classificar produtos");
                        break;
                    case 8:
                    case 9:
                    case 10:
                        MessageBox.Show("Utens�lios dom�sticos.", "Classificar produtos");
                        break;
                    default:
                        System.Media.SystemSounds.Hand.Play();
                        MessageBox.Show("Erro! C�digo inv�lido.", "Classificar produtos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
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