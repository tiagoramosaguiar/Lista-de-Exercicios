namespace Atividade_14
{
    public partial class FormPrincipal : Form
    {

        Funcoes Funcoes = new Funcoes();
        double X1, Y1, X2, Y2, distancia;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void TextX1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirDouble(TextX1, e);
        }

        private void TextY1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirDouble(TextY2, e);
        }

        private void TextX2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirDouble(TextX2, e);
        }

        private void TextY2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirDouble(TextY2, e);
        }

        private void ButtonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                X1 = Convert.ToDouble(TextX1.Text);
                Y1 = Convert.ToDouble(TextY1.Text);
                X2 = Convert.ToDouble(TextX2.Text);
                Y2 = Convert.ToDouble(TextY2.Text);

                distancia = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));

                MessageBox.Show($"A distância entre os pontos ({X2:f}, {X1:f}) e ({Y2:f}, {Y1:f}) é de {distancia:f}.", "Distância no plano cartesiano");
                Funcoes.LimparControles(this);
                TextX1.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro! Preencha todos os campos.", "Distância no plano cartesiano", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Erro! Valor inserido muito grande.", "Distância no plano cartesiano", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}