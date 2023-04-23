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
            LabelDia=new Label();
            TextDia=new TextBox();
            LabelMes=new Label();
            TextMes=new TextBox();
            ButtonCalcular=new Button();
            SuspendLayout();
            // 
            // LabelDia
            // 
            LabelDia.AutoSize=true;
            LabelDia.ForeColor=Color.FromArgb(246, 246, 246);
            LabelDia.Location=new Point(130, 65);
            LabelDia.Name="LabelDia";
            LabelDia.Size=new Size(24, 15);
            LabelDia.TabIndex=3;
            LabelDia.Text="Dia";
            // 
            // TextDia
            // 
            TextDia.BackColor=Color.FromArgb(246, 246, 246);
            TextDia.Location=new Point(92, 83);
            TextDia.Name="TextDia";
            TextDia.Size=new Size(100, 23);
            TextDia.TabIndex=0;
            TextDia.TextAlign=HorizontalAlignment.Center;
            TextDia.KeyPress+=TextDia_KeyPress;
            // 
            // LabelMes
            // 
            LabelMes.AutoSize=true;
            LabelMes.ForeColor=Color.FromArgb(246, 246, 246);
            LabelMes.Location=new Point(128, 118);
            LabelMes.Name="LabelMes";
            LabelMes.Size=new Size(29, 15);
            LabelMes.TabIndex=4;
            LabelMes.Text="Mês";
            // 
            // TextMes
            // 
            TextMes.BackColor=Color.FromArgb(246, 246, 246);
            TextMes.Location=new Point(92, 136);
            TextMes.Name="TextMes";
            TextMes.Size=new Size(100, 23);
            TextMes.TabIndex=1;
            TextMes.TextAlign=HorizontalAlignment.Center;
            TextMes.KeyPress+=TextMes_KeyPress;
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
            Controls.Add(LabelDia);
            Controls.Add(TextDia);
            Controls.Add(LabelMes);
            Controls.Add(TextMes);
            Controls.Add(ButtonCalcular);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            Name="FormPrincipal";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Dias do ano";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelDia;
        private TextBox TextDia;
        private Label LabelMes;
        private TextBox TextMes;
        private Button ButtonCalcular;
    }
}