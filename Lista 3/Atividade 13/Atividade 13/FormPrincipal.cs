using System.Media;

namespace Atividade_13
{
    public partial class FormPrincipal : Form
    {

        Funcoes Funcoes = new Funcoes();
        double numero, numeroAnterior, resultado = 0;
        string operador = "";
        int contagem = 0;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void TextNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirDoubleNegativo(TextNumero, e);
        }

        private void ButtonCalcular_Click(object sender, EventArgs e)
        {
            if (TextNumero.Text == "")
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("Erro! Preencha o campo \"N�mero\".", "Calculadora", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ComboOperacao.SelectedIndex == -1)
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("Erro! Selecione uma opera��o.", "Calculadora", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (double.TryParse(TextNumero.Text, out numero))
            {
                operador = ComboOperacao.Text;

                contagem++;

                if (contagem == 1)
                {
                    ComboOperacao.Items.AddRange(new object[] {"Multiplica��o", "Divis�o"});
                }

                switch (operador)
                {
                    case "Soma":
                        numeroAnterior = resultado;
                        resultado += numero;
                        MessageBox.Show($"Resultado da soma ({numeroAnterior} + {numero}): {resultado}.", "Calculadora");
                        break;
                    case "Subtra��o":
                        numeroAnterior = resultado;
                        resultado -= numero;
                        MessageBox.Show($"Resultado da subtra��o ({numeroAnterior} - {numero}): {resultado}.", "Calculadora");
                        break;
                    case "Multiplica��o":
                        numeroAnterior = resultado;
                        resultado *= numero;
                        MessageBox.Show($"Resultado da multiplica��o ({numeroAnterior} x {numero}): {resultado}.", "Calculadora");
                        break;
                    case "Divis�o":
                        if (numero != 0)
                        {
                            numeroAnterior = resultado;
                            resultado /= numero;
                            MessageBox.Show($"Resultado da divis�o ({numeroAnterior} � {numero}): {resultado}.", "Calculadora");
                        }
                        else
                        {
                            MessageBox.Show("Erro! Denominador deve ser diferente de zero.", "Calculadora", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        break;
                }

                Funcoes.LimparControles(this);
                TextNumero.Focus();
            }
        }

        private void ButtonReiniciar_Click(object sender, EventArgs e)
        {
            DialogResult resultadoUsuario = MessageBox.Show("Deseja mesmo reiniciar a calculadora?", "Calculadora", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultadoUsuario == DialogResult.Yes)
            {
                numero = 0;
                numeroAnterior = 0;
                resultado = 0;
                contagem = 0;
                operador = "";
                Funcoes.LimparControles(this);
                ComboOperacao.Items.Remove("Multiplica��o");
                ComboOperacao.Items.Remove("Divis�o");
                TextNumero.Focus();
            }
        }
    }
}