namespace Atividade_13
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
            LabelNumero=new Label();
            TextNumero=new TextBox();
            LabelOperacao=new Label();
            ComboOperacao=new ComboBox();
            ButtonCalcular=new Button();
            ButtonReiniciar=new Button();
            SuspendLayout();
            // 
            // LabelNumero
            // 
            LabelNumero.AutoSize=true;
            LabelNumero.ForeColor=Color.FromArgb(246, 246, 246);
            LabelNumero.Location=new Point(117, 46);
            LabelNumero.Name="LabelNumero";
            LabelNumero.Size=new Size(51, 15);
            LabelNumero.TabIndex=0;
            LabelNumero.Text="Número";
            // 
            // TextNumero
            // 
            TextNumero.BackColor=Color.FromArgb(246, 246, 246);
            TextNumero.Location=new Point(92, 64);
            TextNumero.Name="TextNumero";
            TextNumero.Size=new Size(100, 23);
            TextNumero.TabIndex=1;
            TextNumero.TextAlign=HorizontalAlignment.Center;
            TextNumero.KeyPress+=TextNumero_KeyPress;
            // 
            // LabelOperacao
            // 
            LabelOperacao.AutoSize=true;
            LabelOperacao.ForeColor=Color.FromArgb(246, 246, 246);
            LabelOperacao.Location=new Point(113, 99);
            LabelOperacao.Name="LabelOperacao";
            LabelOperacao.Size=new Size(58, 15);
            LabelOperacao.TabIndex=2;
            LabelOperacao.Text="Operação";
            // 
            // ComboOperacao
            // 
            ComboOperacao.BackColor=Color.FromArgb(246, 246, 246);
            ComboOperacao.DropDownStyle=ComboBoxStyle.DropDownList;
            ComboOperacao.FormattingEnabled=true;
            ComboOperacao.Items.AddRange(new object[] { "Soma", "Subtração" });
            ComboOperacao.Location=new Point(92, 117);
            ComboOperacao.Name="ComboOperacao";
            ComboOperacao.Size=new Size(100, 23);
            ComboOperacao.TabIndex=3;
            // 
            // ButtonCalcular
            // 
            ButtonCalcular.BackColor=Color.FromArgb(246, 246, 246);
            ButtonCalcular.Location=new Point(104, 155);
            ButtonCalcular.Name="ButtonCalcular";
            ButtonCalcular.Size=new Size(75, 23);
            ButtonCalcular.TabIndex=4;
            ButtonCalcular.Text="Calcular";
            ButtonCalcular.UseVisualStyleBackColor=false;
            ButtonCalcular.Click+=ButtonCalcular_Click;
            // 
            // ButtonReiniciar
            // 
            ButtonReiniciar.BackColor=Color.FromArgb(246, 246, 246);
            ButtonReiniciar.Location=new Point(104, 193);
            ButtonReiniciar.Name="ButtonReiniciar";
            ButtonReiniciar.Size=new Size(75, 23);
            ButtonReiniciar.TabIndex=5;
            ButtonReiniciar.Text="Reiniciar";
            ButtonReiniciar.UseVisualStyleBackColor=false;
            ButtonReiniciar.Click+=ButtonReiniciar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.FromArgb(66, 66, 66);
            ClientSize=new Size(284, 261);
            Controls.Add(ButtonReiniciar);
            Controls.Add(LabelNumero);
            Controls.Add(TextNumero);
            Controls.Add(LabelOperacao);
            Controls.Add(ComboOperacao);
            Controls.Add(ButtonCalcular);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            Name="FormPrincipal";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelNumero;
        private TextBox TextNumero;
        private Label LabelOperacao;
        private ComboBox ComboOperacao;
        private Button ButtonCalcular;
        private Button ButtonReiniciar;
    }
}