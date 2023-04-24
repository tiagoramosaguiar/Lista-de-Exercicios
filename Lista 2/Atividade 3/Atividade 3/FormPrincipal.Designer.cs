namespace Atividade_3
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
            LabelPrimeiroNumero=new Label();
            TextPrimeiroNumero=new TextBox();
            LabelSegundoNumero=new Label();
            TextSegundoNumero=new TextBox();
            LabelTerceiroNumero=new Label();
            TextTerceiroNumero=new TextBox();
            ButtonCalcular=new Button();
            SuspendLayout();
            // 
            // LabelPrimeiroNumero
            // 
            LabelPrimeiroNumero.AutoSize=true;
            LabelPrimeiroNumero.ForeColor=Color.FromArgb(246, 246, 246);
            LabelPrimeiroNumero.Location=new Point(95, 38);
            LabelPrimeiroNumero.Name="LabelPrimeiroNumero";
            LabelPrimeiroNumero.Size=new Size(97, 15);
            LabelPrimeiroNumero.TabIndex=4;
            LabelPrimeiroNumero.Text="Primeiro número";
            // 
            // TextPrimeiroNumero
            // 
            TextPrimeiroNumero.BackColor=Color.FromArgb(246, 246, 246);
            TextPrimeiroNumero.Location=new Point(93, 56);
            TextPrimeiroNumero.Name="TextPrimeiroNumero";
            TextPrimeiroNumero.Size=new Size(100, 23);
            TextPrimeiroNumero.TabIndex=0;
            TextPrimeiroNumero.TextAlign=HorizontalAlignment.Center;
            TextPrimeiroNumero.KeyPress+=TextPrimeiroNumero_KeyPress;
            // 
            // LabelSegundoNumero
            // 
            LabelSegundoNumero.AutoSize=true;
            LabelSegundoNumero.ForeColor=Color.FromArgb(246, 246, 246);
            LabelSegundoNumero.Location=new Point(94, 91);
            LabelSegundoNumero.Name="LabelSegundoNumero";
            LabelSegundoNumero.Size=new Size(99, 15);
            LabelSegundoNumero.TabIndex=5;
            LabelSegundoNumero.Text="Segundo número";
            // 
            // TextSegundoNumero
            // 
            TextSegundoNumero.BackColor=Color.FromArgb(246, 246, 246);
            TextSegundoNumero.Location=new Point(93, 109);
            TextSegundoNumero.Name="TextSegundoNumero";
            TextSegundoNumero.Size=new Size(100, 23);
            TextSegundoNumero.TabIndex=1;
            TextSegundoNumero.TextAlign=HorizontalAlignment.Center;
            TextSegundoNumero.KeyPress+=TextSegundoNumero_KeyPress;
            // 
            // LabelTerceiroNumero
            // 
            LabelTerceiroNumero.AutoSize=true;
            LabelTerceiroNumero.ForeColor=Color.FromArgb(246, 246, 246);
            LabelTerceiroNumero.Location=new Point(97, 144);
            LabelTerceiroNumero.Name="LabelTerceiroNumero";
            LabelTerceiroNumero.Size=new Size(93, 15);
            LabelTerceiroNumero.TabIndex=6;
            LabelTerceiroNumero.Text="Terceiro número";
            // 
            // TextTerceiroNumero
            // 
            TextTerceiroNumero.BackColor=Color.FromArgb(246, 246, 246);
            TextTerceiroNumero.Location=new Point(93, 162);
            TextTerceiroNumero.Name="TextTerceiroNumero";
            TextTerceiroNumero.Size=new Size(100, 23);
            TextTerceiroNumero.TabIndex=2;
            TextTerceiroNumero.TextAlign=HorizontalAlignment.Center;
            TextTerceiroNumero.KeyPress+=TextTerceiroNumero_KeyPress;
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
            Controls.Add(LabelPrimeiroNumero);
            Controls.Add(TextPrimeiroNumero);
            Controls.Add(LabelSegundoNumero);
            Controls.Add(TextSegundoNumero);
            Controls.Add(LabelTerceiroNumero);
            Controls.Add(TextTerceiroNumero);
            Controls.Add(ButtonCalcular);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            Name="FormPrincipal";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Maior número";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelPrimeiroNumero;
        private TextBox TextPrimeiroNumero;
        private Label LabelSegundoNumero;
        private TextBox TextSegundoNumero;
        private Label LabelTerceiroNumero;
        private TextBox TextTerceiroNumero;
        private Button ButtonCalcular;
    }
}