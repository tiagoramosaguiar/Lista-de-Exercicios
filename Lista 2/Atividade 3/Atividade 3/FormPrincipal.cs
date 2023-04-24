namespace Atividade_3
{
    public partial class FormPrincipal : Form
    {
        
        Funcoes Funcoes = new Funcoes();
        int primeiroNumero, segundoNumero, terceiroNumero, maiorNumero;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void TextPrimeiroNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirInt(e);
        }

        private void TextSegundoNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirInt(e);
        }

        private void TextTerceiroNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirInt(e);
        }

        private void ButtonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                primeiroNumero = Convert.ToInt32(TextPrimeiroNumero.Text);
                segundoNumero = Convert.ToInt32(TextSegundoNumero.Text);
                terceiroNumero = Convert.ToInt32(TextTerceiroNumero.Text);

                maiorNumero = Math.Max(primeiroNumero, Math.Max(segundoNumero, terceiroNumero));

                MessageBox.Show($"O maior número é {maiorNumero}.", "Maior número");
                Funcoes.LimparControles(this);
                TextPrimeiroNumero.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro! Preencha todos os campos.", "Maior número", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Erro! Valor inserido muito grande.", "Maior número", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}