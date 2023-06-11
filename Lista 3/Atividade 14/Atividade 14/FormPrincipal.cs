namespace Atividade_14
{
    public partial class FormPrincipal : Form
    {

        Funcoes Funcoes = new Funcoes();
        double[] numeros = new double[10];
        int contagem = 0;
        double numero, soma = 0, media = 0, somaQuadradosDasDiferencas = 0, diferenca, variancia, desvioPadrao;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void TextNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirDouble(TextNumero, e);
        }

        private void ButtonAdicionar_Click(object sender, EventArgs e)
        {
            if (contagem <= 9)
            {
                if (double.TryParse(TextNumero.Text, out numero))
                {
                    numeros[contagem] = numero;
                    TextNumero.Clear();
                    TextNumero.Focus();
                    contagem++;
                }
            }
            if (contagem == 10)
            {
                ButtonCalculos.Enabled = true;
                ButtonAdicionar.Enabled = false;
                TextNumero.Clear();
                ButtonCalculos.Focus();
            }
        }

        private void ButtonCalculos_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < contagem; i++)
            {
                soma += numeros[i];
            }
            media = soma / contagem;

            for (int i = 0; i < contagem; i++)
            {
                diferenca = numeros[i] - media;
                somaQuadradosDasDiferencas += Math.Pow(diferenca, 2);
            }

            variancia = somaQuadradosDasDiferencas / (contagem - 1);
            desvioPadrao = Math.Sqrt(variancia);

            MessageBox.Show($"Média: {media:f}\nDesvio Padrão: {desvioPadrao:f5}", "Média e Desvio Padrão");
            ButtonReiniciar.Focus();
        }

        private void ButtonReiniciar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja mesmo reiniciar?", "Média e Desvio Padrão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                for (int i = 0; i < 10; i++)
                {
                    numeros[i] = 0;
                }
                contagem = 0;
                soma = 0;
                media = 0;
                somaQuadradosDasDiferencas = 0;
                diferenca = 0;
                variancia = 0;
                desvioPadrao = 0;
                ButtonAdicionar.Enabled = true;
                ButtonCalculos.Enabled = false;
                Funcoes.LimparControles(this);
                TextNumero.Focus();
            }
        }
    }
}