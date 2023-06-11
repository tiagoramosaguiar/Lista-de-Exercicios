namespace Atividade_10
{
    public partial class FormPrincipal : Form
    {

        Funcoes Funcoes = new Funcoes();
        int quantNumeros, anterior, atual, proximo;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void TextQuantNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirInt(e);
        }

        private void ButtonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                quantNumeros = Convert.ToInt32(TextQuantNumeros.Text);

                if (quantNumeros == 0)
                {
                    System.Media.SystemSounds.Hand.Play();
                    MessageBox.Show("Erro! A quantidade de números deve ser diferente de zero.", "Sequência de Fibonacci", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string mensagem = "1, ";
                anterior = 0;
                atual = 1;

                for (int i = 1; i <= quantNumeros; i++)
                {
                    proximo = anterior + atual;
                    anterior = atual;
                    atual = proximo;
                    mensagem += $"{proximo}, ";
                }

                mensagem = mensagem.TrimEnd(' ', ',') + ".";
                MessageBox.Show(mensagem, "Sequência de Fibonacci");
                Funcoes.LimparControles(this);
                TextQuantNumeros.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro! Preencha todos os campos.", "Sequência de Fibonacci", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Erro! Valor inserido muito grande.", "Sequência de Fibonacci", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}