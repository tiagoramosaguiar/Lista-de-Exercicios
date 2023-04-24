namespace Atividade_12
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
            LabelAltura=new Label();
            TextAltura=new TextBox();
            LabelSexo=new Label();
            ComboSexo=new ComboBox();
            ButtonCalcular=new Button();
            SuspendLayout();
            // 
            // LabelAltura
            // 
            LabelAltura.AutoSize=true;
            LabelAltura.ForeColor=Color.FromArgb(246, 246, 246);
            LabelAltura.Location=new Point(123, 62);
            LabelAltura.Name="LabelAltura";
            LabelAltura.Size=new Size(39, 15);
            LabelAltura.TabIndex=4;
            LabelAltura.Text="Altura";
            // 
            // TextAltura
            // 
            TextAltura.BackColor=Color.FromArgb(246, 246, 246);
            TextAltura.Location=new Point(92, 80);
            TextAltura.Name="TextAltura";
            TextAltura.Size=new Size(100, 23);
            TextAltura.TabIndex=0;
            TextAltura.TextAlign=HorizontalAlignment.Center;
            TextAltura.KeyPress+=TextAltura_KeyPress;
            // 
            // LabelSexo
            // 
            LabelSexo.AutoSize=true;
            LabelSexo.ForeColor=Color.FromArgb(246, 246, 246);
            LabelSexo.Location=new Point(126, 115);
            LabelSexo.Name="LabelSexo";
            LabelSexo.Size=new Size(32, 15);
            LabelSexo.TabIndex=3;
            LabelSexo.Text="Sexo";
            // 
            // ComboSexo
            // 
            ComboSexo.BackColor=Color.FromArgb(246, 246, 246);
            ComboSexo.DropDownStyle=ComboBoxStyle.DropDownList;
            ComboSexo.FormattingEnabled=true;
            ComboSexo.Items.AddRange(new object[] { "M", "F" });
            ComboSexo.Location=new Point(92, 133);
            ComboSexo.Name="ComboSexo";
            ComboSexo.Size=new Size(100, 23);
            ComboSexo.TabIndex=1;
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
            Controls.Add(LabelAltura);
            Controls.Add(TextAltura);
            Controls.Add(LabelSexo);
            Controls.Add(ComboSexo);
            Controls.Add(ButtonCalcular);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            Name="FormPrincipal";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Peso ideal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelAltura;
        private TextBox TextAltura;
        private Label LabelSexo;
        private ComboBox ComboSexo;
        private Button ButtonCalcular;
    }
}