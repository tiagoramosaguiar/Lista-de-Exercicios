﻿namespace Atividade_8
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
            LabelNumero=new Label();
            TextNumero=new TextBox();
            ButtonChecar=new Button();
            SuspendLayout();
            // 
            // LabelNumero
            // 
            LabelNumero.AutoSize=true;
            LabelNumero.ForeColor=Color.FromArgb(246, 246, 246);
            LabelNumero.Location=new Point(117, 90);
            LabelNumero.Name="LabelNumero";
            LabelNumero.Size=new Size(51, 15);
            LabelNumero.TabIndex=0;
            LabelNumero.Text="Número";
            // 
            // TextNumero
            // 
            TextNumero.BackColor=Color.FromArgb(246, 246, 246);
            TextNumero.Location=new Point(92, 108);
            TextNumero.Name="TextNumero";
            TextNumero.Size=new Size(100, 23);
            TextNumero.TabIndex=1;
            TextNumero.TextAlign=HorizontalAlignment.Center;
            TextNumero.KeyPress+=TextNumero_KeyPress;
            // 
            // ButtonChecar
            // 
            ButtonChecar.BackColor=Color.FromArgb(246, 246, 246);
            ButtonChecar.Location=new Point(104, 146);
            ButtonChecar.Name="ButtonChecar";
            ButtonChecar.Size=new Size(75, 23);
            ButtonChecar.TabIndex=2;
            ButtonChecar.Text="Checar";
            ButtonChecar.UseVisualStyleBackColor=false;
            ButtonChecar.Click+=ButtonChecar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.FromArgb(66, 66, 66);
            ClientSize=new Size(284, 261);
            Controls.Add(LabelNumero);
            Controls.Add(TextNumero);
            Controls.Add(ButtonChecar);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            Name="FormPrincipal";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Par ou ímpar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelNumero;
        private TextBox TextNumero;
        private Button ButtonChecar;
    }
}