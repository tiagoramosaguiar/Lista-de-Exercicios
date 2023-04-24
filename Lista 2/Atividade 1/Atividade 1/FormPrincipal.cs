using System.Media;

namespace Atividade_1
{
    public partial class FormPrincipal : Form
    {

        Funcoes Funcoes = new Funcoes();
        string nomeAluno = "";
        double primeiraNota, segundaNota, mediaAluno;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void TextNomeAluno_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirString(e);
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
                nomeAluno = TextNomeAluno.Text;
                primeiraNota = Convert.ToDouble(TextPrimeiraNota.Text);
                segundaNota = Convert.ToDouble(TextSegundaNota.Text);

                if (string.IsNullOrWhiteSpace(nomeAluno) || nomeAluno.Trim().Length == 0)
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show("Erro! O nome deve estar preenchido.", "M�dia Aluno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (primeiraNota > 10 || segundaNota > 10)
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show("Erro! Nota inv�lida.", "M�dia Aluno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                mediaAluno = (primeiraNota + segundaNota) / 2;

                MessageBox.Show($"M�dia de {nomeAluno}: {mediaAluno:f} -> {(mediaAluno >= 7 ? "Aprovado." : "Reprovado.")}", "M�dia Aluno");
                Funcoes.LimparControles(this);
                TextNomeAluno.Focus();
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