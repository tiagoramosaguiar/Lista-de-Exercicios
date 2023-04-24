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
            LabelValor=new Label();
            TextValor=new TextBox();
            ButtonConverter=new Button();
            SuspendLayout();
            // 
            // labelValor
            // 
            LabelValor.AutoSize=true;
            LabelValor.ForeColor=Color.FromArgb(246, 246, 246);
            LabelValor.Location=new Point(108, 90);
            LabelValor.Name="LabelValor";
            LabelValor.Size=new Size(69, 15);
            LabelValor.TabIndex=2;
            LabelValor.Text="Valor em R$";
            // 
            // textValor
            // 
            TextValor.BackColor=Color.FromArgb(246, 246, 246);
            TextValor.Location=new Point(92, 108);
            TextValor.Name="TextValor";
            TextValor.Size=new Size(100, 23);
            TextValor.TabIndex=0;
            TextValor.TextAlign=HorizontalAlignment.Center;
            TextValor.KeyPress+=TextValor_KeyPress;
            // 
            // buttonConverter
            // 
            ButtonConverter.BackColor=Color.FromArgb(246, 246, 246);
            ButtonConverter.Location=new Point(104, 146);
            ButtonConverter.Name="ButtonConverter";
            ButtonConverter.Size=new Size(75, 23);
            ButtonConverter.TabIndex=1;
            ButtonConverter.Text="Converter";
            ButtonConverter.UseVisualStyleBackColor=false;
            ButtonConverter.Click+=ButtonConverter_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.FromArgb(66, 66, 66);
            ClientSize=new Size(284, 261);
            Controls.Add(LabelValor);
            Controls.Add(TextValor);
            Controls.Add(ButtonConverter);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            Name="FormPrincipal";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Conversor de Moedas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelValor;
        private TextBox TextValor;
        private Button ButtonConverter;
    }
}