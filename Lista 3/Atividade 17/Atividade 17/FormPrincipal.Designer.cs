namespace Atividade_17
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
            ComboTipo=new ComboBox();
            ComboGravidade=new ComboBox();
            ButtonRegistrar=new Button();
            LabelTipo=new Label();
            LabelGravidade=new Label();
            SuspendLayout();
            // 
            // ComboTipo
            // 
            ComboTipo.BackColor=Color.FromArgb(246, 246, 246);
            ComboTipo.DropDownStyle=ComboBoxStyle.DropDownList;
            ComboTipo.FormattingEnabled=true;
            ComboTipo.Items.AddRange(new object[] { "Direção Perigosa", "Barulho", "Bebedeira", "Homer" });
            ComboTipo.Location=new Point(82, 80);
            ComboTipo.Name="ComboTipo";
            ComboTipo.Size=new Size(121, 23);
            ComboTipo.TabIndex=0;
            // 
            // ComboGravidade
            // 
            ComboGravidade.BackColor=Color.FromArgb(246, 246, 246);
            ComboGravidade.DropDownStyle=ComboBoxStyle.DropDownList;
            ComboGravidade.FormattingEnabled=true;
            ComboGravidade.Items.AddRange(new object[] { "Baixo", "Médio", "Alto" });
            ComboGravidade.Location=new Point(82, 133);
            ComboGravidade.Name="ComboGravidade";
            ComboGravidade.Size=new Size(121, 23);
            ComboGravidade.TabIndex=1;
            // 
            // ButtonRegistrar
            // 
            ButtonRegistrar.BackColor=Color.FromArgb(246, 246, 246);
            ButtonRegistrar.Location=new Point(104, 171);
            ButtonRegistrar.Name="ButtonRegistrar";
            ButtonRegistrar.Size=new Size(75, 23);
            ButtonRegistrar.TabIndex=2;
            ButtonRegistrar.Text="Registrar";
            ButtonRegistrar.UseVisualStyleBackColor=false;
            ButtonRegistrar.Click+=ButtonRegistrar_Click;
            // 
            // LabelTipo
            // 
            LabelTipo.AutoSize=true;
            LabelTipo.ForeColor=Color.FromArgb(246, 246, 246);
            LabelTipo.Location=new Point(89, 62);
            LabelTipo.Name="LabelTipo";
            LabelTipo.Size=new Size(105, 15);
            LabelTipo.TabIndex=3;
            LabelTipo.Text="Tipo de ocorrência";
            // 
            // LabelGravidade
            // 
            LabelGravidade.AutoSize=true;
            LabelGravidade.ForeColor=Color.FromArgb(246, 246, 246);
            LabelGravidade.Location=new Point(75, 115);
            LabelGravidade.Name="LabelGravidade";
            LabelGravidade.Size=new Size(135, 15);
            LabelGravidade.TabIndex=4;
            LabelGravidade.Text="Gravidade da ocorrência";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.FromArgb(66, 66, 66);
            ClientSize=new Size(284, 261);
            Controls.Add(LabelGravidade);
            Controls.Add(LabelTipo);
            Controls.Add(ButtonRegistrar);
            Controls.Add(ComboGravidade);
            Controls.Add(ComboTipo);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            Name="FormPrincipal";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Delegacia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ComboTipo;
        private ComboBox ComboGravidade;
        private Button ButtonRegistrar;
        private Label LabelTipo;
        private Label LabelGravidade;
    }
}