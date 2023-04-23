namespace Atividade_9
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
            LabelPrecoProduto=new Label();
            TextPrecoProduto=new TextBox();
            ButtonCalcular=new Button();
            SuspendLayout();
            // 
            // LabelPrecoProduto
            // 
            LabelPrecoProduto.AutoSize=true;
            LabelPrecoProduto.ForeColor=Color.FromArgb(246, 246, 246);
            LabelPrecoProduto.Location=new Point(92, 90);
            LabelPrecoProduto.Name="LabelPrecoProduto";
            LabelPrecoProduto.Size=new Size(100, 15);
            LabelPrecoProduto.TabIndex=2;
            LabelPrecoProduto.Text="Preço do produto";
            // 
            // TextPrecoProduto
            // 
            TextPrecoProduto.BackColor=Color.FromArgb(246, 246, 246);
            TextPrecoProduto.Location=new Point(92, 108);
            TextPrecoProduto.Name="TextPrecoProduto";
            TextPrecoProduto.Size=new Size(100, 23);
            TextPrecoProduto.TabIndex=0;
            TextPrecoProduto.TextAlign=HorizontalAlignment.Center;
            TextPrecoProduto.KeyPress+=TextPrecoProduto_KeyPress;
            // 
            // ButtonCalcular
            // 
            ButtonCalcular.BackColor=Color.FromArgb(246, 246, 246);
            ButtonCalcular.Location=new Point(104, 146);
            ButtonCalcular.Name="ButtonCalcular";
            ButtonCalcular.Size=new Size(75, 23);
            ButtonCalcular.TabIndex=1;
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
            Controls.Add(LabelPrecoProduto);
            Controls.Add(ButtonCalcular);
            Controls.Add(TextPrecoProduto);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            Name="FormPrincipal";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Vendas Parceladas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelPrecoProduto;
        private TextBox TextPrecoProduto;
        private Button ButtonCalcular;
    }
}