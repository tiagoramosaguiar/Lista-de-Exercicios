namespace Atividade_8
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
            LabelCamisetasP=new Label();
            TextCamisetasP=new TextBox();
            LabelCamisetasM=new Label();
            TextCamisetasM=new TextBox();
            LabelCamisetasG=new Label();
            TextCamisetasG=new TextBox();
            ButtonCalcular=new Button();
            SuspendLayout();
            // 
            // LabelCamisetasP
            // 
            LabelCamisetasP.AutoSize=true;
            LabelCamisetasP.ForeColor=Color.FromArgb(246, 246, 246);
            LabelCamisetasP.Location=new Point(108, 38);
            LabelCamisetasP.Name="LabelCamisetasP";
            LabelCamisetasP.Size=new Size(71, 15);
            LabelCamisetasP.TabIndex=3;
            LabelCamisetasP.Text="Camisetas P";
            // 
            // TextCamisetasP
            // 
            TextCamisetasP.BackColor=Color.FromArgb(246, 246, 246);
            TextCamisetasP.Location=new Point(93, 56);
            TextCamisetasP.Name="TextCamisetasP";
            TextCamisetasP.Size=new Size(100, 23);
            TextCamisetasP.TabIndex=0;
            TextCamisetasP.TextAlign=HorizontalAlignment.Center;
            TextCamisetasP.KeyPress+=TextCamisetasP_KeyPress;
            // 
            // LabelCamisetasM
            // 
            LabelCamisetasM.AutoSize=true;
            LabelCamisetasM.ForeColor=Color.FromArgb(246, 246, 246);
            LabelCamisetasM.Location=new Point(106, 91);
            LabelCamisetasM.Name="LabelCamisetasM";
            LabelCamisetasM.Size=new Size(75, 15);
            LabelCamisetasM.TabIndex=4;
            LabelCamisetasM.Text="Camisetas M";
            // 
            // TextCamisetasM
            // 
            TextCamisetasM.BackColor=Color.FromArgb(246, 246, 246);
            TextCamisetasM.Location=new Point(93, 109);
            TextCamisetasM.Name="TextCamisetasM";
            TextCamisetasM.Size=new Size(100, 23);
            TextCamisetasM.TabIndex=1;
            TextCamisetasM.TextAlign=HorizontalAlignment.Center;
            TextCamisetasM.KeyPress+=TextCamisetasM_KeyPress;
            // 
            // LabelCamisetasG
            // 
            LabelCamisetasG.AutoSize=true;
            LabelCamisetasG.ForeColor=Color.FromArgb(246, 246, 246);
            LabelCamisetasG.Location=new Point(107, 144);
            LabelCamisetasG.Name="LabelCamisetasG";
            LabelCamisetasG.Size=new Size(72, 15);
            LabelCamisetasG.TabIndex=5;
            LabelCamisetasG.Text="Camisetas G";
            // 
            // TextCamisetasG
            // 
            TextCamisetasG.BackColor=Color.FromArgb(246, 246, 246);
            TextCamisetasG.Location=new Point(93, 162);
            TextCamisetasG.Name="TextCamisetasG";
            TextCamisetasG.Size=new Size(100, 23);
            TextCamisetasG.TabIndex=2;
            TextCamisetasG.TextAlign=HorizontalAlignment.Center;
            TextCamisetasG.KeyPress+=TextCamisetasG_KeyPress;
            // 
            // ButtonCalcular
            // 
            ButtonCalcular.BackColor=Color.FromArgb(246, 246, 246);
            ButtonCalcular.Location=new Point(105, 200);
            ButtonCalcular.Name="ButtonCalcular";
            ButtonCalcular.Size=new Size(75, 23);
            ButtonCalcular.TabIndex=6;
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
            Controls.Add(LabelCamisetasP);
            Controls.Add(TextCamisetasP);
            Controls.Add(LabelCamisetasM);
            Controls.Add(TextCamisetasM);
            Controls.Add(LabelCamisetasG);
            Controls.Add(TextCamisetasG);
            Controls.Add(ButtonCalcular);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            Name="FormPrincipal";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Camisetas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelCamisetasP;
        private TextBox TextCamisetasP;
        private Label LabelCamisetasM;
        private TextBox TextCamisetasM;
        private Label LabelCamisetasG;
        private TextBox TextCamisetasG;
        private Button ButtonCalcular;
    }
}