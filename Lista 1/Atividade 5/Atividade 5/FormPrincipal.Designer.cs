namespace Atividade_5
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
            LabelPrecoLitro=new Label();
            TextPrecoLitro=new TextBox();
            LabelValorPagamento=new Label();
            TextValorPagamento=new TextBox();
            ButtonCalcular=new Button();
            SuspendLayout();
            // 
            // LabelPrecoLitro
            // 
            LabelPrecoLitro.AutoSize=true;
            LabelPrecoLitro.ForeColor=Color.FromArgb(246, 246, 246);
            LabelPrecoLitro.Location=new Point(73, 65);
            LabelPrecoLitro.Name="LabelPrecoLitro";
            LabelPrecoLitro.Size=new Size(141, 15);
            LabelPrecoLitro.TabIndex=3;
            LabelPrecoLitro.Text="Preço do litro de gasolina";
            // 
            // TextPrecoLitro
            // 
            TextPrecoLitro.BackColor=Color.FromArgb(246, 246, 246);
            TextPrecoLitro.Location=new Point(92, 83);
            TextPrecoLitro.Name="TextPrecoLitro";
            TextPrecoLitro.Size=new Size(100, 23);
            TextPrecoLitro.TabIndex=0;
            TextPrecoLitro.TextAlign=HorizontalAlignment.Center;
            TextPrecoLitro.KeyPress+=TextPrecoLitro_KeyPress;
            // 
            // LabelValorPagamento
            // 
            LabelValorPagamento.AutoSize=true;
            LabelValorPagamento.ForeColor=Color.FromArgb(246, 246, 246);
            LabelValorPagamento.Location=new Point(86, 118);
            LabelValorPagamento.Name="LabelValorPagamento";
            LabelValorPagamento.Size=new Size(114, 15);
            LabelValorPagamento.TabIndex=4;
            LabelValorPagamento.Text="Valor do pagamento";
            // 
            // TextValorPagamento
            // 
            TextValorPagamento.BackColor=Color.FromArgb(246, 246, 246);
            TextValorPagamento.Location=new Point(92, 136);
            TextValorPagamento.Name="TextValorPagamento";
            TextValorPagamento.Size=new Size(100, 23);
            TextValorPagamento.TabIndex=1;
            TextValorPagamento.TextAlign=HorizontalAlignment.Center;
            TextValorPagamento.KeyPress+=TextValorPagamento_KeyPress;
            // 
            // ButtonCalcular
            // 
            ButtonCalcular.BackColor=Color.FromArgb(246, 246, 246);
            ButtonCalcular.Location=new Point(104, 174);
            ButtonCalcular.Name="ButtonCalcular";
            ButtonCalcular.Size=new Size(75, 23);
            ButtonCalcular.TabIndex=2;
            ButtonCalcular.Text="Calcular";
            ButtonCalcular.UseVisualStyleBackColor=false;
            ButtonCalcular.Click+=ButtonCalcular_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.FromArgb(66, 66, 66);
            ClientSize=new Size(284, 261);
            Controls.Add(LabelPrecoLitro);
            Controls.Add(TextPrecoLitro);
            Controls.Add(LabelValorPagamento);
            Controls.Add(TextValorPagamento);
            Controls.Add(ButtonCalcular);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            Name="FormPrincipal";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Litros Abastecidos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelPrecoLitro;
        private TextBox TextPrecoLitro;
        private Label LabelValorPagamento;
        private TextBox TextValorPagamento;
        private Button ButtonCalcular;
    }
}