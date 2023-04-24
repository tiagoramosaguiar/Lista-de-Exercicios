namespace Atividade_2
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
            ButtonChecar=new Button();
            SuspendLayout();
            // 
            // LabelIdade
            // 
            LabelIdade.AutoSize=true;
            LabelIdade.ForeColor=Color.FromArgb(246, 246, 246);
            LabelIdade.Location=new Point(124, 90);
            LabelIdade.Name="LabelIdade";
            LabelIdade.Size=new Size(36, 15);
            LabelIdade.TabIndex=1;
            LabelIdade.Text="Idade";
            // 
            // TextIdade
            // 
            TextIdade.BackColor=Color.FromArgb(246, 246, 246);
            TextIdade.Location=new Point(92, 108);
            TextIdade.Name="TextIdade";
            TextIdade.Size=new Size(100, 23);
            TextIdade.TabIndex=0;
            TextIdade.TextAlign=HorizontalAlignment.Center;
            TextIdade.KeyPress+=TextIdade_KeyPress;
            // 
            // ButtonChecar
            // 
            ButtonChecar.BackColor=Color.FromArgb(246, 246, 246);
            ButtonChecar.Location=new Point(104, 146);
            ButtonChecar.Name="ButtonChecar";
            ButtonChecar.Size=new Size(75, 23);
            ButtonChecar.TabIndex=2;
            ButtonChecar.Text="Checar";
            ButtonChecar.UseVisualStyleBackColor=false;
            ButtonChecar.Click+=ButtonChecar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.FromArgb(66, 66, 66);
            ClientSize=new Size(284, 261);
            Controls.Add(LabelIdade);
            Controls.Add(TextIdade);
            Controls.Add(ButtonChecar);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            Name="FormPrincipal";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Checar maioridade";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelIdade;
        private TextBox TextIdade;
        private Button ButtonChecar;
    }
}