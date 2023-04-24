namespace Atividade_16
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
            LabelPrimeiraNota=new Label();
            TextPrimeiraNota=new TextBox();
            LabelSegundaNota=new Label();
            TextSegundaNota=new TextBox();
            LabelTerceiraNota=new Label();
            TextTerceiraNota=new TextBox();
            ButtonCalcular=new Button();
            LabelNotaExame=new Label();
            TextNotaExame=new TextBox();
            ButtonRecalcular=new Button();
            SuspendLayout();
            // 
            // LabelPrimeiraNota
            // 
            LabelPrimeiraNota.AutoSize=true;
            LabelPrimeiraNota.ForeColor=Color.FromArgb(246, 246, 246);
            LabelPrimeiraNota.Location=new Point(104, 38);
            LabelPrimeiraNota.Name="LabelPrimeiraNota";
            LabelPrimeiraNota.Size=new Size(78, 15);
            LabelPrimeiraNota.TabIndex=4;
            LabelPrimeiraNota.Text="Primeira nota";
            // 
            // TextPrimeiraNota
            // 
            TextPrimeiraNota.BackColor=Color.FromArgb(246, 246, 246);
            TextPrimeiraNota.Location=new Point(93, 56);
            TextPrimeiraNota.Name="TextPrimeiraNota";
            TextPrimeiraNota.Size=new Size(100, 23);
            TextPrimeiraNota.TabIndex=0;
            TextPrimeiraNota.TextAlign=HorizontalAlignment.Center;
            TextPrimeiraNota.KeyPress+=TextPrimeiraNota_KeyPress;
            // 
            // LabelSegundaNota
            // 
            LabelSegundaNota.AutoSize=true;
            LabelSegundaNota.ForeColor=Color.FromArgb(246, 246, 246);
            LabelSegundaNota.Location=new Point(103, 91);
            LabelSegundaNota.Name="LabelSegundaNota";
            LabelSegundaNota.Size=new Size(80, 15);
            LabelSegundaNota.TabIndex=5;
            LabelSegundaNota.Text="Segunda nota";
            // 
            // TextSegundaNota
            // 
            TextSegundaNota.BackColor=Color.FromArgb(246, 246, 246);
            TextSegundaNota.Location=new Point(93, 109);
            TextSegundaNota.Name="TextSegundaNota";
            TextSegundaNota.Size=new Size(100, 23);
            TextSegundaNota.TabIndex=1;
            TextSegundaNota.TextAlign=HorizontalAlignment.Center;
            TextSegundaNota.KeyPress+=TextSegundaNota_KeyPress;
            // 
            // LabelTerceiraNota
            // 
            LabelTerceiraNota.AutoSize=true;
            LabelTerceiraNota.ForeColor=Color.FromArgb(246, 246, 246);
            LabelTerceiraNota.Location=new Point(106, 144);
            LabelTerceiraNota.Name="LabelTerceiraNota";
            LabelTerceiraNota.Size=new Size(74, 15);
            LabelTerceiraNota.TabIndex=6;
            LabelTerceiraNota.Text="Terceira nota";
            // 
            // TextTerceiraNota
            // 
            TextTerceiraNota.BackColor=Color.FromArgb(246, 246, 246);
            TextTerceiraNota.Location=new Point(93, 162);
            TextTerceiraNota.Name="TextTerceiraNota";
            TextTerceiraNota.Size=new Size(100, 23);
            TextTerceiraNota.TabIndex=2;
            TextTerceiraNota.TextAlign=HorizontalAlignment.Center;
            TextTerceiraNota.KeyPress+=TextTerceiraNota_KeyPress;
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
            // LabelNotaExame
            // 
            LabelNotaExame.AutoSize=true;
            LabelNotaExame.ForeColor=Color.FromArgb(246, 246, 246);
            LabelNotaExame.Location=new Point(1, 182);
            LabelNotaExame.Name="LabelNotaExame";
            LabelNotaExame.Size=new Size(88, 15);
            LabelNotaExame.TabIndex=9;
            LabelNotaExame.Text="Nota do exame";
            LabelNotaExame.Visible=false;
            // 
            // TextNotaExame
            // 
            TextNotaExame.BackColor=Color.FromArgb(246, 246, 246);
            TextNotaExame.Location=new Point(1, 201);
            TextNotaExame.Name="TextNotaExame";
            TextNotaExame.Size=new Size(100, 23);
            TextNotaExame.TabIndex=7;
            TextNotaExame.TextAlign=HorizontalAlignment.Center;
            TextNotaExame.Visible=false;
            TextNotaExame.KeyPress+=TextNotaExame_KeyPress;
            // 
            // ButtonRecalcular
            // 
            ButtonRecalcular.BackColor=Color.FromArgb(246, 246, 246);
            ButtonRecalcular.Location=new Point(1, 230);
            ButtonRecalcular.Name="ButtonRecalcular";
            ButtonRecalcular.Size=new Size(75, 23);
            ButtonRecalcular.TabIndex=8;
            ButtonRecalcular.Text="Recalcular";
            ButtonRecalcular.UseVisualStyleBackColor=false;
            ButtonRecalcular.Visible=false;
            ButtonRecalcular.Click+=ButtonRecalcular_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.FromArgb(66, 66, 66);
            ClientSize=new Size(284, 261);
            Controls.Add(LabelPrimeiraNota);
            Controls.Add(TextPrimeiraNota);
            Controls.Add(LabelSegundaNota);
            Controls.Add(TextSegundaNota);
            Controls.Add(LabelTerceiraNota);
            Controls.Add(TextTerceiraNota);
            Controls.Add(ButtonCalcular);
            Controls.Add(LabelNotaExame);
            Controls.Add(TextNotaExame);
            Controls.Add(ButtonRecalcular);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            Name="FormPrincipal";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Média aluno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelPrimeiraNota;
        private TextBox TextPrimeiraNota;
        private Label LabelSegundaNota;
        private TextBox TextSegundaNota;
        private Label LabelTerceiraNota;
        private TextBox TextTerceiraNota;
        private Button ButtonCalcular;
        private Label LabelNotaExame;
        private TextBox TextNotaExame;
        private Button ButtonRecalcular;
    }
}