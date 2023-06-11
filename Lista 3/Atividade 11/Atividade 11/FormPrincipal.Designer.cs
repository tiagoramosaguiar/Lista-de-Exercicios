namespace Atividade_11
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
            LabelNumero=new Label();
            TextNumero=new TextBox();
            LabelInicioTabuada=new Label();
            TextInicioTabuada=new TextBox();
            LabelFimTabuada=new Label();
            TextFimTabuada=new TextBox();
            ButtonGerarTabuada=new Button();
            SuspendLayout();
            // 
            // LabelNumero
            // 
            LabelNumero.AutoSize=true;
            LabelNumero.ForeColor=Color.FromArgb(246, 246, 246);
            LabelNumero.Location=new Point(117, 38);
            LabelNumero.Name="LabelNumero";
            LabelNumero.Size=new Size(51, 15);
            LabelNumero.TabIndex=4;
            LabelNumero.Text="Número";
            // 
            // TextNumero
            // 
            TextNumero.BackColor=Color.FromArgb(246, 246, 246);
            TextNumero.Location=new Point(93, 56);
            TextNumero.Name="TextNumero";
            TextNumero.Size=new Size(100, 23);
            TextNumero.TabIndex=0;
            TextNumero.TextAlign=HorizontalAlignment.Center;
            TextNumero.KeyPress+=TextNumero_KeyPress;
            // 
            // LabelInicioTabuada
            // 
            LabelInicioTabuada.AutoSize=true;
            LabelInicioTabuada.ForeColor=Color.FromArgb(246, 246, 246);
            LabelInicioTabuada.Location=new Point(94, 91);
            LabelInicioTabuada.Name="LabelInicioTabuada";
            LabelInicioTabuada.Size=new Size(98, 15);
            LabelInicioTabuada.TabIndex=5;
            LabelInicioTabuada.Text="Início da tabuada";
            // 
            // TextInicioTabuada
            // 
            TextInicioTabuada.BackColor=Color.FromArgb(246, 246, 246);
            TextInicioTabuada.Location=new Point(93, 109);
            TextInicioTabuada.Name="TextInicioTabuada";
            TextInicioTabuada.Size=new Size(100, 23);
            TextInicioTabuada.TabIndex=1;
            TextInicioTabuada.TextAlign=HorizontalAlignment.Center;
            TextInicioTabuada.KeyPress+=TextInicioTabuada_KeyPress;
            // 
            // LabelFimTabuada
            // 
            LabelFimTabuada.AutoSize=true;
            LabelFimTabuada.ForeColor=Color.FromArgb(246, 246, 246);
            LabelFimTabuada.Location=new Point(99, 144);
            LabelFimTabuada.Name="LabelFimTabuada";
            LabelFimTabuada.Size=new Size(89, 15);
            LabelFimTabuada.TabIndex=6;
            LabelFimTabuada.Text="Fim da tabuada";
            // 
            // TextFimTabuada
            // 
            TextFimTabuada.BackColor=Color.FromArgb(246, 246, 246);
            TextFimTabuada.Location=new Point(93, 162);
            TextFimTabuada.Name="TextFimTabuada";
            TextFimTabuada.Size=new Size(100, 23);
            TextFimTabuada.TabIndex=2;
            TextFimTabuada.TextAlign=HorizontalAlignment.Center;
            TextFimTabuada.KeyPress+=TextFimTabuada_KeyPress;
            // 
            // ButtonGerarTabuada
            // 
            ButtonGerarTabuada.BackColor=Color.FromArgb(246, 246, 246);
            ButtonGerarTabuada.Location=new Point(93, 200);
            ButtonGerarTabuada.Name="ButtonGerarTabuada";
            ButtonGerarTabuada.Size=new Size(100, 23);
            ButtonGerarTabuada.TabIndex=3;
            ButtonGerarTabuada.Text="Gerar tabuada";
            ButtonGerarTabuada.UseVisualStyleBackColor=false;
            ButtonGerarTabuada.Click+=ButtonGerarTabuada_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.FromArgb(66, 66, 66);
            ClientSize=new Size(284, 261);
            Controls.Add(LabelNumero);
            Controls.Add(TextNumero);
            Controls.Add(LabelInicioTabuada);
            Controls.Add(TextInicioTabuada);
            Controls.Add(LabelFimTabuada);
            Controls.Add(TextFimTabuada);
            Controls.Add(ButtonGerarTabuada);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            Name="FormPrincipal";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Gerador de tabuadas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelNumero;
        private TextBox TextNumero;
        private Label LabelInicioTabuada;
        private TextBox TextInicioTabuada;
        private Label LabelFimTabuada;
        private TextBox TextFimTabuada;
        private Button ButtonGerarTabuada;
    }
}