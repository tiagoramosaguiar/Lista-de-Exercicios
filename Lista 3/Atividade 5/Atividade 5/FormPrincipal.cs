namespace Atividade_5
{
    public partial class FormPrincipal : Form
    {

        Funcoes Funcoes = new Funcoes();
        int elementoInicial, razao, quantNumeros;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void TextElementoInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirIntNegativo(TextElementoInicial, e);
        }

        private void TextRazao_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirIntNegativo(TextRazao, e);
        }

        private void TextQuantNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirInt(e);
        }

        private void ButtonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                elementoInicial = Convert.ToInt32(TextElementoInicial.Text);
                razao = Convert.ToInt32(TextRazao.Text);
                quantNumeros = Convert.ToInt32(TextQuantNumeros.Text);
                string mensagem = $"{elementoInicial}, ";

                if (razao == 0)
                {
                    System.Media.SystemSounds.Hand.Play();
                    MessageBox.Show("Erro! A razão deve ser diferente de zero.", "Progressão aritmética", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                for (int i = 1; i <= quantNumeros - 1; i++)
                {
                    mensagem += ($"{elementoInicial += razao}, ");
                }

                mensagem = mensagem.Substring(0, mensagem.Length - 2) + ".";
                MessageBox.Show(mensagem, "Progressão aritmética");
                Funcoes.LimparControles(this);
                TextElementoInicial.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro! Preencha todos os campos.", "Progressão aritmética", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Erro! Valor inserido muito grande.", "Progressão aritmética", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}