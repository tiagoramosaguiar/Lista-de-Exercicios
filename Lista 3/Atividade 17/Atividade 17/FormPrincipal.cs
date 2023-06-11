using System.Media;

namespace Atividade_17
{
    public partial class FormPrincipal : Form
    {

        Funcoes Funcoes = new Funcoes();
        int ocorrenciasTotais = 0, ocorrenciasClancy = 0, ocorrenciasEddie = 0, ocorrenciasLou = 0, ocorrenciasHomer = 0, ocorrenciasDirecaoPerigosa = 0;
        double percentualDirecaoPerigosa;
        string tipoOcorrencia = "", gravidadeOcorrencia = "", policialAtribuido = "";

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void ButtonRegistrar_Click(object sender, EventArgs e)
        {
            if (ComboTipo.SelectedIndex == -1)
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("Erro! Selecione o tipo de ocorr�ncia.", "Delegacia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ComboGravidade.SelectedIndex == -1)
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("Erro! Selecione a gravidade da ocorr�ncia.", "Delegacia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tipoOcorrencia = ComboTipo.Text;
            gravidadeOcorrencia = ComboGravidade.Text;

            if (tipoOcorrencia == "Homer")
            {
                ocorrenciasClancy++;
                ocorrenciasHomer++;
                policialAtribuido = "Clancy";
            }
            else if (ocorrenciasEddie <= ocorrenciasClancy && ocorrenciasEddie <= ocorrenciasLou)
            {
                ocorrenciasEddie++;
                policialAtribuido = "Eddie";
            }
            else if (ocorrenciasLou <= ocorrenciasClancy)
            {
                ocorrenciasLou++;
                policialAtribuido = "Lou";
            }
            else
            {
                ocorrenciasClancy++;
                policialAtribuido = "Clancy";
            }

            if (tipoOcorrencia == "Dire��o Perigosa")
            {
                ocorrenciasDirecaoPerigosa++;
            }

            ocorrenciasTotais++;
            percentualDirecaoPerigosa = (double)ocorrenciasDirecaoPerigosa / ocorrenciasTotais * 100;

            MessageBox.Show($"Ocorr�ncia atribu�da a: {policialAtribuido}\n\nOcorr�ncias de Clancy: {ocorrenciasClancy}\nOcorr�ncias de Eddie: {ocorrenciasEddie}\nOcorr�ncias de Lou: {ocorrenciasLou}\n\nOcorr�ncias do tipo Homer: {ocorrenciasHomer}\nOcorr�ncias totais: {ocorrenciasTotais}\nPercentual de ocorr�ncias de Dire��o Perigosa: {percentualDirecaoPerigosa:f}%", "Resumo");

            Funcoes.LimparControles(this);
            ComboTipo.Focus();
        }
    }
}