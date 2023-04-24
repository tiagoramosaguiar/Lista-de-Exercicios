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
            LabelA=new Label();
            TextA=new TextBox();
            LabelB=new Label();
            TextB=new TextBox();
            LabelC=new Label();
            TextC=new TextBox();
            ButtonCalcular=new Button();
            SuspendLayout();
            // 
            // LabelA
            // 
            LabelA.AutoSize=true;
            LabelA.ForeColor=Color.FromArgb(246, 246, 246);
            LabelA.Location=new Point(136, 38);
            LabelA.Name="LabelA";
            LabelA.Size=new Size(15, 15);
            LabelA.TabIndex=4;
            LabelA.Text="A";
            // 
            // TextA
            // 
            TextA.BackColor=Color.FromArgb(246, 246, 246);
            TextA.Location=new Point(93, 56);
            TextA.Name="TextA";
            TextA.Size=new Size(100, 23);
            TextA.TabIndex=0;
            TextA.TextAlign=HorizontalAlignment.Center;
            TextA.KeyPress+=TextA_KeyPress;
            // 
            // LabelB
            // 
            LabelB.AutoSize=true;
            LabelB.ForeColor=Color.FromArgb(246, 246, 246);
            LabelB.Location=new Point(136, 91);
            LabelB.Name="LabelB";
            LabelB.Size=new Size(14, 15);
            LabelB.TabIndex=5;
            LabelB.Text="B";
            // 
            // TextB
            // 
            TextB.BackColor=Color.FromArgb(246, 246, 246);
            TextB.Location=new Point(93, 109);
            TextB.Name="TextB";
            TextB.Size=new Size(100, 23);
            TextB.TabIndex=1;
            TextB.TextAlign=HorizontalAlignment.Center;
            TextB.KeyPress+=TextB_KeyPress;
            // 
            // LabelC
            // 
            LabelC.AutoSize=true;
            LabelC.ForeColor=Color.FromArgb(246, 246, 246);
            LabelC.Location=new Point(136, 144);
            LabelC.Name="LabelC";
            LabelC.Size=new Size(15, 15);
            LabelC.TabIndex=6;
            LabelC.Text="C";
            // 
            // TextC
            // 
            TextC.BackColor=Color.FromArgb(246, 246, 246);
            TextC.Location=new Point(93, 162);
            TextC.Name="TextC";
            TextC.Size=new Size(100, 23);
            TextC.TabIndex=2;
            TextC.TextAlign=HorizontalAlignment.Center;
            TextC.KeyPress+=TextC_KeyPress;
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
            Controls.Add(LabelA);
            Controls.Add(TextA);
            Controls.Add(LabelB);
            Controls.Add(TextB);
            Controls.Add(LabelC);
            Controls.Add(TextC);
            Controls.Add(ButtonCalcular);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            Name="FormPrincipal";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Lei de Pitot";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelA;
        private TextBox TextA;
        private Label LabelB;
        private TextBox TextB;
        private Label LabelC;
        private TextBox TextC;
        private Button ButtonCalcular;
    }
}