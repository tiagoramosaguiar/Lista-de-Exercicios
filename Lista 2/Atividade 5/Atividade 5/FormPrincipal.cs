namespace Atividade_5
{
    public partial class FormPrincipal : Form
    {

        Funcoes Funcoes = new Funcoes();
        double valorEmprestimo, salarioSolicitante, valorParcela;
        int numeroParcelas;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void TextValorEmprestimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirDouble(TextValorEmprestimo, e);
        }

        private void TextNumeroParcelas_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirInt(e);
        }

        private void TextSalarioSolicitante_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirDouble(TextSalarioSolicitante, e);
        }

        private void ButtonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                valorEmprestimo = Convert.ToDouble(TextValorEmprestimo.Text);
                numeroParcelas = Convert.ToInt32(TextNumeroParcelas.Text);
                salarioSolicitante = Convert.ToDouble(TextSalarioSolicitante.Text);

                valorParcela = valorEmprestimo / numeroParcelas;

                MessageBox.Show((valorParcela <= (salarioSolicitante * 0.3)) ? "Empréstimo aprovado." : "Empréstimo não aprovado.", "Empréstimo bancário");
                Funcoes.LimparControles(this);
                TextValorEmprestimo.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro! Preencha todos os campos.", "Empréstimo bancário", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Erro! Valor inserido muito grande.", "Empréstimo bancário", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}