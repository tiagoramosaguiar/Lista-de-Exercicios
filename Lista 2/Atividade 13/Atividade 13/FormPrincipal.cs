namespace Atividade_13
{
    public partial class FormPrincipal : Form
    {

        Funcoes Funcoes = new Funcoes();
        int horaEntrada, minutoEntrada, horaSaida, minutoSaida, tempoEstacionado, tempoTotal;
        double valorPeriodo;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void TextHoraEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirInt(e);
        }

        private void TextHoraSaida_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirInt(e);
        }

        private void TextMinutoEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirInt(e);
        }

        private void TextMinutoSaida_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirInt(e);
        }

        private void ButtonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                horaEntrada = Convert.ToInt32(TextHoraEntrada.Text);
                minutoEntrada = Convert.ToInt32(TextMinutoEntrada.Text);
                horaSaida = Convert.ToInt32(TextHoraSaida.Text);
                minutoSaida = Convert.ToInt32(TextMinutoSaida.Text);

                if (horaEntrada < 0 || horaEntrada > 23 || minutoEntrada < 0 || minutoEntrada > 59 || horaSaida < 0 || horaSaida > 23 || minutoSaida < 0 || minutoSaida > 59)
                {
                    System.Media.SystemSounds.Hand.Play();
                    MessageBox.Show("Erro! Horário inválido.", "Estacionamento");
                    return;
                }

                if (horaSaida < horaEntrada || (horaSaida == horaEntrada && minutoSaida < minutoEntrada))
                {
                    horaSaida += 24;
                }

                tempoTotal = (horaSaida - horaEntrada) * 60 + (minutoSaida - minutoEntrada);

                if (tempoTotal == 0)
                {
                    tempoEstacionado = 1;
                }
                else
                {
                    tempoEstacionado = tempoTotal / 60;

                    if (tempoTotal % 60 > 0)
                    {
                        tempoEstacionado += 1;
                    }
                }

                if (tempoEstacionado == 1)
                {
                    valorPeriodo = 4;
                }
                else if (tempoEstacionado == 2)
                {
                    valorPeriodo = 6;
                }
                else
                {
                    valorPeriodo = 6 + (tempoEstacionado - 2) * 1;
                }

                MessageBox.Show($"O valor a ser pago pelo período de estacionamento é de R$ {valorPeriodo:f}.", "Estacionamento");
                Funcoes.LimparControles(this);
                TextHoraEntrada.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro! Preencha todos os campos.", "Estacionamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Erro! Valor inserido muito grande.", "Estacionamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}