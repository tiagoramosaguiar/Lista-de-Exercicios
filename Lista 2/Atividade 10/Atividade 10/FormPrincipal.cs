namespace Atividade_10
{
    public partial class FormPrincipal : Form
    {

        Funcoes Funcoes = new Funcoes();
        double ladoA, ladoB, ladoC;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void TextLadoA_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirDouble(TextLadoA, e);
        }

        private void TextLadoB_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirDouble(TextLadoB, e);
        }

        private void TextLadoC_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirDouble(TextLadoC, e);
        }

        private void ButtonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                ladoA = Convert.ToDouble(TextLadoA.Text);
                ladoB = Convert.ToDouble(TextLadoB.Text);
                ladoC = Convert.ToDouble(TextLadoC.Text);

                if (ladoA == ladoB && ladoB == ladoC)
                {
                    MessageBox.Show("O tri�ngulo � equil�tero (possui tr�s lados iguais).", "Lado do tri�ngulo");
                }
                else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
                {
                    MessageBox.Show("O tri�ngulo � is�sceles (possui dois lados iguais).", "Lado do tri�ngulo");
                }
                else
                {
                    MessageBox.Show("O tri�ngulo � escaleno (n�o possui lados iguais).", "Lado do tri�ngulo");
                }

                Funcoes.LimparControles(this);
                TextLadoA.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro! Preencha todos os campos.", "Lado do tri�ngulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Erro! Valor inserido muito grande.", "Lado do tri�ngulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}