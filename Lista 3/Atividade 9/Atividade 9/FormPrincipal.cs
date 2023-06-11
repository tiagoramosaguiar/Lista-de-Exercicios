namespace Atividade_9
{
    public partial class FormPrincipal : Form
    {

        Funcoes Funcoes = new Funcoes();
        int idade, quant0a17, quant18a35, quant35a50, quant50a65, quant65mais, total;
        double percent0a17, percent18a35, percent35a50, percent50a65, percent65mais;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void TextIdade_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.PermitirInt(e);
        }

        private void ButtonSomar_Click(object sender, EventArgs e)
        {
            while (int.TryParse(TextIdade.Text, out idade))
            {
                if (idade <= 17)
                {
                    quant0a17++;
                }
                else if (idade <= 35)
                {
                    quant18a35++;
                }
                else if (idade <= 50)
                {
                    quant35a50++;
                }
                else if (idade <= 65)
                {
                    quant50a65++;
                }
                else
                {
                    quant65mais++;
                }

                total++;
                TextIdade.Clear();
                TextIdade.Focus();
            }

            if (total > 0)
            {
                percent0a17 = ((double)quant0a17 / total) * 100;
                percent18a35 = ((double)quant18a35 / total) * 100;
                percent35a50 = ((double)quant35a50 / total) * 100;
                percent50a65 = ((double)quant50a65 / total) * 100;
                percent65mais = ((double)quant65mais / total) * 100;
            }

            ButtonMostrarSoma.Enabled = true;
        }

        private void ButtonMostrarSoma_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"0 a 17 anos: {percent0a17:f}%\n18 a 35 anos: {percent18a35:f}%\n35 a 50 anos: {percent35a50:f}%\n50 a 65 anos: {percent50a65:f}%\n65 anos ou mais: {percent65mais:f}%", "Percentual de idades");
            TextIdade.Focus();
        }

        private void ButtonReiniciar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja mesmo reiniciar?", "Percentual de idades", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                idade = 0;
                quant0a17 = 0;
                quant18a35 = 0;
                quant35a50 = 0;
                quant50a65 = 0;
                quant65mais = 0;
                total = 0;
                percent0a17 = 0;
                percent18a35 = 0;
                percent35a50 = 0;
                percent50a65 = 0;
                percent65mais = 0;
                Funcoes.LimparControles(this);
                TextIdade.Focus();
            }
        }
    }
}