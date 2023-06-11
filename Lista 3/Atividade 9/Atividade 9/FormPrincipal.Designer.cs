namespace Atividade_9
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
            ButtonReiniciar=new Button();
            SuspendLayout();
            // 
            // LabelIdade
            // 
            LabelIdade.AutoSize=true;
            LabelIdade.ForeColor=Color.FromArgb(246, 246, 246);
            LabelIdade.Location=new Point(122, 47);
            LabelIdade.Name="LabelIdade";
            LabelIdade.Size=new Size(36, 15);
            LabelIdade.TabIndex=4;
            LabelIdade.Text="Idade";
            // 
            // TextIdade
            // 
            TextIdade.BackColor=Color.FromArgb(246, 246, 246);
            TextIdade.Location=new Point(90, 65);
            TextIdade.Name="TextIdade";
            TextIdade.Size=new Size(100, 23);
            TextIdade.TabIndex=0;
            TextIdade.TextAlign=HorizontalAlignment.Center;
            TextIdade.KeyPress+=TextIdade_KeyPress;
            // 
            // ButtonSomar
            // 
            ButtonSomar.BackColor=Color.FromArgb(246, 246, 246);
            ButtonSomar.Location=new Point(90, 103);
            ButtonSomar.Name="ButtonSomar";
            ButtonSomar.Size=new Size(100, 23);
            ButtonSomar.TabIndex=1;
            ButtonSomar.Text="Acrescentar";
            ButtonSomar.UseVisualStyleBackColor=false;
            ButtonSomar.Click+=ButtonSomar_Click;
            // 
            // ButtonMostrarSoma
            // 
            ButtonMostrarSoma.BackColor=Color.FromArgb(246, 246, 246);
            ButtonMostrarSoma.Location=new Point(90, 141);
            ButtonMostrarSoma.Name="ButtonMostrarSoma";
            ButtonMostrarSoma.Size=new Size(100, 39);
            ButtonMostrarSoma.TabIndex=2;
            ButtonMostrarSoma.Text="Mostrar  percentual";
            ButtonMostrarSoma.UseVisualStyleBackColor=false;
            ButtonMostrarSoma.Click+=ButtonMostrarSoma_Click;
            // 
            // ButtonReiniciar
            // 
            ButtonReiniciar.Location=new Point(90, 195);
            ButtonReiniciar.Name="ButtonReiniciar";
            ButtonReiniciar.Size=new Size(100, 23);
            ButtonReiniciar.TabIndex=5;
            ButtonReiniciar.Text="Reiniciar";
            ButtonReiniciar.UseVisualStyleBackColor=true;
            ButtonReiniciar.Click+=ButtonReiniciar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.FromArgb(66, 66, 66);
            ClientSize=new Size(284, 261);
            Controls.Add(LabelIdade);
            Controls.Add(TextIdade);
            Controls.Add(ButtonSomar);
            Controls.Add(ButtonMostrarSoma);
            Controls.Add(ButtonReiniciar);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            Name="FormPrincipal";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Percentual de idades";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelIdade;
        private TextBox TextIdade;
        private Button ButtonSomar;
        private Button ButtonMostrarSoma;
        private Button ButtonReiniciar;
    }
}