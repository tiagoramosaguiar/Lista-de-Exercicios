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
            LabelTotalVendido=new Label();
            TextTotalVendido=new TextBox();
            ButtonCalcular=new Button();
            SuspendLayout();
            // 
            // LabelTotalVendido
            // 
            LabelTotalVendido.AutoSize=true;
            LabelTotalVendido.ForeColor=Color.FromArgb(246, 246, 246);
            LabelTotalVendido.Location=new Point(103, 90);
            LabelTotalVendido.Name="LabelTotalVendido";
            LabelTotalVendido.Size=new Size(78, 15);
            LabelTotalVendido.TabIndex=0;
            LabelTotalVendido.Text="Total vendido";
            // 
            // TextTotalVendido
            // 
            TextTotalVendido.BackColor=Color.FromArgb(246, 246, 246);
            TextTotalVendido.Location=new Point(92, 108);
            TextTotalVendido.Name="TextTotalVendido";
            TextTotalVendido.Size=new Size(100, 23);
            TextTotalVendido.TabIndex=1;
            TextTotalVendido.TextAlign=HorizontalAlignment.Center;
            TextTotalVendido.KeyPress+=TextTotalVendido_KeyPress;
            // 
            // ButtonCalcular
            // 
            ButtonCalcular.BackColor=Color.FromArgb(246, 246, 246);
            ButtonCalcular.Location=new Point(104, 146);
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
            Controls.Add(LabelTotalVendido);
            Controls.Add(TextTotalVendido);
            Controls.Add(ButtonCalcular);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            Name="FormPrincipal";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Comissão";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelTotalVendido;
        private TextBox TextTotalVendido;
        private Button ButtonCalcular;
    }
}