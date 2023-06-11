namespace Atividade_7
{
    public partial class FormPrincipal : Form
    {

        Funcoes Funcoes = new Funcoes();
        double numero, soma;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void TextNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirDoubleNegativo(TextNumero, e);
        }

        private void ButtonSomar_Click(object sender, EventArgs e)
        {
            while (double.TryParse(TextNumero.Text, out numero))
            {
                soma += numero;
                TextNumero.Clear();
                TextNumero.Focus();
            }

            ButtonMostrarSoma.Enabled = true;
        }

        private void ButtonMostrarSoma_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"A soma dos números inseridos é de {soma:f}.", "Soma números");
            TextNumero.Focus();
        }

        private void ButtonReiniciarSoma_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja mesmo reiniciar a soma?", "Soma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                numero = 0;
                soma = 0;
                Funcoes.LimparControles(this);
                TextNumero.Focus();
            }
        }
    }
}