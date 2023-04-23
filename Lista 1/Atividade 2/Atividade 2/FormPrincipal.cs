namespace Atividade_2
{
    public partial class FormPrincipal : Form
    {

        Funcoes Funcoes = new Funcoes();
        int quantCavalos, quantFerraduras;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void TextQuantCavalos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirInt(e);
        }

        private void ButtonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                quantCavalos = Convert.ToInt32(TextQuantCavalos.Text);

                quantFerraduras = quantCavalos * 4;

                MessageBox.Show($"Serão necessárias {quantFerraduras} ferraduras para equipar todos os cavalos comprados.", "Haras");
                Funcoes.LimparControles(this);
                TextQuantCavalos.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro! Preencha todos os campos.", "Haras", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Erro! Valor inserido muito grande.", "Haras", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}