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
            LabelCodigoProduto=new Label();
            TextCodigoProduto=new TextBox();
            ButtonLerCodigo=new Button();
            SuspendLayout();
            // 
            // LabelCodigoProduto
            // 
            LabelCodigoProduto.AutoSize=true;
            LabelCodigoProduto.ForeColor=Color.FromArgb(246, 246, 246);
            LabelCodigoProduto.Location=new Point(88, 90);
            LabelCodigoProduto.Name="LabelCodigoProduto";
            LabelCodigoProduto.Size=new Size(109, 15);
            LabelCodigoProduto.TabIndex=2;
            LabelCodigoProduto.Text="Código do produto";
            // 
            // TextCodigoProduto
            // 
            TextCodigoProduto.BackColor=Color.FromArgb(246, 246, 246);
            TextCodigoProduto.Location=new Point(92, 108);
            TextCodigoProduto.Name="TextCodigoProduto";
            TextCodigoProduto.Size=new Size(100, 23);
            TextCodigoProduto.TabIndex=0;
            TextCodigoProduto.TextAlign=HorizontalAlignment.Center;
            TextCodigoProduto.KeyPress+=TextCodigoClassificacao_KeyPress;
            // 
            // ButtonLerCodigo
            // 
            ButtonLerCodigo.BackColor=Color.FromArgb(246, 246, 246);
            ButtonLerCodigo.Location=new Point(104, 146);
            ButtonLerCodigo.Name="ButtonLerCodigo";
            ButtonLerCodigo.Size=new Size(75, 23);
            ButtonLerCodigo.TabIndex=1;
            ButtonLerCodigo.Text="Ler Código";
            ButtonLerCodigo.UseVisualStyleBackColor=false;
            ButtonLerCodigo.Click+=ButtonLerCodigo_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.FromArgb(66, 66, 66);
            ClientSize=new Size(284, 261);
            Controls.Add(LabelCodigoProduto);
            Controls.Add(TextCodigoProduto);
            Controls.Add(ButtonLerCodigo);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            Name="FormPrincipal";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Classificar produtos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelCodigoProduto;
        private TextBox TextCodigoProduto;
        private Button ButtonLerCodigo;
    }
}