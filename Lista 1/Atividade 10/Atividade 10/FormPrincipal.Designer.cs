namespace Atividade_10
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
            LabelKMViagem=new Label();
            TextKMViagem=new TextBox();
            LabelKMLitro=new Label();
            TextKMLitro=new TextBox();
            LabelPrecoLitro=new Label();
            TextPrecoLitro=new TextBox();
            ButtonCalcular=new Button();
            SuspendLayout();
            // 
            // LabelKMViagem
            // 
            LabelKMViagem.AutoSize=true;
            LabelKMViagem.ForeColor=Color.FromArgb(246, 246, 246);
            LabelKMViagem.Location=new Point(70, 38);
            LabelKMViagem.Name="LabelKMViagem";
            LabelKMViagem.Size=new Size(149, 15);
            LabelKMViagem.TabIndex=3;
            LabelKMViagem.Text="Quilometragem da viagem";
            // 
            // TextKMViagem
            // 
            TextKMViagem.BackColor=Color.FromArgb(246, 246, 246);
            TextKMViagem.Location=new Point(93, 56);
            TextKMViagem.Name="TextKMViagem";
            TextKMViagem.Size=new Size(100, 23);
            TextKMViagem.TabIndex=0;
            TextKMViagem.TextAlign=HorizontalAlignment.Center;
            TextKMViagem.KeyPress+=TextKMViagem_KeyPress;
            // 
            // TextKMLitro
            // 
            TextKMLitro.BackColor=Color.FromArgb(246, 246, 246);
            TextKMLitro.Location=new Point(93, 109);
            TextKMLitro.Name="TextKMLitro";
            TextKMLitro.Size=new Size(100, 23);
            TextKMLitro.TabIndex=1;
            TextKMLitro.TextAlign=HorizontalAlignment.Center;
            TextKMLitro.KeyPress+=TextKMLitro_KeyPress;
            // 
            // LabelKMLitro
            //
            LabelKMLitro.AutoSize=true;
            LabelKMLitro.ForeColor=Color.FromArgb(246, 246, 246);
            LabelKMLitro.Location=new Point(45, 91);
            LabelKMLitro.Name="LabelKMLitro";
            LabelKMLitro.Size=new Size(198, 15);
            LabelKMLitro.TabIndex=4;
            LabelKMLitro.Text="Quilômetros por litro de combusível";
            // 
            // LabelPrecoLitro
            // 
            LabelPrecoLitro.AutoSize=true;
            LabelPrecoLitro.ForeColor=Color.FromArgb(246, 246, 246);
            LabelPrecoLitro.Location=new Point(62, 144);
            LabelPrecoLitro.Name="LabelPrecoLitro";
            LabelPrecoLitro.Size=new Size(162, 15);
            LabelPrecoLitro.TabIndex=5;
            LabelPrecoLitro.Text="Preço do litro de combustível";
            // 
            // TextPrecoLitro
            // 
            TextPrecoLitro.BackColor=Color.FromArgb(246, 246, 246);
            TextPrecoLitro.Location=new Point(93, 162);
            TextPrecoLitro.Name="TextPrecoLitro";
            TextPrecoLitro.Size=new Size(100, 23);
            TextPrecoLitro.TabIndex=2;
            TextPrecoLitro.TextAlign=HorizontalAlignment.Center;
            TextPrecoLitro.KeyPress+=TextPrecoLitro_KeyPress;
            // 
            // ButtonCalcular
            // 
            ButtonCalcular.BackColor=Color.FromArgb(246, 246, 246);
            ButtonCalcular.Location=new Point(104, 200);
            ButtonCalcular.Name="ButtonCalcular";
            ButtonCalcular.Size=new Size(75, 23);
            ButtonCalcular.TabIndex=6;
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
            Controls.Add(LabelKMViagem);
            Controls.Add(TextKMViagem);
            Controls.Add(LabelKMLitro);
            Controls.Add(TextKMLitro);
            Controls.Add(LabelPrecoLitro);
            Controls.Add(TextPrecoLitro);
            Controls.Add(ButtonCalcular);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            Name="FormPrincipal";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Viagem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelKMViagem;
        private TextBox TextKMViagem;
        private Label LabelKMLitro;
        private TextBox TextKMLitro;
        private Label LabelPrecoLitro;
        private TextBox TextPrecoLitro;
        private Button ButtonCalcular;
    }
}