using System.Media;

namespace Atividade_18
{
    public partial class FormPrincipal : Form
    {

        Funcoes Funcoes = new Funcoes();
        int tamanho;
        string opcao = "", desenho = "";

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void TextTamanho_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirInt(e);
        }

        private void ButtonDesenhar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ComboFigura.SelectedIndex == -1)
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show("Erro! Selecione o tipo de figura.", "Desenho", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                opcao = ComboFigura.Text;
                tamanho = Convert.ToInt32(TextTamanho.Text);

                if (tamanho == 0)
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show("Erro! O tamanho da figura deve ser diferente de zero.", "Desenho", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (opcao == "Losango")
                {
                    desenho = desenharLosango(tamanho);
                    MessageBox.Show(desenho, "Losango");
                }
                else if (opcao == "Triângulo")
                {
                    desenho = desenharTriangulo(tamanho);
                    MessageBox.Show(desenho, "Triângulo");
                }

                Funcoes.LimparControles(this);
                ComboFigura.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro! Preencha todos os campos.", "Desenho", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Erro! Valor inserido muito grande.", "Desenho", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string desenharLosango(int tamanho)
        {
            desenho = "";

            for (int i = 0; i < tamanho; i++)
            {
                desenho += new string(' ', tamanho - i - 1);
                desenho += new string('%', 2 * i + 1);
                desenho += "\n";
            }

            for (int i = tamanho - 2; i >= 0; i--)
            {
                desenho += new string(' ', tamanho - i - 1);
                desenho += new string('%', 2 * i + 1);
                desenho += "\n";
            }

            return desenho;
        }

        public string desenharTriangulo(int tamanho)
        {
            desenho = "";

            for (int i = 0; i < tamanho; i++)
            {
                desenho += new string(' ', tamanho - i - 1);
                desenho += new string('%', 2 * i + 1);
                desenho += "\n";
            }

            return desenho;
        }
    }
}