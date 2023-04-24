namespace Atividade_2
{
    public partial class FormPrincipal : Form
    {

        Funcoes Funcoes = new Funcoes();
        int idade;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void TextIdade_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirInt(e);
        }

        private void ButtonChecar_Click(object sender, EventArgs e)
        {
            try
            {
                idade = Convert.ToInt32(TextIdade.Text);

                MessageBox.Show(idade >= 18 ? "Maior de idade." : "Menor de idade.", "Checar maioridade");
                Funcoes.LimparControles(this);
                TextIdade.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro! Preencha todos os campos.", "Checar maioridade", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Erro! Valor inserido muito grande.", "Checar maioridade", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}