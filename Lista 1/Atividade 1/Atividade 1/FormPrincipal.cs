namespace Atividade_1
{
    public partial class FormPrincipal : Form
    {

        Funcoes Funcoes = new Funcoes();
        double larguraTerreno, comprimentoTerreno, areaTerreno;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void TextLarguraTerreno_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirDouble(TextLarguraTerreno, e);
        }

        private void TextComprimentoTerreno_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirDouble(TextComprimentoTerreno, e);
        }

        private void ButtonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                larguraTerreno = Convert.ToDouble(TextLarguraTerreno.Text);
                comprimentoTerreno = Convert.ToDouble(TextComprimentoTerreno.Text);

                if (larguraTerreno == 0 || comprimentoTerreno == 0)
                {
                    System.Media.SystemSounds.Hand.Play();
                    MessageBox.Show("Erro! Todos os campos devem ser diferentes de zero.", "Im�bilis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                areaTerreno = larguraTerreno * comprimentoTerreno;

                MessageBox.Show($"A �rea do terreno � de {areaTerreno:f} m�.", "Im�bilis");
                Funcoes.LimparControles(this);
                TextLarguraTerreno.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro! Preencha todos os campos.", "Im�bilis", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Erro! Valor inserido muito grande.", "Im�bilis", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}