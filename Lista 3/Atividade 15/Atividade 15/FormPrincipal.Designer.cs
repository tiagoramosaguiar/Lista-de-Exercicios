namespace Atividade_15
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
            LabelAdicional=new Label();
            TextAdicional=new TextBox();
            ButtonCalcular=new Button();
            SuspendLayout();
            // 
            // LabelAdicional
            // 
            LabelAdicional.AutoSize=true;
            LabelAdicional.ForeColor=Color.FromArgb(246, 246, 246);
            LabelAdicional.Location=new Point(65, 90);
            LabelAdicional.Name="LabelAdicional";
            LabelAdicional.Size=new Size(162, 15);
            LabelAdicional.TabIndex=0;
            LabelAdicional.Text="Número adicional de pessoas";
            // 
            // TextAdicional
            // 
            TextAdicional.BackColor=Color.FromArgb(246, 246, 246);
            TextAdicional.Location=new Point(92, 108);
            TextAdicional.Name="TextAdicional";
            TextAdicional.Size=new Size(100, 23);
            TextAdicional.TabIndex=1;
            TextAdicional.TextAlign=HorizontalAlignment.Center;
            TextAdicional.KeyPress+=TextAdicional_KeyPress;
            // 
            // ButtonCalcular
            // 
            ButtonCalcular.BackColor=Color.FromArgb(246, 246, 246);
            ButtonCalcular.Location=new Point(104, 146);
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
            Controls.Add(ButtonCalcular);
            Controls.Add(TextAdicional);
            Controls.Add(LabelAdicional);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            Name="FormPrincipal";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Preço dos ingressos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelAdicional;
        private TextBox TextAdicional;
        private Button ButtonCalcular;
    }
}