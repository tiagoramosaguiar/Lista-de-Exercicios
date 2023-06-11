namespace Atividade_12
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
            ButtonAdicionar=new Button();
            ButtonChecarPA=new Button();
            ButtonReiniciar=new Button();
            SuspendLayout();
            // 
            // LabelNumero
            // 
            LabelNumero.AutoSize=true;
            LabelNumero.ForeColor=Color.FromArgb(246, 246, 246);
            LabelNumero.Location=new Point(117, 52);
            LabelNumero.Name="LabelNumero";
            LabelNumero.Size=new Size(51, 15);
            LabelNumero.TabIndex=0;
            LabelNumero.Text="Número";
            // 
            // TextNumero
            // 
            TextNumero.BackColor=Color.FromArgb(246, 246, 246);
            TextNumero.Location=new Point(92, 70);
            TextNumero.Name="TextNumero";
            TextNumero.Size=new Size(100, 23);
            TextNumero.TabIndex=1;
            TextNumero.TextAlign=HorizontalAlignment.Center;
            TextNumero.KeyPress+=TextNumero_KeyPress;
            // 
            // ButtonAdicionar
            // 
            ButtonAdicionar.BackColor=Color.FromArgb(246, 246, 246);
            ButtonAdicionar.Location=new Point(104, 108);
            ButtonAdicionar.Name="ButtonAdicionar";
            ButtonAdicionar.Size=new Size(75, 23);
            ButtonAdicionar.TabIndex=2;
            ButtonAdicionar.Text="Adicionar";
            ButtonAdicionar.UseVisualStyleBackColor=false;
            ButtonAdicionar.Click+=ButtonAdicionar_Click;
            // 
            // ButtonChecarPA
            // 
            ButtonChecarPA.BackColor=Color.FromArgb(246, 246, 246);
            ButtonChecarPA.Enabled=false;
            ButtonChecarPA.Location=new Point(104, 146);
            ButtonChecarPA.Name="ButtonChecarPA";
            ButtonChecarPA.Size=new Size(75, 23);
            ButtonChecarPA.TabIndex=3;
            ButtonChecarPA.Text="É uma PA?";
            ButtonChecarPA.UseVisualStyleBackColor=false;
            ButtonChecarPA.Click+=ButtonChecarPA_Click;
            // 
            // ButtonReiniciar
            // 
            ButtonReiniciar.BackColor=Color.FromArgb(246, 246, 246);
            ButtonReiniciar.Location=new Point(104, 184);
            ButtonReiniciar.Name="ButtonReiniciar";
            ButtonReiniciar.Size=new Size(75, 23);
            ButtonReiniciar.TabIndex=4;
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
            Controls.Add(LabelNumero);
            Controls.Add(TextNumero);
            Controls.Add(ButtonAdicionar);
            Controls.Add(ButtonReiniciar);
            Controls.Add(ButtonChecarPA);
            Controls.Add(ButtonReiniciar);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            Name="FormPrincipal";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Progressão Aritmética";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelNumero;
        private TextBox TextNumero;
        private Button ButtonAdicionar;
        private Button ButtonChecarPA;
        private Button ButtonReiniciar;
    }
}