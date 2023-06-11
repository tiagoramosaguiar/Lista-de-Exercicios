namespace Atividade_15
{
    public partial class FormPrincipal : Form
    {

        Funcoes Funcoes = new Funcoes();
        int numeroAdicionalPessoas, mediaPessoasInicial = 120;
        double precoInicialIngresso = 5, precoMinimoIngresso = 1, custoSessao = 200;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void TextAdicional_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirInt(e);
        }

        private void ButtonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                numeroAdicionalPessoas = Convert.ToInt32(TextAdicional.Text);

                double lucroMaximo = 0;
                double melhorPrecoIngresso = 0;

                string tabelaLucro = "Preço do Ingresso (R$)\tPúblico\t\tLucro (R$)\n";

                for (double precoIngresso = precoInicialIngresso; precoIngresso >= precoMinimoIngresso; precoIngresso -= 0.50)
                {
                    int aumentoPublico = (int)((precoInicialIngresso - precoIngresso) / 0.50) * numeroAdicionalPessoas;
                    int publicoTotal = mediaPessoasInicial + aumentoPublico;
                    double lucro = (precoIngresso * publicoTotal) - custoSessao;

                    tabelaLucro += $"{precoIngresso:f}\t\t\t{publicoTotal}\t\t{lucro:f}\n";

                    if (lucro > lucroMaximo)
                    {
                        lucroMaximo = lucro;
                        melhorPrecoIngresso = precoIngresso;
                    }
                }

                string resultado = "Valor de ingresso que gera o maior lucro: R$ ";
                resultado += $"{melhorPrecoIngresso:f}.";

                MessageBox.Show($"{tabelaLucro}\n{resultado}", "Tabela de Lucro por Sessão");
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro! Preencha todos os campos.", "Preço dos ingressos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Erro! Valor inserido muito grande.", "Preço dos ingressos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}