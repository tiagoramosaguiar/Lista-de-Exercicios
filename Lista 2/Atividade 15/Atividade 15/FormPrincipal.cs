namespace Atividade_15
{
    public partial class FormPrincipal : Form
    {

        Funcoes Funcoes = new Funcoes();
        double primeiraNota, segundaNota, mediaAluno;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void TextPrimeiraNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirDouble(TextPrimeiraNota, e);
        }

        private void TextSegundaNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirDouble(TextSegundaNota, e);
        }

        private void ButtonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                primeiraNota = Convert.ToDouble(TextPrimeiraNota.Text);
                segundaNota = Convert.ToDouble(TextSegundaNota.Text);

                if (primeiraNota > 10 || segundaNota > 10)
                {
                    System.Media.SystemSounds.Hand.Play();
                    MessageBox.Show("Erro! Nota inv�lida.", "M�dia Aluno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                mediaAluno = (primeiraNota + segundaNota) / 2;

                if (mediaAluno == 10)
                {
                    MessageBox.Show($"M�dia {mediaAluno:f} -> Aprovado com distin��o.", "M�dia Aluno");
                }
                else if (mediaAluno >= 7)
                {
                    MessageBox.Show($"M�dia {mediaAluno:f} -> Aprovado.", "M�dia Aluno");
                }
                else if (mediaAluno >= 3 && mediaAluno < 7)
                {
                    MessageBox.Show($"M�dia {mediaAluno:f} -> Exame.", "M�dia Aluno");
                }
                else if (mediaAluno < 3)
                {
                    MessageBox.Show($"M�dia {mediaAluno:f} -> Reprovado.", "M�dia Aluno");
                }

                Funcoes.LimparControles(this);
                TextPrimeiraNota.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro! Preencha todos os campos.", "M�dia Aluno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Erro! Valor inserido muito grande.", "M�dia Aluno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}