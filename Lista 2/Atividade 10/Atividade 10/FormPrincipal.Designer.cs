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
            LabelLadoA=new Label();
            TextLadoA=new TextBox();
            LabelLadoB=new Label();
            TextLadoB=new TextBox();
            LabelLadoC=new Label();
            TextLadoC=new TextBox();
            ButtonCalcular=new Button();
            SuspendLayout();
            // 
            // LabelLadoA
            // 
            LabelLadoA.AutoSize=true;
            LabelLadoA.ForeColor=Color.FromArgb(246, 246, 246);
            LabelLadoA.Location=new Point(121, 38);
            LabelLadoA.Name="LabelLadoA";
            LabelLadoA.Size=new Size(44, 15);
            LabelLadoA.TabIndex=4;
            LabelLadoA.Text="Lado A";
            // 
            // TextLadoA
            // 
            TextLadoA.BackColor=Color.FromArgb(246, 246, 246);
            TextLadoA.Location=new Point(93, 56);
            TextLadoA.Name="TextLadoA";
            TextLadoA.Size=new Size(100, 23);
            TextLadoA.TabIndex=0;
            TextLadoA.TextAlign=HorizontalAlignment.Center;
            TextLadoA.KeyPress+=TextLadoA_KeyPress;
            // 
            // LabelLadoB
            // 
            LabelLadoB.AutoSize=true;
            LabelLadoB.ForeColor=Color.FromArgb(246, 246, 246);
            LabelLadoB.Location=new Point(122, 91);
            LabelLadoB.Name="LabelLadoB";
            LabelLadoB.Size=new Size(43, 15);
            LabelLadoB.TabIndex=5;
            LabelLadoB.Text="Lado B";
            // 
            // TextLadoB
            // 
            TextLadoB.BackColor=Color.FromArgb(246, 246, 246);
            TextLadoB.Location=new Point(93, 109);
            TextLadoB.Name="TextLadoB";
            TextLadoB.Size=new Size(100, 23);
            TextLadoB.TabIndex=1;
            TextLadoB.TextAlign=HorizontalAlignment.Center;
            TextLadoB.KeyPress+=TextLadoB_KeyPress;
            // 
            // LabelLadoC
            // 
            LabelLadoC.AutoSize=true;
            LabelLadoC.ForeColor=Color.FromArgb(246, 246, 246);
            LabelLadoC.Location=new Point(121, 144);
            LabelLadoC.Name="LabelLadoC";
            LabelLadoC.Size=new Size(44, 15);
            LabelLadoC.TabIndex=6;
            LabelLadoC.Text="Lado C";
            // 
            // TextLadoC
            // 
            TextLadoC.BackColor=Color.FromArgb(246, 246, 246);
            TextLadoC.Location=new Point(93, 162);
            TextLadoC.Name="TextLadoC";
            TextLadoC.Size=new Size(100, 23);
            TextLadoC.TabIndex=2;
            TextLadoC.TextAlign=HorizontalAlignment.Center;
            TextLadoC.KeyPress+=TextLadoC_KeyPress;
            // 
            // ButtonCalcular
            // 
            ButtonCalcular.BackColor=Color.FromArgb(246, 246, 246);
            ButtonCalcular.Location=new Point(105, 200);
            ButtonCalcular.Name="ButtonCalcular";
            ButtonCalcular.Size=new Size(75, 23);
            ButtonCalcular.TabIndex=3;
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
            Controls.Add(LabelLadoA);
            Controls.Add(TextLadoA);
            Controls.Add(LabelLadoB);
            Controls.Add(TextLadoB);
            Controls.Add(LabelLadoC);
            Controls.Add(TextLadoC);
            Controls.Add(ButtonCalcular);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            Name="FormPrincipal";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Lado do triângulo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelLadoA;
        private TextBox TextLadoA;
        private Label LabelLadoB;
        private TextBox TextLadoB;
        private Label LabelLadoC;
        private TextBox TextLadoC;
        private Button ButtonCalcular;
    }
}