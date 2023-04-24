namespace Atividade_14
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
            LabelPonto1=new Label();
            LabelPonto2=new Label();
            LabelX1=new Label();
            TextX1=new TextBox();
            LabelY1=new Label();
            TextY1=new TextBox();
            LabelX2=new Label();
            TextX2=new TextBox();
            LabelY2=new Label();
            TextY2=new TextBox();
            ButtonCalcular=new Button();
            SuspendLayout();
            // 
            // LabelPonto1
            // 
            LabelPonto1.AutoSize=true;
            LabelPonto1.ForeColor=Color.FromArgb(246, 246, 246);
            LabelPonto1.Location=new Point(97, 90);
            LabelPonto1.Name="LabelPonto1";
            LabelPonto1.Size=new Size(48, 15);
            LabelPonto1.TabIndex=5;
            LabelPonto1.Text="Ponto 1";
            // 
            // LabelPonto2
            // 
            LabelPonto2.AutoSize=true;
            LabelPonto2.ForeColor=Color.FromArgb(246, 246, 246);
            LabelPonto2.Location=new Point(237, 90);
            LabelPonto2.Name="LabelPonto2";
            LabelPonto2.Size=new Size(48, 15);
            LabelPonto2.TabIndex=6;
            LabelPonto2.Text="Ponto 2";
            // 
            // LabelX1
            // 
            LabelX1.AutoSize=true;
            LabelX1.ForeColor=Color.FromArgb(246, 246, 246);
            LabelX1.Location=new Point(112, 129);
            LabelX1.Name="LabelX1";
            LabelX1.Size=new Size(20, 15);
            LabelX1.TabIndex=7;
            LabelX1.Text="X1";
            // 
            // TextX1
            // 
            TextX1.BackColor=Color.FromArgb(246, 246, 246);
            TextX1.Location=new Point(72, 147);
            TextX1.Name="TextX1";
            TextX1.Size=new Size(100, 23);
            TextX1.TabIndex=0;
            TextX1.TextAlign=HorizontalAlignment.Center;
            TextX1.KeyPress+=TextX1_KeyPress;
            // 
            // LabelY1
            // 
            LabelY1.AutoSize=true;
            LabelY1.ForeColor=Color.FromArgb(246, 246, 246);
            LabelY1.Location=new Point(112, 185);
            LabelY1.Name="LabelY1";
            LabelY1.Size=new Size(20, 15);
            LabelY1.TabIndex=8;
            LabelY1.Text="Y1";
            // 
            // TextY1
            // 
            TextY1.BackColor=Color.FromArgb(246, 246, 246);
            TextY1.Location=new Point(72, 203);
            TextY1.Name="TextY1";
            TextY1.Size=new Size(100, 23);
            TextY1.TabIndex=1;
            TextY1.TextAlign=HorizontalAlignment.Center;
            TextY1.KeyPress+=TextY1_KeyPress;
            // 
            // LabelX2
            // 
            LabelX2.AutoSize=true;
            LabelX2.ForeColor=Color.FromArgb(246, 246, 246);
            LabelX2.Location=new Point(251, 129);
            LabelX2.Name="LabelX2";
            LabelX2.Size=new Size(20, 15);
            LabelX2.TabIndex=9;
            LabelX2.Text="X2";
            // 
            // TextX2
            // 
            TextX2.BackColor=Color.FromArgb(246, 246, 246);
            TextX2.Location=new Point(211, 147);
            TextX2.Name="TextX2";
            TextX2.Size=new Size(100, 23);
            TextX2.TabIndex=2;
            TextX2.TextAlign=HorizontalAlignment.Center;
            TextX2.KeyPress+=TextX2_KeyPress;
            // 
            // LabelY2
            // 
            LabelY2.AutoSize=true;
            LabelY2.ForeColor=Color.FromArgb(246, 246, 246);
            LabelY2.Location=new Point(251, 185);
            LabelY2.Name="LabelY2";
            LabelY2.Size=new Size(20, 15);
            LabelY2.TabIndex=10;
            LabelY2.Text="Y2";
            // 
            // TextY2
            // 
            TextY2.BackColor=Color.FromArgb(246, 246, 246);
            TextY2.Location=new Point(211, 203);
            TextY2.Name="TextY2";
            TextY2.Size=new Size(100, 23);
            TextY2.TabIndex=3;
            TextY2.TextAlign=HorizontalAlignment.Center;
            TextY2.KeyPress+=TextY2_KeyPress;
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
            Controls.Add(LabelPonto2);
            Controls.Add(LabelPonto1);
            Controls.Add(ButtonCalcular);
            Controls.Add(LabelY2);
            Controls.Add(TextY2);
            Controls.Add(LabelY1);
            Controls.Add(TextY1);
            Controls.Add(LabelX2);
            Controls.Add(TextX2);
            Controls.Add(LabelX1);
            Controls.Add(TextX1);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            Name="FormPrincipal";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Distância no plano cartesiano";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelPonto1;
        private Label LabelPonto2;
        private Label LabelX1;
        private TextBox TextX1;
        private Label LabelY1;
        private TextBox TextY1;
        private Label LabelX2;
        private TextBox TextX2;
        private Label LabelY2;
        private TextBox TextY2;
        private Button ButtonCalcular;
    }
}