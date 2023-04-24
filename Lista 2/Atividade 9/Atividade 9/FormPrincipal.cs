namespace Atividade_9
{
    public partial class FormPrincipal : Form
    {

        Funcoes Funcoes = new Funcoes();
        double totalVendido, comissao, salarioBruto;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void TextTotalVendido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirDouble(TextTotalVendido, e);
        }

        private void ButtonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                totalVendido = Convert.ToDouble(TextTotalVendido.Text);
                comissao = 0;
                salarioBruto = 1200;

                if (totalVendido > 2000)
                {
                    comissao = totalVendido * 0.1;
                    salarioBruto += comissao;
                }

                MessageBox.Show($"Sal�rio bruto: R$ {salarioBruto:f}.\nComiss�o: R$ {comissao:f}.", "Comiss�o");
                Funcoes.LimparControles(this);
                TextTotalVendido.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro! Preencha todos os campos.", "Comiss�o", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Erro! Valor inserido muito grande.", "Comiss�o", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}