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
            LabelSalario=new Label();
            TextSalario=new TextBox();
            LabelTempoServico=new Label();
            TextTempoServico=new TextBox();
            ButtonCalcular=new Button();
            SuspendLayout();
            // 
            // LabelSalario
            // 
            LabelSalario.AutoSize=true;
            LabelSalario.ForeColor=Color.FromArgb(246, 246, 246);
            LabelSalario.Location=new Point(121, 65);
            LabelSalario.Name="LabelSalario";
            LabelSalario.Size=new Size(42, 15);
            LabelSalario.TabIndex=3;
            LabelSalario.Text="Salário";
            // 
            // TextSalario
            // 
            TextSalario.BackColor=Color.FromArgb(246, 246, 246);
            TextSalario.Location=new Point(92, 83);
            TextSalario.Name="TextSalario";
            TextSalario.Size=new Size(100, 23);
            TextSalario.TabIndex=0;
            TextSalario.TextAlign=HorizontalAlignment.Center;
            TextSalario.KeyPress+=TextSalario_KeyPress;
            // 
            // LabelTempoServico
            // 
            LabelTempoServico.AutoSize=true;
            LabelTempoServico.ForeColor=Color.FromArgb(246, 246, 246);
            LabelTempoServico.Location=new Point(93, 118);
            LabelTempoServico.Name="LabelTempoServico";
            LabelTempoServico.Size=new Size(99, 15);
            LabelTempoServico.TabIndex=4;
            LabelTempoServico.Text="Tempo de serviço";
            // 
            // TextTempoServico
            // 
            TextTempoServico.BackColor=Color.FromArgb(246, 246, 246);
            TextTempoServico.Location=new Point(92, 136);
            TextTempoServico.Name="TextTempoServico";
            TextTempoServico.Size=new Size(100, 23);
            TextTempoServico.TabIndex=1;
            TextTempoServico.TextAlign=HorizontalAlignment.Center;
            TextTempoServico.KeyPress+=TextTempoServico_KeyPress;
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
            Controls.Add(LabelTempoServico);
            Controls.Add(TextSalario);
            Controls.Add(LabelSalario);
            Controls.Add(TextTempoServico);
            Controls.Add(ButtonCalcular);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            Name="FormPrincipal";
            StartPosition=FormStartPosition.CenterScreen;
            Text="XKW";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelSalario;
        private TextBox TextSalario;
        private Label LabelTempoServico;
        private TextBox TextTempoServico;
        private Button ButtonCalcular;
    }
}