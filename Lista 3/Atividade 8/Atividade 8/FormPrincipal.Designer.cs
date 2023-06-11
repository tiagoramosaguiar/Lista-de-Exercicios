namespace Atividade_8
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
            LabelIdade=new Label();
            TextIdade=new TextBox();
            ButtonSomar=new Button();
            ButtonMostrarSoma=new Button();
            ButtonReiniciarSoma=new Button();
            SuspendLayout();
            // 
            // LabelIdade
            // 
            LabelIdade.AutoSize=true;
            LabelIdade.ForeColor=Color.FromArgb(246, 246, 246);
            LabelIdade.Location=new Point(124, 51);
            LabelIdade.Name="LabelIdade";
            LabelIdade.Size=new Size(36, 15);
            LabelIdade.TabIndex=3;
            LabelIdade.Text="Idade";
            // 
            // TextIdade
            // 
            TextIdade.BackColor=Color.FromArgb(246, 246, 246);
            TextIdade.Location=new Point(92, 69);
            TextIdade.Name="TextIdade";
            TextIdade.Size=new Size(100, 23);
            TextIdade.TabIndex=0;
            TextIdade.TextAlign=HorizontalAlignment.Center;
            TextIdade.KeyPress+=TextIdade_KeyPress;
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
            ButtonReiniciarSoma.Size=new Size(100, 23);
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
            Controls.Add(TextIdade);
            Controls.Add(LabelIdade);
            Controls.Add(ButtonSomar);
            Controls.Add(ButtonMostrarSoma);
            Controls.Add(ButtonReiniciarSoma);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            Name="FormPrincipal";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Soma idades";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelIdade;
        private TextBox TextIdade;
        private Button ButtonSomar;
        private Button ButtonMostrarSoma;
        private Button ButtonReiniciarSoma;
    }
}