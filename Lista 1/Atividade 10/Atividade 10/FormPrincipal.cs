namespace Atividade_10
{
    public partial class FormPrincipal : Form
    {

        Funcoes Funcoes = new Funcoes();
        double kmViagem, kmLitro, precoLitro, litrosGastos, valorTotal;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void TextKMViagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirDouble(TextKMViagem, e);
        }

        private void TextKMLitro_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirDouble(TextKMLitro, e);
        }

        private void TextPrecoLitro_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirDouble(TextPrecoLitro, e);
        }

        private void ButtonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                kmViagem = Convert.ToDouble(TextKMViagem.Text);
                kmLitro = Convert.ToDouble(TextKMLitro.Text);
                precoLitro = Convert.ToDouble(TextPrecoLitro.Text);

                if (kmViagem == 0 || kmLitro == 0 || precoLitro == 0)
                {
                    System.Media.SystemSounds.Hand.Play();
                    MessageBox.Show("Erro! Todos os campos devem ser diferentes de zero.", "Viagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                litrosGastos = kmViagem / kmLitro;
                valorTotal = litrosGastos * precoLitro;

                MessageBox.Show($"Serão gastos {litrosGastos:f} litros de combustível com a viagem.\n\nSerão gastos R$ {valorTotal:f} com combustível.", "Viagem");
                Funcoes.LimparControles(this);
                TextKMViagem.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro! Preencha todos os campos.", "Viagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Erro! Valor inserido muito grande.", "Viagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}