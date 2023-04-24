namespace Atividade_12
{
    public partial class FormPrincipal : Form
    {

        Funcoes Funcoes = new Funcoes();
        double altura, pesoIdeal;
        char sexo;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void TextAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirDouble(TextAltura, e);
        }

        private void ButtonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (ComboSexo.SelectedIndex == -1)
                {
                    System.Media.SystemSounds.Hand.Play();
                    MessageBox.Show("Erro! Preencha todos os campos.", "Peso ideal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                altura = Convert.ToDouble(TextAltura.Text);
                sexo = ComboSexo.Text[0];

                if (sexo == 'M')
                {
                    pesoIdeal = (72.7 * altura) - 58;
                    MessageBox.Show($"Sexo: Masculino.\nPeso ideal: {pesoIdeal:f} KG.", "Peso ideal");
                }
                else if (sexo == 'F')
                {
                    pesoIdeal = (62.1 * altura) - 44.7;
                    MessageBox.Show($"Sexo: Feminino.\nPeso ideal: {pesoIdeal:f} KG.", "Peso ideal");
                }

                Funcoes.LimparControles(this);
                TextAltura.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro! Preencha todos os campos.", "Peso ideal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Erro! Valor inserido muito grande.", "Peso ideal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}