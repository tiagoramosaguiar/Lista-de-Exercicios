namespace Atividade_14
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
            LabelCombustivel=new Label();
            ComboCombustivel=new ComboBox();
            LabelCapacidadeTanque=new Label();
            TextCapacidadeTanque=new TextBox();
            ButtonCalcular=new Button();
            SuspendLayout();
            // 
            // LabelCombustivel
            // 
            LabelCombustivel.AutoSize=true;
            LabelCombustivel.ForeColor=Color.FromArgb(246, 246, 246);
            LabelCombustivel.Location=new Point(105, 62);
            LabelCombustivel.Name="LabelCombustivel";
            LabelCombustivel.Size=new Size(74, 15);
            LabelCombustivel.TabIndex=3;
            LabelCombustivel.Text="Combustível";
            // 
            // ComboCombustivel
            // 
            ComboCombustivel.BackColor=Color.FromArgb(246, 246, 246);
            ComboCombustivel.DropDownStyle=ComboBoxStyle.DropDownList;
            ComboCombustivel.FormattingEnabled=true;
            ComboCombustivel.Items.AddRange(new object[] { "Gasolina", "Álcool" });
            ComboCombustivel.Location=new Point(92, 80);
            ComboCombustivel.Name="ComboCombustivel";
            ComboCombustivel.Size=new Size(100, 23);
            ComboCombustivel.TabIndex=0;
            // 
            // LabelCapacidadeTanque
            // 
            LabelCapacidadeTanque.AutoSize=true;
            LabelCapacidadeTanque.ForeColor=Color.FromArgb(246, 246, 246);
            LabelCapacidadeTanque.Location=new Point(79, 115);
            LabelCapacidadeTanque.Name="LabelCapacidadeTanque";
            LabelCapacidadeTanque.Size=new Size(126, 15);
            LabelCapacidadeTanque.TabIndex=4;
            LabelCapacidadeTanque.Text="Capacidade do tanque";
            // 
            // TextCapacidadeTanque
            // 
            TextCapacidadeTanque.BackColor=Color.FromArgb(246, 246, 246);
            TextCapacidadeTanque.Location=new Point(92, 133);
            TextCapacidadeTanque.Name="TextCapacidadeTanque";
            TextCapacidadeTanque.Size=new Size(100, 23);
            TextCapacidadeTanque.TabIndex=1;
            TextCapacidadeTanque.TextAlign=HorizontalAlignment.Center;
            TextCapacidadeTanque.KeyPress+=TextCapacidadeTanque_KeyPress;
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
            Controls.Add(LabelCombustivel);
            Controls.Add(ComboCombustivel);
            Controls.Add(LabelCapacidadeTanque);
            Controls.Add(TextCapacidadeTanque);
            Controls.Add(ButtonCalcular);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            Name="FormPrincipal";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Tanque cheio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelCombustivel;
        private ComboBox ComboCombustivel;
        private Label LabelCapacidadeTanque;
        private TextBox TextCapacidadeTanque;
        private Button ButtonCalcular;
    }
}