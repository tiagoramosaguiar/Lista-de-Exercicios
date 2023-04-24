namespace Atividade_11
{
    public partial class FormPrincipal : Form
    {

        Funcoes Funcoes = new Funcoes();
        int idade;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void TextIdade_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirInt(e);
        }

        private void ButtonVerPreco_Click(object sender, EventArgs e)
        {
            try
            {
                idade = Convert.ToInt32(TextIdade.Text);

                if (idade <= 10)
                {
                    MessageBox.Show($"Idade: {idade}.\nValor: R$ 30,00.", "Planos de saúde");
                }
                else if (idade < 30)
                {
                    MessageBox.Show($"Idade: {idade}.\nValor: R$ 60,00.", "Planos de saúde");
                }
                else if (idade < 46)
                {
                    MessageBox.Show($"Idade: {idade}.\nValor: R$ 120,00.", "Planos de saúde");
                }
                else if (idade <= 59)
                {
                    MessageBox.Show($"Idade: {idade}.\nValor: R$ 150,00.", "Planos de saúde");
                }
                else if (idade >= 60)
                {
                    MessageBox.Show($"Idade: {idade}.\nValor: R$ 300,00.", "Planos de saúde");
                }

                Funcoes.LimparControles(this);
                TextIdade.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro! Preencha todos os campos.", "Planos de saúde", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Erro! Valor inserido muito grande.", "Planos de saúde", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}