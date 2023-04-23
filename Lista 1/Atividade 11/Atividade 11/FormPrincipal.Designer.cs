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
            LabelHoras=new Label();
            TextHoras=new TextBox();
            LabelMinutos=new Label();
            TextMinutos=new TextBox();
            ButtonCalcular=new Button();
            SuspendLayout();
            // 
            // LabelHoras
            // 
            LabelHoras.AutoSize=true;
            LabelHoras.ForeColor=Color.FromArgb(246, 246, 246);
            LabelHoras.Location=new Point(123, 65);
            LabelHoras.Name="LabelHoras";
            LabelHoras.Size=new Size(38, 15);
            LabelHoras.TabIndex=3;
            LabelHoras.Text="Horas";
            // 
            // TextHoras
            // 
            TextHoras.Location=new Point(92, 83);
            TextHoras.Name="TextHoras";
            TextHoras.Size=new Size(100, 23);
            TextHoras.TabIndex=0;
            TextHoras.TextAlign=HorizontalAlignment.Center;
            TextHoras.KeyPress+=TextHoras_KeyPress;
            // 
            // LabelMinutos
            // 
            LabelMinutos.AutoSize=true;
            LabelMinutos.ForeColor=Color.FromArgb(246, 246, 246);
            LabelMinutos.Location=new Point(117, 118);
            LabelMinutos.Name="LabelMinutos";
            LabelMinutos.Size=new Size(51, 15);
            LabelMinutos.TabIndex=4;
            LabelMinutos.Text="Minutos";
            // 
            // TextMinutos
            // 
            TextMinutos.Location=new Point(92, 136);
            TextMinutos.Name="TextMinutos";
            TextMinutos.Size=new Size(100, 23);
            TextMinutos.TabIndex=1;
            TextMinutos.TextAlign=HorizontalAlignment.Center;
            TextMinutos.KeyPress+=TextMinutos_KeyPress;
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
            Controls.Add(LabelHoras);
            Controls.Add(TextHoras);
            Controls.Add(LabelMinutos);
            Controls.Add(TextMinutos);
            Controls.Add(ButtonCalcular);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            Name="FormPrincipal";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Minutos Passados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelHoras;
        private TextBox TextHoras;
        private Label LabelMinutos;
        private TextBox TextMinutos;
        private Button ButtonCalcular;
    }
}