namespace Atividade_14
{
    public partial class FormPrincipal : Form
    {

        Funcoes Funcoes = new Funcoes();
        char combustivel;
        double capacidadeTanque, precoLitro, valorTotal;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void TextCapacidadeTanque_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirDouble(TextCapacidadeTanque, e);
        }

        private void ButtonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (ComboCombustivel.SelectedIndex == -1)
                {
                    System.Media.SystemSounds.Hand.Play();
                    MessageBox.Show("Erro! Selecione o tipo de combustível.", "Tanque cheio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                combustivel = ComboCombustivel.Text[0];
                capacidadeTanque = Convert.ToDouble(TextCapacidadeTanque.Text);

                if (capacidadeTanque == 0)
                {
                    MessageBox.Show("Erro! Capacidade do tanque deve ser diferente de zero.", "Tanque cheio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                precoLitro = combustivel == 'G' ? 1.80 : 1.00;
                valorTotal = capacidadeTanque * precoLitro;

                MessageBox.Show($"O valor total do abastecimento é de R$ {valorTotal:f}.", "Tanque cheio");
                Funcoes.LimparControles(this);
                ComboCombustivel.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro! Preencha todos os campos.", "Tanque cheio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Erro! Valor inserido muito grande.", "Tanque cheio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}