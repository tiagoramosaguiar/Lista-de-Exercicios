namespace Atividade_2
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
            LabelQuantCavalos=new Label();
            TextQuantCavalos=new TextBox();
            ButtonCalcular=new Button();
            SuspendLayout();
            // 
            // LabelQuantCavalos
            // 
            LabelQuantCavalos.AutoSize=true;
            LabelQuantCavalos.ForeColor=Color.FromArgb(246, 246, 246);
            LabelQuantCavalos.Location=new Point(119, 90);
            LabelQuantCavalos.Name="LabelQuantCavalos";
            LabelQuantCavalos.Size=new Size(48, 15);
            LabelQuantCavalos.TabIndex=2;
            LabelQuantCavalos.Text="Cavalos";
            // 
            // TextQuantCavalos
            // 
            TextQuantCavalos.BackColor=Color.FromArgb(246, 246, 246);
            TextQuantCavalos.Location=new Point(92, 108);
            TextQuantCavalos.Name="TextQuantCavalos";
            TextQuantCavalos.Size=new Size(100, 23);
            TextQuantCavalos.TabIndex=0;
            TextQuantCavalos.TextAlign=HorizontalAlignment.Center;
            TextQuantCavalos.KeyPress+=TextQuantCavalos_KeyPress;
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
            Controls.Add(LabelQuantCavalos);
            Controls.Add(TextQuantCavalos);
            Controls.Add(ButtonCalcular);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            Name="formPrincipal";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Haras";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelQuantCavalos;
        private TextBox TextQuantCavalos;
        private Button ButtonCalcular;
    }
}