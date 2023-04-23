using System.Windows.Forms;

namespace Atividade_3
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
            TextQuantPaes=new TextBox();
            LabelQuantPaes=new Label();
            LabelQuantBroas=new Label();
            TextQuantBroas=new TextBox();
            ButtonCalcular=new Button();
            SuspendLayout();
            // 
            // LabelQuantPaes
            // 
            LabelQuantPaes.AutoSize=true;
            LabelQuantPaes.ForeColor=Color.FromArgb(246, 246, 246);
            LabelQuantPaes.Location=new Point(101, 65);
            LabelQuantPaes.Name="LabelQuantPaes";
            LabelQuantPaes.Size=new Size(83, 15);
            LabelQuantPaes.TabIndex=1;
            LabelQuantPaes.Text="Pães franceses";
            // 
            // TextQuantPaes
            // 
            TextQuantPaes.BackColor=Color.FromArgb(246, 246, 246);
            TextQuantPaes.Location=new Point(92, 83);
            TextQuantPaes.Name="TextQuantPaes";
            TextQuantPaes.Size=new Size(100, 23);
            TextQuantPaes.TabIndex=0;
            TextQuantPaes.TextAlign=HorizontalAlignment.Center;
            TextQuantPaes.KeyPress+=TextQuantPaes_KeyPress;
            // 
            // LabelQuantBroas
            // 
            LabelQuantBroas.AutoSize=true;
            LabelQuantBroas.ForeColor=Color.FromArgb(246, 246, 246);
            LabelQuantBroas.Location=new Point(125, 118);
            LabelQuantBroas.Name="LabelQuantBroas";
            LabelQuantBroas.Size=new Size(36, 15);
            LabelQuantBroas.TabIndex=3;
            LabelQuantBroas.Text="Broas";
            // 
            // TextQuantBroas
            // 
            TextQuantBroas.BackColor=Color.FromArgb(246, 246, 246);
            TextQuantBroas.Location=new Point(92, 136);
            TextQuantBroas.Name="textQuantBroas";
            TextQuantBroas.Size=new Size(100, 23);
            TextQuantBroas.TabIndex=2;
            TextQuantBroas.TextAlign=HorizontalAlignment.Center;
            TextQuantBroas.KeyPress+=TextQuantBroas_KeyPress;
            // 
            // ButtonCalcular
            // 
            ButtonCalcular.BackColor=Color.FromArgb(246, 246, 246);
            ButtonCalcular.Location=new Point(104, 174);
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
            ClientSize=new Size(284, 261);
            Controls.Add(LabelQuantPaes);
            Controls.Add(TextQuantPaes);
            Controls.Add(LabelQuantBroas);
            Controls.Add(TextQuantBroas);
            Controls.Add(ButtonCalcular);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            Name="FormPrincipal";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Hotpão";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelQuantPaes;
        private TextBox TextQuantPaes;
        private Label LabelQuantBroas;
        private TextBox TextQuantBroas;
        private Button ButtonCalcular;
    }
}