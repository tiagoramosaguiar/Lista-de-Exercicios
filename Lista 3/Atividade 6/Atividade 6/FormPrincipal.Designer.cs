namespace Atividade_6
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
            LabelElementoInicial=new Label();
            TextElementoInicial=new TextBox();
            LabelRazao=new Label();
            TextRazao=new TextBox();
            LabelQuantNumeros=new Label();
            TextQuantNumeros=new TextBox();
            ButtonCalcular=new Button();
            SuspendLayout();
            // 
            // LabelElementoInicial
            // 
            LabelElementoInicial.AutoSize=true;
            LabelElementoInicial.ForeColor=Color.FromArgb(246, 246, 246);
            LabelElementoInicial.Location=new Point(104, 42);
            LabelElementoInicial.Name="LabelElementoInicial";
            LabelElementoInicial.Size=new Size(91, 15);
            LabelElementoInicial.TabIndex=4;
            LabelElementoInicial.Text="Elemento inicial";
            // 
            // TextElementoInicial
            // 
            TextElementoInicial.BackColor=Color.FromArgb(246, 246, 246);
            TextElementoInicial.Location=new Point(99, 60);
            TextElementoInicial.Name="TextElementoInicial";
            TextElementoInicial.Size=new Size(100, 23);
            TextElementoInicial.TabIndex=0;
            TextElementoInicial.TextAlign=HorizontalAlignment.Center;
            TextElementoInicial.KeyPress+=TextElementoInicial_KeyPress;
            // 
            // LabelRazao
            // 
            LabelRazao.AutoSize=true;
            LabelRazao.ForeColor=Color.FromArgb(246, 246, 246);
            LabelRazao.Location=new Point(130, 95);
            LabelRazao.Name="LabelRazao";
            LabelRazao.Size=new Size(38, 15);
            LabelRazao.TabIndex=5;
            LabelRazao.Text="Razão";
            // 
            // TextRazao
            // 
            TextRazao.BackColor=Color.FromArgb(246, 246, 246);
            TextRazao.Location=new Point(99, 113);
            TextRazao.Name="TextRazao";
            TextRazao.Size=new Size(100, 23);
            TextRazao.TabIndex=1;
            TextRazao.TextAlign=HorizontalAlignment.Center;
            TextRazao.KeyPress+=TextRazao_KeyPress;
            // 
            // LabelQuantNumeros
            // 
            LabelQuantNumeros.AutoSize=true;
            LabelQuantNumeros.ForeColor=Color.FromArgb(246, 246, 246);
            LabelQuantNumeros.Location=new Point(82, 148);
            LabelQuantNumeros.Name="LabelQuantNumeros";
            LabelQuantNumeros.Size=new Size(135, 15);
            LabelQuantNumeros.TabIndex=6;
            LabelQuantNumeros.Text="Quantidade de números";
            // 
            // TextQuantNumeros
            // 
            TextQuantNumeros.BackColor=Color.FromArgb(246, 246, 246);
            TextQuantNumeros.Location=new Point(99, 166);
            TextQuantNumeros.Name="TextQuantNumeros";
            TextQuantNumeros.Size=new Size(100, 23);
            TextQuantNumeros.TabIndex=2;
            TextQuantNumeros.TextAlign=HorizontalAlignment.Center;
            TextQuantNumeros.KeyPress+=TextQuantNumeros_KeyPress;
            // 
            // ButtonCalcular
            // 
            ButtonCalcular.Location=new Point(111, 204);
            ButtonCalcular.Name="ButtonCalcular";
            ButtonCalcular.Size=new Size(75, 23);
            ButtonCalcular.TabIndex=3;
            ButtonCalcular.Text="Calcular";
            ButtonCalcular.UseVisualStyleBackColor=true;
            ButtonCalcular.Click+=ButtonCalcular_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.FromArgb(66, 66, 66);
            ClientSize=new Size(289, 266);
            Controls.Add(LabelElementoInicial);
            Controls.Add(TextElementoInicial);
            Controls.Add(LabelRazao);
            Controls.Add(TextRazao);
            Controls.Add(LabelQuantNumeros);
            Controls.Add(TextQuantNumeros);
            Controls.Add(ButtonCalcular);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            Name="FormPrincipal";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Progressão geométrica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelElementoInicial;
        private TextBox TextElementoInicial;
        private Label LabelRazao;
        private TextBox TextRazao;
        private Label LabelQuantNumeros;
        private TextBox TextQuantNumeros;
        private Button ButtonCalcular;
    }
}