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
            LabelValorSaque=new Label();
            TextValorSaque=new TextBox();
            ButtonCalcular=new Button();
            SuspendLayout();
            // 
            // LabelValorSaque
            // 
            LabelValorSaque.AutoSize=true;
            LabelValorSaque.ForeColor=Color.FromArgb(246, 246, 246);
            LabelValorSaque.Location=new Point(100, 90);
            LabelValorSaque.Name="LabelValorSaque";
            LabelValorSaque.Size=new Size(84, 15);
            LabelValorSaque.TabIndex=2;
            LabelValorSaque.Text="Valor do saque";
            // 
            // TextValorSaque
            // 
            TextValorSaque.BackColor=Color.FromArgb(246, 246, 246);
            TextValorSaque.Location=new Point(92, 108);
            TextValorSaque.Name="TextValorSaque";
            TextValorSaque.Size=new Size(100, 23);
            TextValorSaque.TabIndex=0;
            TextValorSaque.TextAlign=HorizontalAlignment.Center;
            TextValorSaque.KeyPress+=TextValorSaque_KeyPress;
            // 
            // ButtonCalcular
            // 
            ButtonCalcular.BackColor=Color.FromArgb(246, 246, 246);
            ButtonCalcular.Location=new Point(104, 146);
            ButtonCalcular.Name="ButtonCalcular";
            ButtonCalcular.Size=new Size(75, 23);
            ButtonCalcular.TabIndex=1;
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
            Controls.Add(LabelValorSaque);
            Controls.Add(TextValorSaque);
            Controls.Add(ButtonCalcular);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            Name="FormPrincipal";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Saques";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelValorSaque;
        private TextBox TextValorSaque;
        private Button ButtonCalcular;
    }
}