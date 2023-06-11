namespace Atividade_2
{
    public partial class FormPrincipal : Form
    {

        Funcoes Funcoes = new Funcoes();
        int numero, inicioTabuada, fimTabuada;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void TextNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirInt(e);
        }

        private void TextInicioTabuada_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirInt(e);
        }

        private void TextFimTabuada_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirInt(e);
        }

        private void ButtonGerarTabuada_Click(object sender, EventArgs e)
        {
            try
            {
                numero = Convert.ToInt32(TextNumero.Text);
                inicioTabuada = Convert.ToInt32(TextInicioTabuada.Text);
                fimTabuada = Convert.ToInt32(TextFimTabuada.Text);
                string mensagem = "";

                if (inicioTabuada >= fimTabuada)
                {
                    System.Media.SystemSounds.Hand.Play();
                    MessageBox.Show("Erro! A tabuada não pode ter início maior ou igual ao seu fim.", "Gerador de tabuadas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                for (int i = inicioTabuada; i <= fimTabuada; i++)
                {
                    mensagem += ($"{numero} x {i} = {numero * i}\n");
                }

                MessageBox.Show($"Tabuada de {inicioTabuada} a {fimTabuada}:\n{mensagem}", "Gerador de tabuadas");
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