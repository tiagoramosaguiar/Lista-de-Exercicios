namespace Atividade_4
{
    public partial class FormPrincipal : Form
    {

        Funcoes Funcoes = new Funcoes();
        double salario;
        int tempoServico;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void TextSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirDouble(TextSalario, e);
        }

        private void TextTempoServico_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirInt(e);
        }

        private void ButtonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                salario = Convert.ToDouble(TextSalario.Text);
                tempoServico = Convert.ToInt32(TextTempoServico.Text);

                salario *= (tempoServico >= 5) ? 0.2 : 0.1;

                MessageBox.Show($"Valor do bônus recebido por {tempoServico} ano(s) de serviço: R$ {salario:f}.", "XKW");
                Funcoes.LimparControles(this);
                TextSalario.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro! Preencha todos os campos.", "XKW", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Erro! Valor inserido muito grande.", "XKW", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}