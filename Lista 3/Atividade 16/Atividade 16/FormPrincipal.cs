namespace Atividade_16
{
    public partial class FormPrincipal : Form
    {
        Funcoes Funcoes = new Funcoes();
        string jogadorAtual = "", proximoJogador = "", vencedor = "";
        int contadorJogadas = 0, vitoriasX = 0, vitoriasO = 0, totalVitorias = 0, empates = 0;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            Funcoes.DesativarTabIndexes(this.Controls);
        }

        public string AlterarJogador()
        {
            if (jogadorAtual == "X")
            {
                jogadorAtual = "O";
            }
            else
            {
                jogadorAtual = "X";
            }

            return jogadorAtual;
        }

        private string ProximoJogador()
        {
            proximoJogador = AlterarJogador();
            AlterarJogador();
            return proximoJogador;
        }

        private string VerificarVencedor()
        {
            string[,] simbolos = new string[4, 4];

            simbolos[1, 1] = Button1.Text;
            simbolos[1, 2] = Button2.Text;
            simbolos[1, 3] = Button3.Text;
            simbolos[2, 1] = Button4.Text;
            simbolos[2, 2] = Button5.Text;
            simbolos[2, 3] = Button6.Text;
            simbolos[3, 1] = Button7.Text;
            simbolos[3, 2] = Button8.Text;
            simbolos[3, 3] = Button9.Text;

            for (int i = 1; i <= 3; i++)
            {
                if (simbolos[i, 1] == simbolos[i, 2] && simbolos[i, 2] == simbolos[i, 3] && !string.IsNullOrEmpty(simbolos[i, 1]))
                    return simbolos[i, 1];
            }

            for (int i = 1; i <= 3; i++)
            {
                if (simbolos[1, i] == simbolos[2, i] && simbolos[2, i] == simbolos[3, i] && !string.IsNullOrEmpty(simbolos[1, i]))
                    return simbolos[1, i];
            }

            if ((simbolos[1, 1] == simbolos[2, 2] && simbolos[2, 2] == simbolos[3, 3] && !string.IsNullOrEmpty(simbolos[1, 1])) ||
                (simbolos[1, 3] == simbolos[2, 2] && simbolos[2, 2] == simbolos[3, 1] && !string.IsNullOrEmpty(simbolos[1, 3])))
                return simbolos[2, 2];

            return "continua";
        }

        private void ProximaRodada()
        {
            totalVitorias = vitoriasX + vitoriasO;
            if (totalVitorias % 2 == 0)
            {
                jogadorAtual = "O";
                LabelJogador.Text = $"Vez de: {ProximoJogador()}";
            }
            else
            {
                jogadorAtual = "X";
                LabelJogador.Text = $"Vez de: {ProximoJogador()}";
            }
        }

        private void ProximaRodadaInversa()
        {
            totalVitorias = vitoriasX + vitoriasO;
            if (totalVitorias % 2 == 0)
            {
                jogadorAtual = "X";
                LabelJogador.Text = $"Vez de: {ProximoJogador()}";
            }
            else
            {
                jogadorAtual = "O";
                LabelJogador.Text = $"Vez de: {ProximoJogador()}";
            }
        }

        private void ReiniciarTabuleiro()
        {
            contadorJogadas = 0;
            Button1.Text = "";
            Button1.Enabled = true;
            Button2.Text = "";
            Button2.Enabled = true;
            Button3.Text = "";
            Button3.Enabled = true;
            Button4.Text = "";
            Button4.Enabled = true;
            Button5.Text = "";
            Button5.Enabled = true;
            Button6.Text = "";
            Button6.Enabled = true;
            Button7.Text = "";
            Button7.Enabled = true;
            Button8.Text = "";
            Button8.Enabled = true;
            Button9.Text = "";
            Button9.Enabled = true;
            LabelJogador.Text = $"Vez de: {ProximoJogador()}";
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "")
            {
                button.Text = AlterarJogador();
                button.Enabled = false;

                contadorJogadas++;

                vencedor = VerificarVencedor();
                if (vencedor != "continua")
                {
                    MessageBox.Show($"\"{vencedor}\" foi o vencedor!", "Resultado");

                    if (vencedor == "X")
                    {
                        vitoriasX++;
                        LabelVitoriasX.Text = $"X: {vitoriasX}";
                    }
                    else
                    {
                        vitoriasO++;
                        LabelVitoriasO.Text = $"O: {vitoriasO}";
                    }

                    ReiniciarTabuleiro();

                    if (empates % 2 == 0)
                    {
                        ProximaRodada();
                    }
                    else
                    {
                        ProximaRodadaInversa();
                    }
                }
                else if (contadorJogadas == 9)
                {
                    MessageBox.Show("Empate!", "Resultado");
                    ReiniciarTabuleiro();

                    empates++;

                    if (empates % 2 == 0)
                    {
                        ProximaRodada();
                    }
                    else
                    {
                        ProximaRodadaInversa();
                    }
                }
                else
                {
                    LabelJogador.Text = $"Vez de: {ProximoJogador()}";
                }
            }
        }

        private void ButtonReiniciarJogo_Click(object sender, EventArgs e)
        {
            DialogResult resultadoDialogo = MessageBox.Show("Deseja mesmo reiniciar o jogo?", "Reiniciar jogo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultadoDialogo == DialogResult.Yes)
            {
                ReiniciarTabuleiro();
                if (empates % 2 == 0)
                {
                    ProximaRodada();
                }
                else
                {
                    ProximaRodadaInversa();
                }
            }
        }
    }
}