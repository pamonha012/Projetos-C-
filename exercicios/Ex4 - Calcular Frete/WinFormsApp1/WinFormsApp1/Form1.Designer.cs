namespace WinFormsApp1
{
    partial class FormCalcular
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
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNomeVendedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxValorVenda = new System.Windows.Forms.TextBox();
            this.labelValor = new System.Windows.Forms.Label();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.labelEstad = new System.Windows.Forms.Label();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSair = new System.Windows.Forms.Button();
            this.labelFret = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelValorVenda = new System.Windows.Forms.Label();
            this.labelValorFrete = new System.Windows.Forms.Label();
            this.labelValorTotal = new System.Windows.Forms.Label();
            this.labelAviso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(12, 66);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(148, 21);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome do vendedor:";
            // 
            // textBoxNomeVendedor
            // 
            this.textBoxNomeVendedor.Location = new System.Drawing.Point(166, 63);
            this.textBoxNomeVendedor.Name = "textBoxNomeVendedor";
            this.textBoxNomeVendedor.Size = new System.Drawing.Size(261, 29);
            this.textBoxNomeVendedor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(100, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cálculo de Frete ";
            // 
            // textBoxValorVenda
            // 
            this.textBoxValorVenda.Location = new System.Drawing.Point(166, 112);
            this.textBoxValorVenda.Name = "textBoxValorVenda";
            this.textBoxValorVenda.Size = new System.Drawing.Size(84, 29);
            this.textBoxValorVenda.TabIndex = 4;
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(12, 115);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(116, 21);
            this.labelValor.TabIndex = 3;
            this.labelValor.Text = "Valor da venda:";
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.BackColor = System.Drawing.Color.Green;
            this.buttonCalcular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCalcular.ForeColor = System.Drawing.Color.White;
            this.buttonCalcular.Location = new System.Drawing.Point(102, 177);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(75, 30);
            this.buttonCalcular.TabIndex = 5;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = false;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonLimpar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLimpar.ForeColor = System.Drawing.Color.White;
            this.buttonLimpar.Location = new System.Drawing.Point(183, 177);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 31);
            this.buttonLimpar.TabIndex = 6;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = false;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // labelEstad
            // 
            this.labelEstad.AutoSize = true;
            this.labelEstad.Location = new System.Drawing.Point(256, 116);
            this.labelEstad.Name = "labelEstad";
            this.labelEstad.Size = new System.Drawing.Size(59, 21);
            this.labelEstad.TabIndex = 7;
            this.labelEstad.Text = "Estado:";
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.BackColor = System.Drawing.Color.White;
            this.comboBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.comboBoxEstado.Location = new System.Drawing.Point(321, 113);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(106, 29);
            this.comboBoxEstado.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Valor da venda:";
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.Maroon;
            this.buttonSair.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSair.ForeColor = System.Drawing.Color.White;
            this.buttonSair.Location = new System.Drawing.Point(264, 177);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 31);
            this.buttonSair.TabIndex = 10;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // labelFret
            // 
            this.labelFret.AutoSize = true;
            this.labelFret.Location = new System.Drawing.Point(21, 274);
            this.labelFret.Name = "labelFret";
            this.labelFret.Size = new System.Drawing.Size(52, 21);
            this.labelFret.TabIndex = 11;
            this.labelFret.Text = "Frete: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Valor total:";
            // 
            // labelValorVenda
            // 
            this.labelValorVenda.AutoSize = true;
            this.labelValorVenda.BackColor = System.Drawing.Color.Transparent;
            this.labelValorVenda.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelValorVenda.ForeColor = System.Drawing.Color.Green;
            this.labelValorVenda.Location = new System.Drawing.Point(131, 235);
            this.labelValorVenda.Name = "labelValorVenda";
            this.labelValorVenda.Size = new System.Drawing.Size(14, 21);
            this.labelValorVenda.TabIndex = 13;
            this.labelValorVenda.Text = ".";
            this.labelValorVenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelValorFrete
            // 
            this.labelValorFrete.AutoSize = true;
            this.labelValorFrete.BackColor = System.Drawing.Color.Transparent;
            this.labelValorFrete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelValorFrete.ForeColor = System.Drawing.Color.Green;
            this.labelValorFrete.Location = new System.Drawing.Point(67, 274);
            this.labelValorFrete.Name = "labelValorFrete";
            this.labelValorFrete.Size = new System.Drawing.Size(14, 21);
            this.labelValorFrete.TabIndex = 14;
            this.labelValorFrete.Text = ".";
            this.labelValorFrete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelValorTotal
            // 
            this.labelValorTotal.AutoSize = true;
            this.labelValorTotal.BackColor = System.Drawing.Color.Transparent;
            this.labelValorTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelValorTotal.ForeColor = System.Drawing.Color.Green;
            this.labelValorTotal.Location = new System.Drawing.Point(101, 308);
            this.labelValorTotal.Name = "labelValorTotal";
            this.labelValorTotal.Size = new System.Drawing.Size(14, 21);
            this.labelValorTotal.TabIndex = 15;
            this.labelValorTotal.Text = ".";
            this.labelValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAviso
            // 
            this.labelAviso.AutoSize = true;
            this.labelAviso.Location = new System.Drawing.Point(285, 329);
            this.labelAviso.Name = "labelAviso";
            this.labelAviso.Size = new System.Drawing.Size(0, 21);
            this.labelAviso.TabIndex = 16;
            // 
            // FormCalcular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(445, 358);
            this.Controls.Add(this.labelAviso);
            this.Controls.Add(this.labelValorTotal);
            this.Controls.Add(this.labelValorFrete);
            this.Controls.Add(this.labelValorVenda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelFret);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.labelEstad);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.textBoxValorVenda);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNomeVendedor);
            this.Controls.Add(this.labelNome);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalcular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNome;
        private TextBox textBoxNomeVendedor;
        private Label label1;
        private TextBox textBoxValorVenda;
        private Label labelValor;
        private Button buttonCalcular;
        private Button buttonLimpar;
        private Label labelEstad;
        private ComboBox comboBoxEstado;
        private Label label2;
        private Button buttonSair;
        private Label labelFret;
        private Label label3;
        private Label labelValorVenda;
        private Label labelValorFrete;
        private Label labelValorTotal;
        private Label labelAviso;
    }
}