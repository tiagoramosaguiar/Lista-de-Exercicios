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
            LabelEntrada=new Label();
            LabelSaida=new Label();
            LabelHoraEntrada=new Label();
            TextHoraEntrada=new TextBox();
            LabelMinutoEntrada=new Label();
            TextMinutoEntrada=new TextBox();
            LabelHoraSaida=new Label();
            TextHoraSaida=new TextBox();
            LabelMinutoSaida=new Label();
            TextMinutoSaida=new TextBox();
            ButtonCalcular=new Button();
            SuspendLayout();
            // 
            // LabelEntrada
            // 
            LabelEntrada.AutoSize=true;
            LabelEntrada.ForeColor=Color.FromArgb(246, 246, 246);
            LabelEntrada.Location=new Point(99, 90);
            LabelEntrada.Name="LabelEntrada";
            LabelEntrada.Size=new Size(47, 15);
            LabelEntrada.TabIndex=5;
            LabelEntrada.Text="Entrada";
            // 
            // LabelSaida
            // 
            LabelSaida.AutoSize=true;
            LabelSaida.ForeColor=Color.FromArgb(246, 246, 246);
            LabelSaida.Location=new Point(244, 90);
            LabelSaida.Name="LabelSaida";
            LabelSaida.Size=new Size(35, 15);
            LabelSaida.TabIndex=8;
            LabelSaida.Text="Saída";
            // 
            // LabelHoraEntrada
            // 
            LabelHoraEntrada.AutoSize=true;
            LabelHoraEntrada.ForeColor=Color.FromArgb(246, 246, 246);
            LabelHoraEntrada.Location=new Point(106, 129);
            LabelHoraEntrada.Name="LabelHoraEntrada";
            LabelHoraEntrada.Size=new Size(33, 15);
            LabelHoraEntrada.TabIndex=6;
            LabelHoraEntrada.Text="Hora";
            // 
            // TextHoraEntrada
            // 
            TextHoraEntrada.BackColor=Color.FromArgb(246, 246, 246);
            TextHoraEntrada.Location=new Point(72, 147);
            TextHoraEntrada.Name="TextHoraEntrada";
            TextHoraEntrada.Size=new Size(100, 23);
            TextHoraEntrada.TabIndex=0;
            TextHoraEntrada.TextAlign=HorizontalAlignment.Center;
            TextHoraEntrada.KeyPress+=TextHoraEntrada_KeyPress;
            // 
            // LabelMinutoEntrada
            // 
            LabelMinutoEntrada.AutoSize=true;
            LabelMinutoEntrada.ForeColor=Color.FromArgb(246, 246, 246);
            LabelMinutoEntrada.Location=new Point(99, 185);
            LabelMinutoEntrada.Name="LabelMinutoEntrada";
            LabelMinutoEntrada.Size=new Size(46, 15);
            LabelMinutoEntrada.TabIndex=7;
            LabelMinutoEntrada.Text="Minuto";
            // 
            // TextMinutoEntrada
            // 
            TextMinutoEntrada.BackColor=Color.FromArgb(246, 246, 246);
            TextMinutoEntrada.Location=new Point(72, 203);
            TextMinutoEntrada.Name="TextMinutoEntrada";
            TextMinutoEntrada.Size=new Size(100, 23);
            TextMinutoEntrada.TabIndex=1;
            TextMinutoEntrada.TextAlign=HorizontalAlignment.Center;
            TextMinutoEntrada.KeyPress+=TextMinutoEntrada_KeyPress;
            // 
            // LabelHoraSaida
            // 
            LabelHoraSaida.AutoSize=true;
            LabelHoraSaida.ForeColor=Color.FromArgb(246, 246, 246);
            LabelHoraSaida.Location=new Point(245, 129);
            LabelHoraSaida.Name="LabelHoraSaida";
            LabelHoraSaida.Size=new Size(33, 15);
            LabelHoraSaida.TabIndex=9;
            LabelHoraSaida.Text="Hora";
            // 
            // TextHoraSaida
            // 
            TextHoraSaida.BackColor=Color.FromArgb(246, 246, 246);
            TextHoraSaida.Location=new Point(211, 147);
            TextHoraSaida.Name="TextHoraSaida";
            TextHoraSaida.Size=new Size(100, 23);
            TextHoraSaida.TabIndex=2;
            TextHoraSaida.TextAlign=HorizontalAlignment.Center;
            TextHoraSaida.KeyPress+=TextHoraSaida_KeyPress;
            // 
            // LabelMinutoSaida
            // 
            LabelMinutoSaida.AutoSize=true;
            LabelMinutoSaida.ForeColor=Color.FromArgb(246, 246, 246);
            LabelMinutoSaida.Location=new Point(238, 185);
            LabelMinutoSaida.Name="LabelMinutoSaida";
            LabelMinutoSaida.Size=new Size(46, 15);
            LabelMinutoSaida.TabIndex=10;
            LabelMinutoSaida.Text="Minuto";
            // 
            // TextMinutoSaida
            // 
            TextMinutoSaida.BackColor=Color.FromArgb(246, 246, 246);
            TextMinutoSaida.Location=new Point(211, 203);
            TextMinutoSaida.Name="TextMinutoSaida";
            TextMinutoSaida.Size=new Size(100, 23);
            TextMinutoSaida.TabIndex=3;
            TextMinutoSaida.TextAlign=HorizontalAlignment.Center;
            TextMinutoSaida.KeyPress+=TextMinutoSaida_KeyPress;
            // 
            // ButtonCalcular
            // 
            ButtonCalcular.BackColor=Color.FromArgb(246, 246, 246);
            ButtonCalcular.Location=new Point(154, 252);
            ButtonCalcular.Name="ButtonCalcular";
            ButtonCalcular.Size=new Size(75, 23);
            ButtonCalcular.TabIndex=4;
            ButtonCalcular.Text="Calcular";
            ButtonCalcular.UseVisualStyleBackColor=false;
            ButtonCalcular.Click+=ButtonCalcular_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.FromArgb(66, 66, 66);
            ClientSize=new Size(384, 361);
            Controls.Add(LabelEntrada);
            Controls.Add(LabelSaida);
            Controls.Add(LabelHoraEntrada);
            Controls.Add(TextHoraEntrada);
            Controls.Add(LabelMinutoEntrada);
            Controls.Add(TextMinutoEntrada);
            Controls.Add(LabelHoraSaida);
            Controls.Add(TextHoraSaida);
            Controls.Add(LabelMinutoSaida);
            Controls.Add(TextMinutoSaida);
            Controls.Add(ButtonCalcular);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            Name="FormPrincipal";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Estacionamento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelEntrada;
        private Label LabelSaida;
        private Label LabelHoraEntrada;
        private TextBox TextHoraEntrada;
        private Label LabelMinutoEntrada;
        private TextBox TextMinutoEntrada;
        private Label LabelHoraSaida;
        private TextBox TextHoraSaida;
        private Label LabelMinutoSaida;
        private TextBox TextMinutoSaida;
        private Button ButtonCalcular;
    }
}