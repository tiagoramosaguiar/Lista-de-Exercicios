namespace Atividade_8
{
    public partial class FormPrincipal : Form
    {

        Funcoes Funcoes = new Funcoes();
        int idade, soma;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void TextIdade_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirInt(e);
        }

        private void ButtonSomar_Click(object sender, EventArgs e)
        {
            while (int.TryParse(TextIdade.Text, out idade))
            {
                if (idade >= 18)
                {
                    soma += idade;
                    TextIdade.Clear();
                    TextIdade.Focus();
                }
                else
                {
                    TextIdade.Clear();
                    TextIdade.Focus();
                }
            }

            ButtonMostrarSoma.Enabled = true;
        }

        private void ButtonMostrarSoma_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"A soma das idades inseridas acima de 18 anos é de {soma}.", "Soma idades");
            TextIdade.Focus();
        }

        private void ButtonReiniciarSoma_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja mesmo reiniciar a soma?", "Soma idades", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                idade = 0;
                soma = 0;
                Funcoes.LimparControles(this);
                TextIdade.Focus();
            }
        }
    }
}