namespace Atividade_8
{
    public partial class FormPrincipal : Form
    {

        Funcoes Funcoes = new Funcoes();
        int numero;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void TextNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirInt(e);
        }

        private void ButtonChecar_Click(object sender, EventArgs e)
        {
            try
            {
                numero = Convert.ToInt32(TextNumero.Text);

                MessageBox.Show(numero % 2 == 0 ? $"{numero} é par." : $"{numero} é ímpar.", "Par ou ímpar");
                Funcoes.LimparControles(this);
                TextNumero.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro! Preencha todos os campos.", "Par ou ímpar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Erro! Valor inserido muito grande.", "Par ou ímpar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}