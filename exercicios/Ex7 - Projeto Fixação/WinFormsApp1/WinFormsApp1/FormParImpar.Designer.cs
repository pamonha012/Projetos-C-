﻿namespace WinFormsApp1
{
    partial class FormParImpar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxImparPar = new System.Windows.Forms.TextBox();
            this.buttonVerificar = new System.Windows.Forms.Button();
            this.Voltar = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "ímpar ou Par";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxImparPar
            // 
            this.textBoxImparPar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxImparPar.Location = new System.Drawing.Point(27, 76);
            this.textBoxImparPar.Name = "textBoxImparPar";
            this.textBoxImparPar.Size = new System.Drawing.Size(197, 35);
            this.textBoxImparPar.TabIndex = 4;
            this.textBoxImparPar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonVerificar
            // 
            this.buttonVerificar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonVerificar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonVerificar.ForeColor = System.Drawing.Color.White;
            this.buttonVerificar.Location = new System.Drawing.Point(47, 145);
            this.buttonVerificar.Name = "buttonVerificar";
            this.buttonVerificar.Size = new System.Drawing.Size(149, 46);
            this.buttonVerificar.TabIndex = 5;
            this.buttonVerificar.TabStop = false;
            this.buttonVerificar.Text = "Verificar ";
            this.buttonVerificar.UseVisualStyleBackColor = false;
            this.buttonVerificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Voltar
            // 
            this.Voltar.Location = new System.Drawing.Point(3, 274);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(59, 23);
            this.Voltar.TabIndex = 6;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLimpar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLimpar.ForeColor = System.Drawing.Color.White;
            this.buttonLimpar.Location = new System.Drawing.Point(47, 202);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(149, 46);
            this.buttonLimpar.TabIndex = 8;
            this.buttonLimpar.TabStop = false;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = false;
            this.buttonLimpar.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormParImpar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 301);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.buttonVerificar);
            this.Controls.Add(this.textBoxImparPar);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormParImpar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "parimpar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxImparPar;
        private Button buttonVerificar;
        private Button Voltar;
        private Button buttonLimpar;
    }
}