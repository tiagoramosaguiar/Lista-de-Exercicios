namespace Atividade_1
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
            LabelNomeAluno=new Label();
            TextNomeAluno=new TextBox();
            LabelPrimeiraNota=new Label();
            TextPrimeiraNota=new TextBox();
            LabelSegundaNota=new Label();
            TextSegundaNota=new TextBox();
            ButtonCalcular=new Button();
            SuspendLayout();
            // 
            // LabelNomeAluno
            // 
            LabelNomeAluno.AutoSize=true;
            LabelNomeAluno.ForeColor=Color.FromArgb(246, 246, 246);
            LabelNomeAluno.Location=new Point(98, 38);
            LabelNomeAluno.Name="LabelNomeAluno";
            LabelNomeAluno.Size=new Size(90, 15);
            LabelNomeAluno.TabIndex=4;
            LabelNomeAluno.Text="Nome do aluno";
            // 
            // TextNomeAluno
            // 
            TextNomeAluno.BackColor=Color.FromArgb(246, 246, 246);
            TextNomeAluno.Location=new Point(68, 56);
            TextNomeAluno.Name="TextNomeAluno";
            TextNomeAluno.Size=new Size(150, 23);
            TextNomeAluno.TabIndex=0;
            TextNomeAluno.TextAlign=HorizontalAlignment.Center;
            TextNomeAluno.KeyPress+=TextNomeAluno_KeyPress;
            // 
            // LabelPrimeiraNota
            // 
            LabelPrimeiraNota.AutoSize=true;
            LabelPrimeiraNota.ForeColor=Color.FromArgb(246, 246, 246);
            LabelPrimeiraNota.Location=new Point(104, 91);
            LabelPrimeiraNota.Name="LabelPrimeiraNota";
            LabelPrimeiraNota.Size=new Size(78, 15);
            LabelPrimeiraNota.TabIndex=5;
            LabelPrimeiraNota.Text="Primeira nota";
            // 
            // TextPrimeiraNota
            // 
            TextPrimeiraNota.BackColor=Color.FromArgb(246, 246, 246);
            TextPrimeiraNota.Location=new Point(93, 109);
            TextPrimeiraNota.Name="TextPrimeiraNota";
            TextPrimeiraNota.Size=new Size(100, 23);
            TextPrimeiraNota.TabIndex=1;
            TextPrimeiraNota.TextAlign=HorizontalAlignment.Center;
            TextPrimeiraNota.KeyPress+=TextPrimeiraNota_KeyPress;
            // 
            // LabelSegundaNota
            // 
            LabelSegundaNota.AutoSize=true;
            LabelSegundaNota.ForeColor=Color.FromArgb(246, 246, 246);
            LabelSegundaNota.Location=new Point(103, 144);
            LabelSegundaNota.Name="LabelSegundaNota";
            LabelSegundaNota.Size=new Size(80, 15);
            LabelSegundaNota.TabIndex=6;
            LabelSegundaNota.Text="Segunda nota";
            // 
            // TextSegundaNota
            // 
            TextSegundaNota.BackColor=Color.FromArgb(246, 246, 246);
            TextSegundaNota.Location=new Point(93, 162);
            TextSegundaNota.Name="TextSegundaNota";
            TextSegundaNota.Size=new Size(100, 23);
            TextSegundaNota.TabIndex=2;
            TextSegundaNota.TextAlign=HorizontalAlignment.Center;
            TextSegundaNota.KeyPress+=TextSegundaNota_KeyPress;
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
            Controls.Add(LabelNomeAluno);
            Controls.Add(TextNomeAluno);
            Controls.Add(LabelPrimeiraNota);
            Controls.Add(TextPrimeiraNota);
            Controls.Add(LabelSegundaNota);
            Controls.Add(TextSegundaNota);
            Controls.Add(ButtonCalcular);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            Name="FormPrincipal";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Média Aluno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelNomeAluno;
        private TextBox TextNomeAluno;
        private Label LabelPrimeiraNota;
        private TextBox TextPrimeiraNota;
        private Label LabelSegundaNota;
        private TextBox TextSegundaNota;
        private Button ButtonCalcular;
    }
}