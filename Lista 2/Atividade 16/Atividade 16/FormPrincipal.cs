using System.Media;

namespace Atividade_16
{
    public partial class FormPrincipal : Form
    {

        Funcoes Funcoes = new Funcoes();
        double primeiraNota, segundaNota, terceiraNota, notaExame, mediaAluno;

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

        private void TextTerceiraNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirDouble(TextTerceiraNota, e);
        }

        private void TextNotaExame_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirDouble(TextTerceiraNota, e);
        }

        private void ButtonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                primeiraNota = Convert.ToDouble(TextPrimeiraNota.Text);
                segundaNota = Convert.ToDouble(TextSegundaNota.Text);
                terceiraNota = Convert.ToDouble(TextTerceiraNota.Text);

                if (primeiraNota > 10 || segundaNota > 10 || terceiraNota > 10)
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show("Erro! Nota inválida.", "Média Aluno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                mediaAluno = (primeiraNota + segundaNota + terceiraNota) / 3;

                if (mediaAluno >= 7)
                {
                    MessageBox.Show($"Média {mediaAluno:f} -> Aprovado.", "Média Aluno");
                    Funcoes.LimparControles(this);
                    TextPrimeiraNota.Focus();
                }
                else if (mediaAluno >= 3 && mediaAluno < 7)
                {
                    MessageBox.Show($"Média {mediaAluno:f} -> Você está em exame.", "Média Aluno");
                    LabelPrimeiraNota.Location = new Point(45, 37);
                    LabelPrimeiraNota.Enabled = false;
                    TextPrimeiraNota.Location = new Point(34, 55);
                    TextPrimeiraNota.Enabled = false;

                    LabelSegundaNota.Location = new Point(44, 90);
                    LabelSegundaNota.Enabled = false;
                    TextSegundaNota.Location = new Point(34, 108);
                    TextSegundaNota.Enabled = false;

                    LabelTerceiraNota.Location = new Point(47, 143);
                    LabelTerceiraNota.Enabled = false;
                    TextTerceiraNota.Location = new Point(34, 161);
                    TextTerceiraNota.Enabled = false;

                    ButtonCalcular.Location = new Point(46, 199);
                    ButtonCalcular.Enabled = false;

                    LabelNotaExame.Location = new Point(162, 90);
                    LabelNotaExame.Visible = true;

                    TextNotaExame.Location = new Point(156, 108);
                    TextNotaExame.Text = "";
                    TextNotaExame.Visible = true;
                    TextNotaExame.Focus();

                    ButtonRecalcular.Location = new Point(169, 146);
                    ButtonRecalcular.Visible = true;
                }
                else if (mediaAluno < 3)
                {
                    MessageBox.Show($"Média {mediaAluno:f} -> Reprovado sem direito a exame.", "Média Aluno");
                    Funcoes.LimparControles(this);
                    TextPrimeiraNota.Focus();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro! Preencha todos os campos.", "Média Aluno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Erro! Valor inserido muito grande.", "Média Aluno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonRecalcular_Click(object sender, EventArgs e)
        {
            try
            {
                notaExame = Convert.ToDouble(TextNotaExame.Text);

                if (notaExame > 10)
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show("Erro! Nota inválida.", "Média Aluno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                mediaAluno = (notaExame + mediaAluno) / 2;

                if (mediaAluno >= 5)
                {
                    MessageBox.Show($"Média {mediaAluno:f} -> Aprovado no exame.", "Média Aluno");
                }
                else
                {
                    MessageBox.Show($"Média {mediaAluno:f} -> Reprovado no exame.", "Média Aluno");
                }

                LabelPrimeiraNota.Location = new Point(104, 38);
                LabelPrimeiraNota.Enabled = true;
                TextPrimeiraNota.Location =new Point(93, 56);
                TextPrimeiraNota.Enabled = true;
                TextPrimeiraNota.Text = "";

                LabelSegundaNota.Location = new Point(103, 91);
                LabelSegundaNota.Enabled = true;
                TextSegundaNota.Enabled = true;
                TextSegundaNota.Location = new Point(93, 109);
                TextSegundaNota.Text = "";

                LabelTerceiraNota.Location = new Point(106, 144);
                LabelTerceiraNota.Enabled = true;
                TextTerceiraNota.Location = new Point(93, 162);
                TextTerceiraNota.Enabled = true;
                TextTerceiraNota.Text = "";

                ButtonCalcular.Location = new Point(105, 200);
                ButtonCalcular.Enabled = true;

                LabelNotaExame.Visible = false;
                TextNotaExame.Visible = false;
                ButtonRecalcular.Visible = false;
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro! Preencha todos os campos.", "Média Aluno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Erro! Valor inserido muito grande.", "Média Aluno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}