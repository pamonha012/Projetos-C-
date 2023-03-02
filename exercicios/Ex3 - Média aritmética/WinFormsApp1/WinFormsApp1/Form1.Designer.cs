namespace WinFormsApp1
{
    partial class FormNotas
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.textBoxPortugues = new System.Windows.Forms.TextBox();
            this.textBoxMatematica = new System.Windows.Forms.TextBox();
            this.labelMat = new System.Windows.Forms.Label();
            this.textBoxCiencias = new System.Windows.Forms.TextBox();
            this.labelCien = new System.Windows.Forms.Label();
            this.textBoxIngles = new System.Windows.Forms.TextBox();
            this.labelIng = new System.Windows.Forms.Label();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.labelNotaFinal = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Exotc350 Bd BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(69, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira suas notas:";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(60, 58);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(83, 21);
            this.labelPort.TabIndex = 1;
            this.labelPort.Text = "Português:";
            // 
            // textBoxPortugues
            // 
            this.textBoxPortugues.Location = new System.Drawing.Point(60, 82);
            this.textBoxPortugues.Name = "textBoxPortugues";
            this.textBoxPortugues.Size = new System.Drawing.Size(228, 29);
            this.textBoxPortugues.TabIndex = 2;
            this.textBoxPortugues.TextChanged += new System.EventHandler(this.textBoxPortugues_TextChanged);
            // 
            // textBoxMatematica
            // 
            this.textBoxMatematica.Location = new System.Drawing.Point(60, 139);
            this.textBoxMatematica.Name = "textBoxMatematica";
            this.textBoxMatematica.Size = new System.Drawing.Size(228, 29);
            this.textBoxMatematica.TabIndex = 4;
            this.textBoxMatematica.TextChanged += new System.EventHandler(this.textBoxMatematica_TextChanged);
            // 
            // labelMat
            // 
            this.labelMat.AutoSize = true;
            this.labelMat.Location = new System.Drawing.Point(60, 115);
            this.labelMat.Name = "labelMat";
            this.labelMat.Size = new System.Drawing.Size(94, 21);
            this.labelMat.TabIndex = 3;
            this.labelMat.Text = "Matemática:";
            // 
            // textBoxCiencias
            // 
            this.textBoxCiencias.Location = new System.Drawing.Point(60, 195);
            this.textBoxCiencias.Name = "textBoxCiencias";
            this.textBoxCiencias.Size = new System.Drawing.Size(228, 29);
            this.textBoxCiencias.TabIndex = 6;
            this.textBoxCiencias.TextChanged += new System.EventHandler(this.textBoxCiencias_TextChanged);
            // 
            // labelCien
            // 
            this.labelCien.AutoSize = true;
            this.labelCien.Location = new System.Drawing.Point(60, 172);
            this.labelCien.Name = "labelCien";
            this.labelCien.Size = new System.Drawing.Size(70, 21);
            this.labelCien.TabIndex = 5;
            this.labelCien.Text = "Ciências:";
            // 
            // textBoxIngles
            // 
            this.textBoxIngles.Location = new System.Drawing.Point(60, 252);
            this.textBoxIngles.Name = "textBoxIngles";
            this.textBoxIngles.Size = new System.Drawing.Size(228, 29);
            this.textBoxIngles.TabIndex = 8;
            this.textBoxIngles.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelIng
            // 
            this.labelIng.AutoSize = true;
            this.labelIng.Location = new System.Drawing.Point(60, 227);
            this.labelIng.Name = "labelIng";
            this.labelIng.Size = new System.Drawing.Size(54, 21);
            this.labelIng.TabIndex = 7;
            this.labelIng.Text = "Inglês:";
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCalcular.Location = new System.Drawing.Point(60, 375);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(228, 36);
            this.buttonCalcular.TabIndex = 9;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // labelNotaFinal
            // 
            this.labelNotaFinal.AutoSize = true;
            this.labelNotaFinal.Location = new System.Drawing.Point(105, 298);
            this.labelNotaFinal.Name = "labelNotaFinal";
            this.labelNotaFinal.Size = new System.Drawing.Size(0, 21);
            this.labelNotaFinal.TabIndex = 10;
            this.labelNotaFinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelResultado.Location = new System.Drawing.Point(12, 488);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(0, 21);
            this.labelResultado.TabIndex = 11;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLimpar.Location = new System.Drawing.Point(60, 422);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(228, 36);
            this.buttonLimpar.TabIndex = 12;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // FormNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 518);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.labelNotaFinal);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.textBoxIngles);
            this.Controls.Add(this.labelIng);
            this.Controls.Add(this.textBoxCiencias);
            this.Controls.Add(this.labelCien);
            this.Controls.Add(this.textBoxMatematica);
            this.Controls.Add(this.labelMat);
            this.Controls.Add(this.textBoxPortugues);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notas";
            this.Load += new System.EventHandler(this.FormPortugues_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormNotas_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label labelPort;
        private TextBox textBoxPortugues;
        private TextBox textBoxMatematica;
        private Label labelMat;
        private TextBox textBoxCiencias;
        private Label labelCien;
        private TextBox textBoxIngles;
        private Label labelIng;
        private Button buttonCalcular;
        private Label labelNotaFinal;
        private Label labelResultado;
        private Button buttonLimpar;
    }
}