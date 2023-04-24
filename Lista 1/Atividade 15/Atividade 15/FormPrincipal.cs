namespace Atividade_15
{
    public partial class FormPrincipal : Form
    {

        Funcoes Funcoes = new Funcoes();
        double a, b, c, d, r, s;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void TextA_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirDouble(TextA, e);
        }

        private void TextB_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirDouble(TextB, e);
        }

        private void TextC_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirDouble(TextC, e);
        }

        private void ButtonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(TextA.Text);
                b = Convert.ToDouble(TextB.Text);
                c = Convert.ToDouble(TextC.Text);

                r = Math.Pow(a + b, 2);
                s = Math.Pow(b + c, 2);
                d = (r+s)/2;

                MessageBox.Show($"Resultado do cálculo: {d:f}.", "Lei de Pitot");
                Funcoes.LimparControles(this);
                TextA.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro! Preencha todos os campos.", "Lei de Pitot", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Erro! Valor inserido muito grande.", "Lei de Pitot", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}