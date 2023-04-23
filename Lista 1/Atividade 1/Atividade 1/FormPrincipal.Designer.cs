namespace Atividade_1
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
            LabelLarguraTerreno=new Label();
            TextLarguraTerreno=new TextBox();
            LabelComprimentoTerreno=new Label();
            TextComprimentoTerreno=new TextBox();
            ButtonCalcular=new Button();
            SuspendLayout();
            // 
            // LabelLarguraTerreno
            // 
            LabelLarguraTerreno.AutoSize=true;
            LabelLarguraTerreno.ForeColor=Color.FromArgb(246, 246, 246);
            LabelLarguraTerreno.Location=new Point(119, 62);
            LabelLarguraTerreno.Name="LabelLarguraTerreno";
            LabelLarguraTerreno.Size=new Size(47, 15);
            LabelLarguraTerreno.TabIndex=3;
            LabelLarguraTerreno.Text="Largura";
            // 
            // TextLarguraTerreno
            // 
            TextLarguraTerreno.BackColor=Color.FromArgb(246, 246, 246);
            TextLarguraTerreno.Location=new Point(92, 80);
            TextLarguraTerreno.Name="TextLarguraTerreno";
            TextLarguraTerreno.Size=new Size(100, 23);
            TextLarguraTerreno.TabIndex=0;
            TextLarguraTerreno.TextAlign=HorizontalAlignment.Center;
            TextLarguraTerreno.KeyPress+=TextLarguraTerreno_KeyPress;
            // 
            // LabelComprimentoTerreno
            // 
            LabelComprimentoTerreno.AutoSize=true;
            LabelComprimentoTerreno.ForeColor=Color.FromArgb(246, 246, 246);
            LabelComprimentoTerreno.Location=new Point(101, 115);
            LabelComprimentoTerreno.Name="LabelComprimentoTerreno";
            LabelComprimentoTerreno.Size=new Size(82, 15);
            LabelComprimentoTerreno.TabIndex=4;
            LabelComprimentoTerreno.Text="Comprimento";
            // 
            // TextComprimentoTerreno
            // 
            TextComprimentoTerreno.BackColor=Color.FromArgb(246, 246, 246);
            TextComprimentoTerreno.Location=new Point(92, 133);
            TextComprimentoTerreno.Name="TextComprimentoTerreno";
            TextComprimentoTerreno.Size=new Size(100, 23);
            TextComprimentoTerreno.TabIndex=1;
            TextComprimentoTerreno.TextAlign=HorizontalAlignment.Center;
            TextComprimentoTerreno.KeyPress+=TextComprimentoTerreno_KeyPress;
            // 
            // ButtonCalcular
            // 
            ButtonCalcular.BackColor=Color.FromArgb(246, 246, 246);
            ButtonCalcular.Location=new Point(104, 171);
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
            Controls.Add(LabelLarguraTerreno);
            Controls.Add(TextLarguraTerreno);
            Controls.Add(LabelComprimentoTerreno);
            Controls.Add(TextComprimentoTerreno);
            Controls.Add(ButtonCalcular);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            Name="FormPrincipal";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Imóbilis";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextLarguraTerreno;
        private Label LabelLarguraTerreno;
        private TextBox TextComprimentoTerreno;
        private Label LabelComprimentoTerreno;
        private Button ButtonCalcular;
    }
}