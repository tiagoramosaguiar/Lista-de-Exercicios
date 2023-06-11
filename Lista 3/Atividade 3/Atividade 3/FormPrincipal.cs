namespace Atividade_3
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
            Funcoes.PermitirIntNegativo(TextNumero, e);
        }

        private void ButtonGerarTabuada_Click(object sender, EventArgs e)
        {
            try
            {
                numero = Convert.ToInt32(TextNumero.Text);
                string mensagem = "";

                for (int i = 1; i <= 10; i++)
                {
                    if (numero * i % 2 == 0)
                        mensagem += ($"{numero} x {i} = {numero * i}\n");
                }

                MessageBox.Show($"Tabuada de 1 a 10 (resultados pares):\n{mensagem}", "Gerador de tabuadas");
                Funcoes.LimparControles(this);
                TextNumero.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro! Preencha todos os campos.", "Gerador de tabuadas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Erro! Valor inserido muito grande.", "Gerador de tabuadas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}