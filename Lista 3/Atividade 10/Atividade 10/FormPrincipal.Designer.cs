namespace Atividade_10
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
            LabelQuantNumeros=new Label();
            TextQuantNumeros=new TextBox();
            ButtonCalcular=new Button();
            SuspendLayout();
            // 
            // LabelQuantNumeros
            // 
            LabelQuantNumeros.AutoSize=true;
            LabelQuantNumeros.ForeColor=Color.FromArgb(246, 246, 246);
            LabelQuantNumeros.Location=new Point(76, 90);
            LabelQuantNumeros.Name="LabelQuantNumeros";
            LabelQuantNumeros.Size=new Size(135, 15);
            LabelQuantNumeros.TabIndex=2;
            LabelQuantNumeros.Text="Quantidade de números";
            // 
            // TextQuantNumeros
            // 
            TextQuantNumeros.BackColor=Color.FromArgb(246, 246, 246);
            TextQuantNumeros.Location=new Point(92, 108);
            TextQuantNumeros.Name="TextQuantNumeros";
            TextQuantNumeros.Size=new Size(100, 23);
            TextQuantNumeros.TabIndex=0;
            TextQuantNumeros.TextAlign=HorizontalAlignment.Center;
            TextQuantNumeros.KeyPress+=TextQuantNumeros_KeyPress;
            // 
            // ButtonCalcular
            // 
            ButtonCalcular.BackColor=Color.FromArgb(246, 246, 246);
            ButtonCalcular.Location=new Point(105, 146);
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
            Controls.Add(LabelQuantNumeros);
            Controls.Add(TextQuantNumeros);
            Controls.Add(ButtonCalcular);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            Name="FormPrincipal";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Sequência de Fibonacci";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelQuantNumeros;
        private TextBox TextQuantNumeros;
        private Button ButtonCalcular;
    }
}