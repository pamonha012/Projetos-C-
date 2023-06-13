namespace WinFormsApp1
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonLogar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxEscolha = new System.Windows.Forms.ComboBox();
            this.TextBoxCnpj = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(10, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "CPF:";
            // 
            // TextBoxCpf
            // 
            this.TextBoxCpf.Location = new System.Drawing.Point(13, 60);
            this.TextBoxCpf.Mask = "000,000,000-00";
            this.TextBoxCpf.Name = "TextBoxCpf";
            this.TextBoxCpf.Size = new System.Drawing.Size(161, 35);
            this.TextBoxCpf.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(88, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Senha:";
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(168, 116);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = '*';
            this.textBoxSenha.Size = new System.Drawing.Size(161, 35);
            this.textBoxSenha.TabIndex = 7;
            this.textBoxSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLimpar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLimpar.Location = new System.Drawing.Point(228, 159);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(60, 32);
            this.buttonLimpar.TabIndex = 9;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = false;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonLogar
            // 
            this.buttonLogar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLogar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLogar.Location = new System.Drawing.Point(127, 159);
            this.buttonLogar.Name = "buttonLogar";
            this.buttonLogar.Size = new System.Drawing.Size(60, 32);
            this.buttonLogar.TabIndex = 8;
            this.buttonLogar.Text = "Entrar";
            this.buttonLogar.UseVisualStyleBackColor = false;
            this.buttonLogar.Click += new System.EventHandler(this.buttonLogar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.buttonCadastrar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 66);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Você é novo aqui?";
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCadastrar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCadastrar.ForeColor = System.Drawing.Color.Black;
            this.buttonCadastrar.Location = new System.Drawing.Point(129, 38);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastrar.TabIndex = 9;
            this.buttonCadastrar.Text = "Cadastra-se";
            this.buttonCadastrar.UseVisualStyleBackColor = false;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Faça seu cadastro";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBoxEscolha
            // 
            this.comboBoxEscolha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEscolha.FormattingEnabled = true;
            this.comboBoxEscolha.Items.AddRange(new object[] {
            "Você é?",
            "Cliente",
            "Fornecedor"});
            this.comboBoxEscolha.Location = new System.Drawing.Point(264, 222);
            this.comboBoxEscolha.Name = "comboBoxEscolha";
            this.comboBoxEscolha.Size = new System.Drawing.Size(157, 38);
            this.comboBoxEscolha.TabIndex = 12;
            this.comboBoxEscolha.SelectedIndexChanged += new System.EventHandler(this.comboBoxEscolha_SelectedIndexChanged);
            // 
            // TextBoxCnpj
            // 
            this.TextBoxCnpj.Location = new System.Drawing.Point(218, 60);
            this.TextBoxCnpj.Mask = "00,000,000/0000-00";
            this.TextBoxCnpj.Name = "TextBoxCnpj";
            this.TextBoxCnpj.Size = new System.Drawing.Size(200, 35);
            this.TextBoxCnpj.TabIndex = 60;
            this.TextBoxCnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(214, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 61;
            this.label4.Text = "CNPJ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(178, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 25);
            this.label5.TabIndex = 62;
            this.label5.Text = "ou";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(433, 273);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBoxCnpj);
            this.Controls.Add(this.comboBoxEscolha);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonLogar);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxCpf);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "+";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private MaskedTextBox TextBoxCpf;
        private Label label1;
        private TextBox textBoxSenha;
        private Button buttonLimpar;
        private Button buttonLogar;
        private GroupBox groupBox1;
        private Button buttonCadastrar;
        private Label label2;
        private ComboBox comboBoxEscolha;
        private MaskedTextBox TextBoxCnpj;
        private Label label4;
        private Label label5;
    }
}