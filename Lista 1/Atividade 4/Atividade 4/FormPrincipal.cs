namespace Atividade_4
{
    public partial class FormPrincipal : Form
    {

        Funcoes Funcoes = new Funcoes();
        string nome = "";
        int idade, dias;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void TextNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirString(e);
        }

        private void TextIdade_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirInt(e);
        }

        private void ButtonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                nome = TextNome.Text;
                idade = Convert.ToInt32(TextIdade.Text);

                if (string.IsNullOrWhiteSpace(nome) || nome.Trim().Length == 0)
                {
                    System.Media.SystemSounds.Hand.Play();
                    MessageBox.Show("Erro! O nome deve estar preenchido.", "Dias de vida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                dias = idade * 365;

                MessageBox.Show($"{nome}, você já viveu {dias} dias!", "Dias de vida");
                Funcoes.LimparControles(this);
                TextNome.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro! Preencha todos os campos.", "Dias de vida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Erro! Valor inserido muito grande.", "Dias de vida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}