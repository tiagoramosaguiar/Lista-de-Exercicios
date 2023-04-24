namespace Atividade_17
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TextPrecoProduto=new TextBox();
            ComboCondicaoPagamento=new ComboBox();
            ButtonCalcular=new Button();
            LabelPrecoProduto=new Label();
            LabelCondicaoPagamento=new Label();
            SuspendLayout();
            // 
            // TextPrecoProduto
            // 
            TextPrecoProduto.BackColor=Color.FromArgb(246, 246, 246);
            TextPrecoProduto.Location=new Point(92, 80);
            TextPrecoProduto.Name="TextPrecoProduto";
            TextPrecoProduto.Size=new Size(100, 23);
            TextPrecoProduto.TabIndex=0;
            TextPrecoProduto.TextAlign=HorizontalAlignment.Center;
            TextPrecoProduto.KeyPress+=TextPrecoProduto_KeyPress;
            // 
            // ComboCondicaoPagamento
            // 
            ComboCondicaoPagamento.BackColor=Color.FromArgb(246, 246, 246);
            ComboCondicaoPagamento.DropDownStyle=ComboBoxStyle.DropDownList;
            ComboCondicaoPagamento.FormattingEnabled=true;
            ComboCondicaoPagamento.Items.AddRange(new object[] { "1", "2", "3", "4" });
            ComboCondicaoPagamento.Location=new Point(92, 133);
            ComboCondicaoPagamento.Name="ComboCondicaoPagamento";
            ComboCondicaoPagamento.Size=new Size(100, 23);
            ComboCondicaoPagamento.TabIndex=1;
            // 
            // ButtonCalcular
            // 
            ButtonCalcular.BackColor=Color.FromArgb(246, 246, 246);
            ButtonCalcular.Location=new Point(104, 171);
            ButtonCalcular.Name="ButtonCalcular";
            ButtonCalcular.Size=new Size(75, 23);
            ButtonCalcular.TabIndex=2;
            ButtonCalcular.Text="Calcular";
            ButtonCalcular.UseVisualStyleBackColor=false;
            ButtonCalcular.Click+=ButtonCalcular_Click;
            // 
            // LabelPrecoProduto
            // 
            LabelPrecoProduto.AutoSize=true;
            LabelPrecoProduto.ForeColor=Color.FromArgb(246, 246, 246);
            LabelPrecoProduto.Location=new Point(92, 62);
            LabelPrecoProduto.Name="LabelPrecoProduto";
            LabelPrecoProduto.Size=new Size(100, 15);
            LabelPrecoProduto.TabIndex=3;
            LabelPrecoProduto.Text="Preço do produto";
            // 
            // LabelCondicaoPagamento
            // 
            LabelCondicaoPagamento.AutoSize=true;
            LabelCondicaoPagamento.ForeColor=Color.FromArgb(246, 246, 246);
            LabelCondicaoPagamento.Location=new Point(74, 115);
            LabelCondicaoPagamento.Name="LabelCondicaoPagamento";
            LabelCondicaoPagamento.Size=new Size(138, 15);
            LabelCondicaoPagamento.TabIndex=4;
            LabelCondicaoPagamento.Text="Condiçao de pagamento";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.FromArgb(66, 66, 66);
            ClientSize=new Size(284, 261);
            Controls.Add(LabelCondicaoPagamento);
            Controls.Add(LabelPrecoProduto);
            Controls.Add(ButtonCalcular);
            Controls.Add(ComboCondicaoPagamento);
            Controls.Add(TextPrecoProduto);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            Name="FormPrincipal";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Pagamentos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextPrecoProduto;
        private ComboBox ComboCondicaoPagamento;
        private Button ButtonCalcular;
        private Label LabelPrecoProduto;
        private Label LabelCondicaoPagamento;
    }
}