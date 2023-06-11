namespace Atividade_7
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
            ButtonSomar=new Button();
            ButtonMostrarSoma=new Button();
            ButtonReiniciarSoma=new Button();
            SuspendLayout();
            // 
            // LabelNumero
            // 
            LabelNumero.AutoSize=true;
            LabelNumero.ForeColor=Color.FromArgb(246, 246, 246);
            LabelNumero.Location=new Point(117, 51);
            LabelNumero.Name="LabelNumero";
            LabelNumero.Size=new Size(51, 15);
            LabelNumero.TabIndex=3;
            LabelNumero.Text="Número";
            // 
            // TextNumero
            // 
            TextNumero.BackColor=Color.FromArgb(246, 246, 246);
            TextNumero.Location=new Point(92, 69);
            TextNumero.Name="TextNumero";
            TextNumero.Size=new Size(100, 23);
            TextNumero.TabIndex=0;
            TextNumero.TextAlign=HorizontalAlignment.Center;
            TextNumero.KeyPress+=TextNumero_KeyPress;
            // 
            // ButtonSomar
            // 
            ButtonSomar.BackColor=Color.FromArgb(246, 246, 246);
            ButtonSomar.Location=new Point(92, 107);
            ButtonSomar.Name="ButtonSomar";
            ButtonSomar.Size=new Size(100, 23);
            ButtonSomar.TabIndex=1;
            ButtonSomar.Text="Somar";
            ButtonSomar.UseVisualStyleBackColor=false;
            ButtonSomar.Click+=ButtonSomar_Click;
            // 
            // ButtonMostrarSoma
            // 
            ButtonMostrarSoma.BackColor=Color.FromArgb(246, 246, 246);
            ButtonMostrarSoma.Location=new Point(92, 145);
            ButtonMostrarSoma.Name="ButtonMostrarSoma";
            ButtonMostrarSoma.Size=new Size(100, 23);
            ButtonMostrarSoma.TabIndex=2;
            ButtonMostrarSoma.Text="Mostrar soma";
            ButtonMostrarSoma.UseVisualStyleBackColor=false;
            ButtonMostrarSoma.Click+=ButtonMostrarSoma_Click;
            // 
            // ButtonReiniciarSoma
            // 
            ButtonReiniciarSoma.BackColor=Color.FromArgb(246, 246, 246);
            ButtonReiniciarSoma.Location=new Point(92, 183);
            ButtonReiniciarSoma.Name="ButtonReiniciarSoma";
            ButtonReiniciarSoma.Size=new Size(99, 23);
            ButtonReiniciarSoma.TabIndex=4;
            ButtonReiniciarSoma.Text="Reiniciar soma";
            ButtonReiniciarSoma.UseVisualStyleBackColor=false;
            ButtonReiniciarSoma.Click+=ButtonReiniciarSoma_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.FromArgb(66, 66, 66);
            ClientSize=new Size(284, 261);
            Controls.Add(LabelNumero);
            Controls.Add(TextNumero);
            Controls.Add(ButtonSomar);
            Controls.Add(ButtonMostrarSoma);
            Controls.Add(ButtonReiniciarSoma);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            Name="FormPrincipal";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Soma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelNumero;
        private TextBox TextNumero;
        private Button ButtonSomar;
        private Button ButtonMostrarSoma;
        private Button ButtonReiniciarSoma;
    }
}