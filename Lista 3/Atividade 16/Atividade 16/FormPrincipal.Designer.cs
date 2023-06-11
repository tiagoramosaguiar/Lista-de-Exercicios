namespace Atividade_16
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
            LabelJogador=new Label();
            Button1=new Button();
            Button2=new Button();
            Button3=new Button();
            Button4=new Button();
            Button5=new Button();
            Button6=new Button();
            Button7=new Button();
            Button8=new Button();
            Button9=new Button();
            ButtonReiniciarJogo=new Button();
            LabelPlacar=new Label();
            LabelVitoriasX=new Label();
            LabelVitoriasO=new Label();
            SuspendLayout();
            // 
            // LabelJogador
            // 
            LabelJogador.AutoSize=true;
            LabelJogador.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelJogador.ForeColor=Color.FromArgb(246, 246, 246);
            LabelJogador.Location=new Point(76, 18);
            LabelJogador.Name="LabelJogador";
            LabelJogador.Size=new Size(78, 21);
            LabelJogador.TabIndex=0;
            LabelJogador.Text="Vez de: X";
            // 
            // Button1
            // 
            Button1.BackColor=Color.FromArgb(246, 246, 246);
            Button1.Location=new Point(46, 49);
            Button1.Name="Button1";
            Button1.Size=new Size(46, 46);
            Button1.TabIndex=1;
            Button1.UseVisualStyleBackColor=false;
            Button1.Click+=Button_Click;
            // 
            // Button2
            // 
            Button2.BackColor=Color.FromArgb(246, 246, 246);
            Button2.Location=new Point(92, 49);
            Button2.Name="Button2";
            Button2.Size=new Size(46, 46);
            Button2.TabIndex=2;
            Button2.UseVisualStyleBackColor=false;
            Button2.Click+=Button_Click;
            // 
            // Button3
            // 
            Button3.BackColor=Color.FromArgb(246, 246, 246);
            Button3.Location=new Point(138, 49);
            Button3.Name="Button3";
            Button3.Size=new Size(46, 46);
            Button3.TabIndex=3;
            Button3.UseVisualStyleBackColor=false;
            Button3.Click+=Button_Click;
            // 
            // Button4
            // 
            Button4.BackColor=Color.FromArgb(246, 246, 246);
            Button4.Location=new Point(46, 95);
            Button4.Name="Button4";
            Button4.Size=new Size(46, 46);
            Button4.TabIndex=4;
            Button4.UseVisualStyleBackColor=false;
            Button4.Click+=Button_Click;
            // 
            // Button5
            // 
            Button5.BackColor=Color.FromArgb(246, 246, 246);
            Button5.Location=new Point(92, 95);
            Button5.Name="Button5";
            Button5.Size=new Size(46, 46);
            Button5.TabIndex=5;
            Button5.UseVisualStyleBackColor=false;
            Button5.Click+=Button_Click;
            // 
            // Button6
            // 
            Button6.BackColor=Color.FromArgb(246, 246, 246);
            Button6.Location=new Point(138, 95);
            Button6.Name="Button6";
            Button6.Size=new Size(46, 46);
            Button6.TabIndex=6;
            Button6.UseVisualStyleBackColor=false;
            Button6.Click+=Button_Click;
            // 
            // Button7
            // 
            Button7.BackColor=Color.FromArgb(246, 246, 246);
            Button7.Location=new Point(46, 141);
            Button7.Name="Button7";
            Button7.Size=new Size(46, 46);
            Button7.TabIndex=7;
            Button7.UseVisualStyleBackColor=false;
            Button7.Click+=Button_Click;
            // 
            // Button8
            // 
            Button8.BackColor=Color.FromArgb(246, 246, 246);
            Button8.Location=new Point(92, 141);
            Button8.Name="Button8";
            Button8.Size=new Size(46, 46);
            Button8.TabIndex=8;
            Button8.UseVisualStyleBackColor=false;
            Button8.Click+=Button_Click;
            // 
            // Button9
            // 
            Button9.BackColor=Color.FromArgb(246, 246, 246);
            Button9.Location=new Point(138, 141);
            Button9.Name="Button9";
            Button9.Size=new Size(46, 46);
            Button9.TabIndex=9;
            Button9.UseVisualStyleBackColor=false;
            Button9.Click+=Button_Click;
            // 
            // ButtonReiniciarJogo
            // 
            ButtonReiniciarJogo.Location=new Point(46, 196);
            ButtonReiniciarJogo.Name="ButtonReiniciarJogo";
            ButtonReiniciarJogo.Size=new Size(138, 23);
            ButtonReiniciarJogo.TabIndex=10;
            ButtonReiniciarJogo.Text="Reiniciar jogo";
            ButtonReiniciarJogo.UseVisualStyleBackColor=true;
            ButtonReiniciarJogo.Click+=ButtonReiniciarJogo_Click;
            // 
            // LabelPlacar
            // 
            LabelPlacar.AutoSize=true;
            LabelPlacar.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelPlacar.ForeColor=Color.FromArgb(246, 246, 246);
            LabelPlacar.Location=new Point(202, 84);
            LabelPlacar.Name="LabelPlacar";
            LabelPlacar.Size=new Size(57, 21);
            LabelPlacar.TabIndex=11;
            LabelPlacar.Text="Placar";
            // 
            // LabelVitoriasX
            // 
            LabelVitoriasX.AutoSize=true;
            LabelVitoriasX.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelVitoriasX.ForeColor=Color.FromArgb(246, 246, 246);
            LabelVitoriasX.Location=new Point(202, 107);
            LabelVitoriasX.Name="LabelVitoriasX";
            LabelVitoriasX.Size=new Size(37, 21);
            LabelVitoriasX.TabIndex=12;
            LabelVitoriasX.Text="X: 0";
            // 
            // LabelVitoriasO
            // 
            LabelVitoriasO.AutoSize=true;
            LabelVitoriasO.Font=new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelVitoriasO.ForeColor=Color.FromArgb(246, 246, 246);
            LabelVitoriasO.Location=new Point(202, 130);
            LabelVitoriasO.Name="LabelVitoriasO";
            LabelVitoriasO.Size=new Size(39, 21);
            LabelVitoriasO.TabIndex=13;
            LabelVitoriasO.Text="O: 0";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.FromArgb(66, 66, 66);
            ClientSize=new Size(292, 231);
            Controls.Add(LabelJogador);
            Controls.Add(Button1);
            Controls.Add(Button2);
            Controls.Add(Button3);
            Controls.Add(Button4);
            Controls.Add(Button5);
            Controls.Add(Button6);
            Controls.Add(Button7);
            Controls.Add(Button8);
            Controls.Add(Button9);
            Controls.Add(ButtonReiniciarJogo);
            Controls.Add(LabelPlacar);
            Controls.Add(LabelVitoriasX);
            Controls.Add(LabelVitoriasO);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            Name="FormPrincipal";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Jogo da Velha";
            Load+=FormPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelJogador;
        private Button Button1;
        private Button Button2;
        private Button Button3;
        private Button Button4;
        private Button Button5;
        private Button Button6;
        private Button Button7;
        private Button Button8;
        private Button Button9;
        private Button ButtonReiniciarJogo;
        private Label LabelPlacar;
        private Label LabelVitoriasX;
        private Label LabelVitoriasO;
    }
}