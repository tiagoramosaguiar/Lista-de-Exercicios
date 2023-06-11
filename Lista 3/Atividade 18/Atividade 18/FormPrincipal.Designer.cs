namespace Atividade_18
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
            TextTamanho=new TextBox();
            ComboFigura=new ComboBox();
            ButtonDesenhar=new Button();
            LabelFigura=new Label();
            label1=new Label();
            LabelTamanho=new Label();
            SuspendLayout();
            // 
            // TextTamanho
            // 
            TextTamanho.BackColor=Color.FromArgb(246, 246, 246);
            TextTamanho.Location=new Point(92, 133);
            TextTamanho.Name="TextTamanho";
            TextTamanho.Size=new Size(100, 23);
            TextTamanho.TabIndex=1;
            TextTamanho.TextAlign=HorizontalAlignment.Center;
            TextTamanho.KeyPress+=TextTamanho_KeyPress;
            // 
            // ComboFigura
            // 
            ComboFigura.BackColor=Color.FromArgb(246, 246, 246);
            ComboFigura.DropDownStyle=ComboBoxStyle.DropDownList;
            ComboFigura.FormattingEnabled=true;
            ComboFigura.Items.AddRange(new object[] { "Losango", "Triângulo" });
            ComboFigura.Location=new Point(92, 80);
            ComboFigura.Name="ComboFigura";
            ComboFigura.Size=new Size(100, 23);
            ComboFigura.TabIndex=0;
            // 
            // ButtonDesenhar
            // 
            ButtonDesenhar.Location=new Point(104, 171);
            ButtonDesenhar.Name="ButtonDesenhar";
            ButtonDesenhar.Size=new Size(75, 23);
            ButtonDesenhar.TabIndex=2;
            ButtonDesenhar.Text="Desenhar";
            ButtonDesenhar.UseVisualStyleBackColor=true;
            ButtonDesenhar.Click+=ButtonDesenhar_Click;
            // 
            // LabelFigura
            // 
            LabelFigura.AutoSize=true;
            LabelFigura.ForeColor=Color.FromArgb(246, 246, 246);
            LabelFigura.Location=new Point(102, 62);
            LabelFigura.Name="LabelFigura";
            LabelFigura.Size=new Size(80, 15);
            LabelFigura.TabIndex=3;
            LabelFigura.Text="Tipo de figura";
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(280, 179);
            label1.Name="label1";
            label1.Size=new Size(38, 15);
            label1.TabIndex=4;
            label1.Text="label1";
            // 
            // LabelTamanho
            // 
            LabelTamanho.AutoSize=true;
            LabelTamanho.ForeColor=Color.FromArgb(246, 246, 246);
            LabelTamanho.Location=new Point(114, 115);
            LabelTamanho.Name="LabelTamanho";
            LabelTamanho.Size=new Size(56, 15);
            LabelTamanho.TabIndex=5;
            LabelTamanho.Text="Tamanho";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.FromArgb(66, 66, 66);
            ClientSize=new Size(284, 261);
            Controls.Add(LabelTamanho);
            Controls.Add(label1);
            Controls.Add(LabelFigura);
            Controls.Add(ButtonDesenhar);
            Controls.Add(ComboFigura);
            Controls.Add(TextTamanho);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            Name="FormPrincipal";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Desenho";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextTamanho;
        private ComboBox ComboFigura;
        private Button ButtonDesenhar;
        private Label LabelFigura;
        private Label label1;
        private Label LabelTamanho;
    }
}