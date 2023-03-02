namespace WinFormsApp1
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.buttonExibir = new System.Windows.Forms.Button();
            this.labelStatusNome = new System.Windows.Forms.Label();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.labelCidade = new System.Windows.Forms.Label();
            this.labelStatusTelefone = new System.Windows.Forms.Label();
            this.labelStatusCidade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(139, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "SEJA BEM-VINDO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Informe seu nome:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxNome.Location = new System.Drawing.Point(168, 61);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(215, 29);
            this.textBoxNome.TabIndex = 2;
            // 
            // buttonExibir
            // 
            this.buttonExibir.Location = new System.Drawing.Point(57, 367);
            this.buttonExibir.Name = "buttonExibir";
            this.buttonExibir.Size = new System.Drawing.Size(132, 31);
            this.buttonExibir.TabIndex = 3;
            this.buttonExibir.Text = "Exibir";
            this.buttonExibir.UseVisualStyleBackColor = true;
            this.buttonExibir.Click += new System.EventHandler(this.buttonExibir_Click);
            // 
            // labelStatusNome
            // 
            this.labelStatusNome.AutoSize = true;
            this.labelStatusNome.BackColor = System.Drawing.Color.Transparent;
            this.labelStatusNome.ForeColor = System.Drawing.Color.Black;
            this.labelStatusNome.Location = new System.Drawing.Point(12, 187);
            this.labelStatusNome.Name = "labelStatusNome";
            this.labelStatusNome.Size = new System.Drawing.Size(0, 21);
            this.labelStatusNome.TabIndex = 4;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(206, 367);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(132, 31);
            this.buttonLimpar.TabIndex = 6;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxTelefone.Location = new System.Drawing.Point(168, 145);
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(215, 29);
            this.textBoxTelefone.TabIndex = 8;
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.BackColor = System.Drawing.Color.Transparent;
            this.labelTelefone.ForeColor = System.Drawing.Color.Black;
            this.labelTelefone.Location = new System.Drawing.Point(8, 148);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(156, 21);
            this.labelTelefone.TabIndex = 7;
            this.labelTelefone.Text = "Informe seu telefone:";
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxCidade.Location = new System.Drawing.Point(168, 104);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(215, 29);
            this.textBoxCidade.TabIndex = 10;
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.BackColor = System.Drawing.Color.Transparent;
            this.labelCidade.ForeColor = System.Drawing.Color.Black;
            this.labelCidade.Location = new System.Drawing.Point(8, 107);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(129, 21);
            this.labelCidade.TabIndex = 9;
            this.labelCidade.Text = "Informe a cidade:";
            // 
            // labelStatusTelefone
            // 
            this.labelStatusTelefone.AutoSize = true;
            this.labelStatusTelefone.Location = new System.Drawing.Point(12, 224);
            this.labelStatusTelefone.Name = "labelStatusTelefone";
            this.labelStatusTelefone.Size = new System.Drawing.Size(0, 21);
            this.labelStatusTelefone.TabIndex = 11;
            // 
            // labelStatusCidade
            // 
            this.labelStatusCidade.AutoSize = true;
            this.labelStatusCidade.Location = new System.Drawing.Point(12, 263);
            this.labelStatusCidade.Name = "labelStatusCidade";
            this.labelStatusCidade.Size = new System.Drawing.Size(0, 21);
            this.labelStatusCidade.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(392, 410);
            this.Controls.Add(this.labelStatusCidade);
            this.Controls.Add(this.labelStatusTelefone);
            this.Controls.Add(this.textBoxCidade);
            this.Controls.Add(this.labelCidade);
            this.Controls.Add(this.textBoxTelefone);
            this.Controls.Add(this.labelTelefone);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.labelStatusNome);
            this.Controls.Add(this.buttonExibir);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela inicial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxNome;
        private Button buttonExibir;
        private Label labelStatusNome;
        private Button buttonLimpar;
        private TextBox textBoxTelefone;
        private Label labelTelefone;
        private TextBox textBoxCidade;
        private Label labelCidade;
        private Label labelStatusTelefone;
        private Label labelStatusCidade;
    }
}