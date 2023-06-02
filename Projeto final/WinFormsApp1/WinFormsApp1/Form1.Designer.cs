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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonMarca = new System.Windows.Forms.Button();
            this.buttonVendas = new System.Windows.Forms.Button();
            this.buttonFornecedor = new System.Windows.Forms.Button();
            this.buttonProduto = new System.Windows.Forms.Button();
            this.buttonCliente = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Magneto", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(170, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Óleos essenciais";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("BankGothic Lt BT", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(313, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "O único óleo que faz bem para o seu corpo";
            // 
            // buttonMarca
            // 
            this.buttonMarca.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMarca.Location = new System.Drawing.Point(362, 398);
            this.buttonMarca.Name = "buttonMarca";
            this.buttonMarca.Size = new System.Drawing.Size(153, 38);
            this.buttonMarca.TabIndex = 13;
            this.buttonMarca.Text = "Marcas";
            this.buttonMarca.UseVisualStyleBackColor = true;
            this.buttonMarca.Click += new System.EventHandler(this.buttonMarca_Click);
            // 
            // buttonVendas
            // 
            this.buttonVendas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonVendas.Location = new System.Drawing.Point(158, 398);
            this.buttonVendas.Name = "buttonVendas";
            this.buttonVendas.Size = new System.Drawing.Size(153, 38);
            this.buttonVendas.TabIndex = 12;
            this.buttonVendas.Text = "Vendas";
            this.buttonVendas.UseVisualStyleBackColor = true;
            this.buttonVendas.Click += new System.EventHandler(this.buttonVendas_Click);
            // 
            // buttonFornecedor
            // 
            this.buttonFornecedor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFornecedor.Location = new System.Drawing.Point(463, 354);
            this.buttonFornecedor.Name = "buttonFornecedor";
            this.buttonFornecedor.Size = new System.Drawing.Size(153, 38);
            this.buttonFornecedor.TabIndex = 11;
            this.buttonFornecedor.Text = "Fornecedores";
            this.buttonFornecedor.UseVisualStyleBackColor = true;
            this.buttonFornecedor.Click += new System.EventHandler(this.buttonFornecedor_Click);
            // 
            // buttonProduto
            // 
            this.buttonProduto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonProduto.Location = new System.Drawing.Point(262, 354);
            this.buttonProduto.Name = "buttonProduto";
            this.buttonProduto.Size = new System.Drawing.Size(153, 38);
            this.buttonProduto.TabIndex = 10;
            this.buttonProduto.Text = "Produtos";
            this.buttonProduto.UseVisualStyleBackColor = true;
            this.buttonProduto.Click += new System.EventHandler(this.buttonProduto_Click);
            // 
            // buttonCliente
            // 
            this.buttonCliente.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCliente.Location = new System.Drawing.Point(61, 354);
            this.buttonCliente.Name = "buttonCliente";
            this.buttonCliente.Size = new System.Drawing.Size(153, 38);
            this.buttonCliente.TabIndex = 9;
            this.buttonCliente.Text = "Clientes";
            this.buttonCliente.UseVisualStyleBackColor = true;
            this.buttonCliente.Click += new System.EventHandler(this.buttonCliente_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonSair.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSair.ForeColor = System.Drawing.Color.White;
            this.buttonSair.Location = new System.Drawing.Point(618, 427);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(46, 23);
            this.buttonSair.TabIndex = 14;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(676, 453);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonMarca);
            this.Controls.Add(this.buttonVendas);
            this.Controls.Add(this.buttonFornecedor);
            this.Controls.Add(this.buttonProduto);
            this.Controls.Add(this.buttonCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button buttonMarca;
        private Button buttonVendas;
        private Button buttonFornecedor;
        private Button buttonProduto;
        private Button buttonCliente;
        private Button buttonSair;
    }
}