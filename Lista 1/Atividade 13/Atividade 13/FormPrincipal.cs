namespace Atividade_13
{
    public partial class FormPrincipal : Form
    {

        Funcoes Funcoes = new Funcoes();
        int valorReais, quantNotas200, quantNotas100, quantNotas50, quantNotas20, quantNotas10, quantNotas5, quantNotas2, quantMoedas1;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void TextValorSaque_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirInt(e);
        }

        private void ButtonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                valorReais = Convert.ToInt32(TextValorSaque.Text);

                if (valorReais == 0)
                {
                    System.Media.SystemSounds.Hand.Play();
                    MessageBox.Show("Erro! O valor do saque deve ser diferente de zero.", "Saques", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                quantNotas200 = valorReais / 200;
                valorReais %= 200;

                quantNotas100 = valorReais / 100;
                valorReais %= 100;

                quantNotas50 = valorReais / 50;
                valorReais %= 50;

                quantNotas20 = valorReais / 20;
                valorReais %= 20;

                quantNotas10 = valorReais / 10;
                valorReais %= 10;

                quantNotas5 = valorReais / 5;
                valorReais %= 5;

                quantNotas2 = valorReais / 2;
                valorReais %= 2;

                quantMoedas1 = valorReais / 1;

                MessageBox.Show($"Notas a serem distribuídas:\n{quantNotas200} nota(s) de R$ 200,00.\n{quantNotas100} nota(s) de R$ 100,00.\n{quantNotas50} nota(s) de R$ 50,00.\n{quantNotas20} nota(s) de R$ 20,00.\n{quantNotas10} nota(s) de R$ 10,00.\n{quantNotas5} nota(s) de R$ 5,00.\n{quantNotas2} nota(s) de R$ 2,00.\n{quantMoedas1} moeda(s) de R$ 1,00.", "Saques");
                Funcoes.LimparControles(this);
                TextValorSaque.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro! Preencha todos os campos.", "Saques", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Erro! Valor inserido muito grande.", "Saques", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}