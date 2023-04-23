namespace Atividade_4
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
            LabelNome=new Label();
            TextNome=new TextBox();
            LabelIdade=new Label();
            TextIdade=new TextBox();
            ButtonCalcular=new Button();
            SuspendLayout();
            // 
            // LabelNome
            // 
            LabelNome.AutoSize=true;
            LabelNome.ForeColor=Color.FromArgb(246, 246, 246);
            LabelNome.Location=new Point(123, 65);
            LabelNome.Name="LabelNome";
            LabelNome.Size=new Size(40, 15);
            LabelNome.TabIndex=3;
            LabelNome.Text="Nome";
            // 
            // TextNome
            // 
            TextNome.BackColor=Color.FromArgb(246, 246, 246);
            TextNome.Location=new Point(68, 83);
            TextNome.Name="TextNome";
            TextNome.Size=new Size(150, 23);
            TextNome.TabIndex=0;
            TextNome.TextAlign=HorizontalAlignment.Center;
            TextNome.KeyPress+=TextNome_KeyPress;
            // 
            // LabelIdade
            // 
            LabelIdade.AutoSize=true;
            LabelIdade.ForeColor=Color.FromArgb(246, 246, 246);
            LabelIdade.Location=new Point(124, 118);
            LabelIdade.Name="LabelIdade";
            LabelIdade.Size=new Size(36, 15);
            LabelIdade.TabIndex=4;
            LabelIdade.Text="Idade";
            // 
            // TextIdade
            // 
            TextIdade.BackColor=Color.FromArgb(246, 246, 246);
            TextIdade.Location=new Point(92, 136);
            TextIdade.Name="TextIdade";
            TextIdade.Size=new Size(100, 23);
            TextIdade.TabIndex=1;
            TextIdade.TextAlign=HorizontalAlignment.Center;
            TextIdade.KeyPress+=TextIdade_KeyPress;
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
            Controls.Add(LabelNome);
            Controls.Add(TextNome);
            Controls.Add(LabelIdade);
            Controls.Add(TextIdade);
            Controls.Add(ButtonCalcular);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            Name="FormPrincipal";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Dias de vida";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelNome;
        private TextBox TextNome;
        private Label LabelIdade;
        private TextBox TextIdade;
        private Button ButtonCalcular;
    }
}