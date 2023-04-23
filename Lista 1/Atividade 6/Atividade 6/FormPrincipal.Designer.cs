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
            LabelPesoPrato=new Label();
            TextPesoPrato=new TextBox();
            ButtonCalcular=new Button();
            SuspendLayout();
            // 
            // LabelPesoPrato
            // 
            LabelPesoPrato.AutoSize=true;
            LabelPesoPrato.ForeColor=Color.FromArgb(246, 246, 246);
            LabelPesoPrato.Location=new Point(84, 90);
            LabelPesoPrato.Name="LabelPesoPrato";
            LabelPesoPrato.Size=new Size(117, 15);
            LabelPesoPrato.TabIndex=2;
            LabelPesoPrato.Text="Peso do prato em KG";
            // 
            // TextPesoPrato
            // 
            TextPesoPrato.BackColor=Color.FromArgb(246, 246, 246);
            TextPesoPrato.Location=new Point(92, 108);
            TextPesoPrato.Name="TextPesoPrato";
            TextPesoPrato.Size=new Size(100, 23);
            TextPesoPrato.TabIndex=0;
            TextPesoPrato.TextAlign=HorizontalAlignment.Center;
            TextPesoPrato.KeyPress+=TextPesoPrato_KeyPress;
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
            Controls.Add(LabelPesoPrato);
            Controls.Add(TextPesoPrato);
            Controls.Add(ButtonCalcular);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            Name="FormPrincipal";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Bem-Bão";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelPesoPrato;
        private TextBox TextPesoPrato;
        private Button ButtonCalcular;
    }
}