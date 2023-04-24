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
            LabelValorEmprestimo=new Label();
            TextValorEmprestimo=new TextBox();
            LabelNumeroParcelas=new Label();
            TextNumeroParcelas=new TextBox();
            LabelSalarioSolicitante=new Label();
            TextSalarioSolicitante=new TextBox();
            ButtonCalcular=new Button();
            SuspendLayout();
            // 
            // LabelValorEmprestimo
            // 
            LabelValorEmprestimo.AutoSize=true;
            LabelValorEmprestimo.ForeColor=Color.FromArgb(246, 246, 246);
            LabelValorEmprestimo.Location=new Point(85, 38);
            LabelValorEmprestimo.Name="LabelValorEmprestimo";
            LabelValorEmprestimo.Size=new Size(117, 15);
            LabelValorEmprestimo.TabIndex=4;
            LabelValorEmprestimo.Text="Valor do empréstimo";
            // 
            // TextValorEmprestimo
            // 
            TextValorEmprestimo.BackColor=Color.FromArgb(246, 246, 246);
            TextValorEmprestimo.BorderStyle=BorderStyle.FixedSingle;
            TextValorEmprestimo.Location=new Point(93, 56);
            TextValorEmprestimo.Name="TextValorEmprestimo";
            TextValorEmprestimo.Size=new Size(100, 23);
            TextValorEmprestimo.TabIndex=0;
            TextValorEmprestimo.TextAlign=HorizontalAlignment.Center;
            TextValorEmprestimo.KeyPress+=TextValorEmprestimo_KeyPress;
            // 
            // LabelNumeroParcelas
            // 
            LabelNumeroParcelas.AutoSize=true;
            LabelNumeroParcelas.ForeColor=Color.FromArgb(246, 246, 246);
            LabelNumeroParcelas.Location=new Point(87, 91);
            LabelNumeroParcelas.Name="LabelNumeroParcelas";
            LabelNumeroParcelas.Size=new Size(113, 15);
            LabelNumeroParcelas.TabIndex=5;
            LabelNumeroParcelas.Text="Número de parcelas";
            // 
            // TextNumeroParcelas
            // 
            TextNumeroParcelas.BackColor=Color.FromArgb(246, 246, 246);
            TextNumeroParcelas.Location=new Point(93, 109);
            TextNumeroParcelas.Name="TextNumeroParcelas";
            TextNumeroParcelas.Size=new Size(100, 23);
            TextNumeroParcelas.TabIndex=1;
            TextNumeroParcelas.TextAlign=HorizontalAlignment.Center;
            TextNumeroParcelas.KeyPress+=TextNumeroParcelas_KeyPress;
            // 
            // LabelSalarioSolicitante
            // 
            LabelSalarioSolicitante.AutoSize=true;
            LabelSalarioSolicitante.ForeColor=Color.FromArgb(246, 246, 246);
            LabelSalarioSolicitante.Location=new Point(86, 144);
            LabelSalarioSolicitante.Name="LabelSalarioSolicitante";
            LabelSalarioSolicitante.Size=new Size(116, 15);
            LabelSalarioSolicitante.TabIndex=6;
            LabelSalarioSolicitante.Text="Salário do solicitante";
            // 
            // TextSalarioSolicitante
            // 
            TextSalarioSolicitante.BackColor=Color.FromArgb(246, 246, 246);
            TextSalarioSolicitante.Location=new Point(93, 162);
            TextSalarioSolicitante.Name="TextSalarioSolicitante";
            TextSalarioSolicitante.Size=new Size(100, 23);
            TextSalarioSolicitante.TabIndex=2;
            TextSalarioSolicitante.TextAlign=HorizontalAlignment.Center;
            TextSalarioSolicitante.KeyPress+=TextSalarioSolicitante_KeyPress;
            // 
            // ButtonCalcular
            // 
            ButtonCalcular.BackColor=Color.FromArgb(246, 246, 246);
            ButtonCalcular.Location=new Point(105, 200);
            ButtonCalcular.Name="ButtonCalcular";
            ButtonCalcular.Size=new Size(75, 23);
            ButtonCalcular.TabIndex=3;
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
            Controls.Add(LabelValorEmprestimo);
            Controls.Add(TextValorEmprestimo);
            Controls.Add(LabelNumeroParcelas);
            Controls.Add(TextNumeroParcelas);
            Controls.Add(LabelSalarioSolicitante);
            Controls.Add(TextSalarioSolicitante);
            Controls.Add(ButtonCalcular);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            Name="FormPrincipal";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Empréstimo bancário";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelValorEmprestimo;
        private TextBox TextValorEmprestimo;
        private Label LabelNumeroParcelas;
        private TextBox TextNumeroParcelas;
        private Label LabelSalarioSolicitante;
        private TextBox TextSalarioSolicitante;
        private Button ButtonCalcular;
    }
}