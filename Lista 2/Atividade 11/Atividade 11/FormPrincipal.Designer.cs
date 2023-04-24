namespace Atividade_11
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
            ButtonVerPreco=new Button();
            SuspendLayout();
            // 
            // LabelIdade
            // 
            LabelIdade.AutoSize=true;
            LabelIdade.ForeColor=Color.FromArgb(246, 246, 246);
            LabelIdade.Location=new Point(124, 90);
            LabelIdade.Name="LabelIdade";
            LabelIdade.Size=new Size(36, 15);
            LabelIdade.TabIndex=0;
            LabelIdade.Text="Idade";
            // 
            // TextIdade
            // 
            TextIdade.BackColor=Color.FromArgb(246, 246, 246);
            TextIdade.Location=new Point(92, 108);
            TextIdade.Name="TextIdade";
            TextIdade.Size=new Size(100, 23);
            TextIdade.TabIndex=1;
            TextIdade.TextAlign=HorizontalAlignment.Center;
            TextIdade.KeyPress+=TextIdade_KeyPress;
            // 
            // ButtonVerPreco
            // 
            ButtonVerPreco.BackColor=Color.FromArgb(246, 246, 246);
            ButtonVerPreco.Location=new Point(104, 146);
            ButtonVerPreco.Name="ButtonVerPreco";
            ButtonVerPreco.Size=new Size(75, 23);
            ButtonVerPreco.TabIndex=2;
            ButtonVerPreco.Text="Ver preço";
            ButtonVerPreco.UseVisualStyleBackColor=false;
            ButtonVerPreco.Click+=ButtonVerPreco_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.FromArgb(66, 66, 66);
            ClientSize=new Size(284, 261);
            Controls.Add(LabelIdade);
            Controls.Add(TextIdade);
            Controls.Add(ButtonVerPreco);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            Name="FormPrincipal";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Planos de saúde";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelIdade;
        private TextBox TextIdade;
        private Button ButtonVerPreco;
    }
}