namespace Atividade_12
{
    public partial class FormPrincipal : Form
    {

        Funcoes Funcoes = new Funcoes();
        int[] sequencia = new int[9];
        int numeros, contagem = 0, razao;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void TextNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirIntNegativo(TextNumero, e);
        }

        public void ButtonAdicionar_Click(object sender, EventArgs e)
        {
            if (contagem <= 8)
            {
                if (int.TryParse(TextNumero.Text, out numeros))
                {
                    sequencia[contagem] = numeros;
                    TextNumero.Clear();
                    TextNumero.Focus();
                    contagem++;
                }
            }
            if (contagem == 9)
            {
                ButtonChecarPA.Enabled = true;
                ButtonAdicionar.Enabled = false;
                TextNumero.Clear();
                ButtonChecarPA.Focus();
            }
        }

        private void ButtonChecarPA_Click(object sender, EventArgs e)
        {
            razao = sequencia[1] - sequencia[0];
            for (int i = 1; i <= 8; i++)
            {
                if ((sequencia[i] - sequencia[i-1]) != razao)
                {
                    MessageBox.Show("A sequ�ncia n�o forma uma progress�o aritm�tica.", "Progress�o Aritm�tica");
                    ButtonReiniciar.Enabled = true;
                    ButtonReiniciar.Focus();
                    return;
                }
            }
            MessageBox.Show($"A sequ�ncia forma uma progress�o aritm�tica de raz�o {razao}.", "Progress�o Aritm�tica");
            ButtonReiniciar.Enabled = true;
            ButtonReiniciar.Focus();
        }

        private void ButtonReiniciar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja mesmo reiniciar a sequ�ncia?", "Progress�o Aritm�tica", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                for (int i = 0; i < 9; i++)
                {
                    sequencia[i] = 0;
                }
                contagem = 0;
                ButtonChecarPA.Enabled = false;
                ButtonReiniciar.Enabled = false;
                ButtonAdicionar.Enabled = true;
                Funcoes.LimparControles(this);
                TextNumero.Focus();
            }
        }
    }
}