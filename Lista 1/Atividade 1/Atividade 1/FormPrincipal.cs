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
                    MessageBox.Show("Erro! Todos os campos devem ser diferentes de zero.", "Imóbilis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                areaTerreno = larguraTerreno * comprimentoTerreno;

                MessageBox.Show($"A área do terreno é de {areaTerreno:f} m².", "Imóbilis");
                Funcoes.LimparControles(this);
                TextLarguraTerreno.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro! Preencha todos os campos.", "Imóbilis", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Erro! Valor inserido muito grande.", "Imóbilis", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}