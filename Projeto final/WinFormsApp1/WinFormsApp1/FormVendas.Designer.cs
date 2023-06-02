namespace WinFormsApp1
{
    partial class FormVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVendas));
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.comboBoxProduto = new System.Windows.Forms.ComboBox();
            this.TextBoxValorUni = new System.Windows.Forms.MaskedTextBox();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.TextBoxSubTotal = new System.Windows.Forms.MaskedTextBox();
            this.TextBoxTotal = new System.Windows.Forms.MaskedTextBox();
            this.labelResultado = new System.Windows.Forms.Label();
            this.groupBoxPagamento = new System.Windows.Forms.GroupBox();
            this.radioButtonCredito = new System.Windows.Forms.RadioButton();
            this.radioButtonDinheiro = new System.Windows.Forms.RadioButton();
            this.groupBoxParcelas = new System.Windows.Forms.GroupBox();
            this.textBox10 = new System.Windows.Forms.MaskedTextBox();
            this.textBox6 = new System.Windows.Forms.MaskedTextBox();
            this.textBox3 = new System.Windows.Forms.MaskedTextBox();
            this.textBoxVista = new System.Windows.Forms.MaskedTextBox();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButtonVista = new System.Windows.Forms.RadioButton();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBoxPagamento.SuspendLayout();
            this.groupBoxParcelas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonVoltar.Location = new System.Drawing.Point(14, 14);
            this.buttonVoltar.Margin = new System.Windows.Forms.Padding(5);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(44, 38);
            this.buttonVoltar.TabIndex = 67;
            this.buttonVoltar.Text = " ←";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("BankGothic Lt BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(272, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 34);
            this.label5.TabIndex = 68;
            this.label5.Text = "Vendas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 69;
            this.label1.Text = "PRODUTO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 70;
            this.label2.Text = "MARCA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 71;
            this.label3.Text = "VALOR UNITÁRIO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 72;
            this.label4.Text = "SUB-TOTAL:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 74;
            this.label6.Text = "TOTAL:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(345, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 25);
            this.label7.TabIndex = 73;
            this.label7.Text = "QUANTIDADE:";
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(154, 96);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(180, 33);
            this.comboBoxMarca.TabIndex = 75;
            // 
            // comboBoxProduto
            // 
            this.comboBoxProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProduto.FormattingEnabled = true;
            this.comboBoxProduto.Location = new System.Drawing.Point(154, 151);
            this.comboBoxProduto.Name = "comboBoxProduto";
            this.comboBoxProduto.Size = new System.Drawing.Size(180, 33);
            this.comboBoxProduto.TabIndex = 76;
            // 
            // TextBoxValorUni
            // 
            this.TextBoxValorUni.Location = new System.Drawing.Point(513, 93);
            this.TextBoxValorUni.Name = "TextBoxValorUni";
            this.TextBoxValorUni.Size = new System.Drawing.Size(133, 33);
            this.TextBoxValorUni.TabIndex = 78;
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Location = new System.Drawing.Point(513, 146);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(133, 33);
            this.textBoxQuantidade.TabIndex = 79;
            // 
            // TextBoxSubTotal
            // 
            this.TextBoxSubTotal.Location = new System.Drawing.Point(154, 199);
            this.TextBoxSubTotal.Name = "TextBoxSubTotal";
            this.TextBoxSubTotal.Size = new System.Drawing.Size(133, 33);
            this.TextBoxSubTotal.TabIndex = 80;
            // 
            // TextBoxTotal
            // 
            this.TextBoxTotal.Location = new System.Drawing.Point(513, 199);
            this.TextBoxTotal.Name = "TextBoxTotal";
            this.TextBoxTotal.Size = new System.Drawing.Size(133, 33);
            this.TextBoxTotal.TabIndex = 81;
            // 
            // labelResultado
            // 
            this.labelResultado.BackColor = System.Drawing.Color.White;
            this.labelResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelResultado.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelResultado.Location = new System.Drawing.Point(38, 397);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(455, 185);
            this.labelResultado.TabIndex = 82;
            this.labelResultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxPagamento
            // 
            this.groupBoxPagamento.Controls.Add(this.radioButtonCredito);
            this.groupBoxPagamento.Controls.Add(this.radioButtonDinheiro);
            this.groupBoxPagamento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxPagamento.Location = new System.Drawing.Point(38, 255);
            this.groupBoxPagamento.Name = "groupBoxPagamento";
            this.groupBoxPagamento.Size = new System.Drawing.Size(159, 121);
            this.groupBoxPagamento.TabIndex = 83;
            this.groupBoxPagamento.TabStop = false;
            this.groupBoxPagamento.Text = "PAGAMENTO";
            // 
            // radioButtonCredito
            // 
            this.radioButtonCredito.AutoSize = true;
            this.radioButtonCredito.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonCredito.Location = new System.Drawing.Point(11, 71);
            this.radioButtonCredito.Name = "radioButtonCredito";
            this.radioButtonCredito.Size = new System.Drawing.Size(79, 25);
            this.radioButtonCredito.TabIndex = 1;
            this.radioButtonCredito.TabStop = true;
            this.radioButtonCredito.Text = "Crédito";
            this.radioButtonCredito.UseVisualStyleBackColor = true;
            // 
            // radioButtonDinheiro
            // 
            this.radioButtonDinheiro.AutoSize = true;
            this.radioButtonDinheiro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonDinheiro.Location = new System.Drawing.Point(11, 40);
            this.radioButtonDinheiro.Name = "radioButtonDinheiro";
            this.radioButtonDinheiro.Size = new System.Drawing.Size(120, 25);
            this.radioButtonDinheiro.TabIndex = 0;
            this.radioButtonDinheiro.TabStop = true;
            this.radioButtonDinheiro.Text = "Dinheiro -5%";
            this.radioButtonDinheiro.UseVisualStyleBackColor = true;
            // 
            // groupBoxParcelas
            // 
            this.groupBoxParcelas.Controls.Add(this.textBox10);
            this.groupBoxParcelas.Controls.Add(this.textBox6);
            this.groupBoxParcelas.Controls.Add(this.textBox3);
            this.groupBoxParcelas.Controls.Add(this.textBoxVista);
            this.groupBoxParcelas.Controls.Add(this.radioButton10);
            this.groupBoxParcelas.Controls.Add(this.radioButton6);
            this.groupBoxParcelas.Controls.Add(this.radioButton3);
            this.groupBoxParcelas.Controls.Add(this.radioButtonVista);
            this.groupBoxParcelas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxParcelas.Location = new System.Drawing.Point(221, 255);
            this.groupBoxParcelas.Name = "groupBoxParcelas";
            this.groupBoxParcelas.Size = new System.Drawing.Size(425, 121);
            this.groupBoxParcelas.TabIndex = 84;
            this.groupBoxParcelas.TabStop = false;
            this.groupBoxParcelas.Text = "PARCELAS";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(292, 81);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(116, 29);
            this.textBox10.TabIndex = 27;
            this.textBox10.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(292, 34);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(116, 29);
            this.textBox6.TabIndex = 26;
            this.textBox6.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(107, 81);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(116, 29);
            this.textBox3.TabIndex = 25;
            this.textBox3.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // textBoxVista
            // 
            this.textBoxVista.Location = new System.Drawing.Point(107, 35);
            this.textBoxVista.Name = "textBoxVista";
            this.textBoxVista.Size = new System.Drawing.Size(116, 29);
            this.textBoxVista.TabIndex = 24;
            this.textBoxVista.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton10.Location = new System.Drawing.Point(239, 81);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(53, 25);
            this.radioButton10.TabIndex = 3;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "10x";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton6.Location = new System.Drawing.Point(239, 35);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(44, 25);
            this.radioButton6.TabIndex = 2;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "6x";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton3.Location = new System.Drawing.Point(9, 81);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(44, 25);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "3x";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButtonVista
            // 
            this.radioButtonVista.AutoSize = true;
            this.radioButtonVista.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonVista.Location = new System.Drawing.Point(9, 35);
            this.radioButtonVista.Name = "radioButtonVista";
            this.radioButtonVista.Size = new System.Drawing.Size(76, 25);
            this.radioButtonVista.TabIndex = 0;
            this.radioButtonVista.TabStop = true;
            this.radioButtonVista.Text = "À Vista";
            this.radioButtonVista.UseVisualStyleBackColor = true;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonLimpar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLimpar.ForeColor = System.Drawing.Color.White;
            this.buttonLimpar.Location = new System.Drawing.Point(519, 462);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(127, 42);
            this.buttonLimpar.TabIndex = 86;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = false;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonCalcular.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCalcular.ForeColor = System.Drawing.Color.White;
            this.buttonCalcular.Location = new System.Drawing.Point(519, 397);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(127, 42);
            this.buttonCalcular.TabIndex = 85;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = false;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(571, 532);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 87;
            this.pictureBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("BankGothic Lt BT", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(335, 589);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(338, 12);
            this.label13.TabIndex = 88;
            this.label13.Text = "O único óleo que faz bem para o seu corpo e bem estar";
            // 
            // FormVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 608);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.groupBoxParcelas);
            this.Controls.Add(this.groupBoxPagamento);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.TextBoxTotal);
            this.Controls.Add(this.TextBoxSubTotal);
            this.Controls.Add(this.textBoxQuantidade);
            this.Controls.Add(this.TextBoxValorUni);
            this.Controls.Add(this.comboBoxProduto);
            this.Controls.Add(this.comboBoxMarca);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonVoltar);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.groupBoxPagamento.ResumeLayout(false);
            this.groupBoxPagamento.PerformLayout();
            this.groupBoxParcelas.ResumeLayout(false);
            this.groupBoxParcelas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonVoltar;
        private Label label5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private ComboBox comboBoxMarca;
        private ComboBox comboBoxProduto;
        private MaskedTextBox TextBoxValorUni;
        private TextBox textBoxQuantidade;
        private MaskedTextBox TextBoxSubTotal;
        private MaskedTextBox TextBoxTotal;
        private Label labelResultado;
        private GroupBox groupBoxPagamento;
        private RadioButton radioButtonCredito;
        private RadioButton radioButtonDinheiro;
        private GroupBox groupBoxParcelas;
        private MaskedTextBox textBox10;
        private MaskedTextBox textBox6;
        private MaskedTextBox textBox3;
        private MaskedTextBox textBoxVista;
        private RadioButton radioButton10;
        private RadioButton radioButton6;
        private RadioButton radioButton3;
        private RadioButton radioButtonVista;
        private Button buttonLimpar;
        private Button buttonCalcular;
        private PictureBox pictureBox1;
        private Label label13;
    }
}