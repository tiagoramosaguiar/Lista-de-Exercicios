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
                MessageBox.Show("Erro! Selecione o tipo de ocorrência.", "Delegacia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ComboGravidade.SelectedIndex == -1)
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("Erro! Selecione a gravidade da ocorrência.", "Delegacia", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (tipoOcorrencia == "Direção Perigosa")
            {
                ocorrenciasDirecaoPerigosa++;
            }

            ocorrenciasTotais++;
            percentualDirecaoPerigosa = (double)ocorrenciasDirecaoPerigosa / ocorrenciasTotais * 100;

            MessageBox.Show($"Ocorrência atribuída a: {policialAtribuido}\n\nOcorrências de Clancy: {ocorrenciasClancy}\nOcorrências de Eddie: {ocorrenciasEddie}\nOcorrências de Lou: {ocorrenciasLou}\n\nOcorrências do tipo Homer: {ocorrenciasHomer}\nOcorrências totais: {ocorrenciasTotais}\nPercentual de ocorrências de Direção Perigosa: {percentualDirecaoPerigosa:f}%", "Resumo");

            Funcoes.LimparControles(this);
            ComboTipo.Focus();
        }
    }
}