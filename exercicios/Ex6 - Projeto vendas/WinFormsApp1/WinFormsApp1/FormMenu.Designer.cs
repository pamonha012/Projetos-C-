namespace WinFormsApp1
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.buttonCliente = new System.Windows.Forms.Button();
            this.buttonProduto = new System.Windows.Forms.Button();
            this.buttonFornecedor = new System.Windows.Forms.Button();
            this.buttonVendas = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonMarca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCliente
            // 
            this.buttonCliente.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCliente.Location = new System.Drawing.Point(324, 81);
            this.buttonCliente.Name = "buttonCliente";
            this.buttonCliente.Size = new System.Drawing.Size(195, 38);
            this.buttonCliente.TabIndex = 1;
            this.buttonCliente.Text = "Clientes";
            this.buttonCliente.UseVisualStyleBackColor = true;
            this.buttonCliente.Click += new System.EventHandler(this.buttonCliente_Click);
            // 
            // buttonProduto
            // 
            this.buttonProduto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonProduto.Location = new System.Drawing.Point(324, 125);
            this.buttonProduto.Name = "buttonProduto";
            this.buttonProduto.Size = new System.Drawing.Size(195, 38);
            this.buttonProduto.TabIndex = 2;
            this.buttonProduto.Text = "Produtos";
            this.buttonProduto.UseVisualStyleBackColor = true;
            this.buttonProduto.Click += new System.EventHandler(this.buttonProduto_Click);
            // 
            // buttonFornecedor
            // 
            this.buttonFornecedor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFornecedor.Location = new System.Drawing.Point(324, 169);
            this.buttonFornecedor.Name = "buttonFornecedor";
            this.buttonFornecedor.Size = new System.Drawing.Size(195, 38);
            this.buttonFornecedor.TabIndex = 3;
            this.buttonFornecedor.Text = "Fornecedores";
            this.buttonFornecedor.UseVisualStyleBackColor = true;
            this.buttonFornecedor.Click += new System.EventHandler(this.buttonFornecedor_Click);
            // 
            // buttonVendas
            // 
            this.buttonVendas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonVendas.Location = new System.Drawing.Point(324, 213);
            this.buttonVendas.Name = "buttonVendas";
            this.buttonVendas.Size = new System.Drawing.Size(195, 38);
            this.buttonVendas.TabIndex = 5;
            this.buttonVendas.Text = "Vendas";
            this.buttonVendas.UseVisualStyleBackColor = true;
            this.buttonVendas.Click += new System.EventHandler(this.buttonVendas_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Geometr415 Blk BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(81, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(405, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Loja Tuda na palma da sua Mão";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(560, 403);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // buttonMarca
            // 
            this.buttonMarca.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMarca.Location = new System.Drawing.Point(324, 257);
            this.buttonMarca.Name = "buttonMarca";
            this.buttonMarca.Size = new System.Drawing.Size(195, 38);
            this.buttonMarca.TabIndex = 8;
            this.buttonMarca.Text = "Marcas";
            this.buttonMarca.UseVisualStyleBackColor = true;
            this.buttonMarca.Click += new System.EventHandler(this.buttonMarca_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 396);
            this.Controls.Add(this.buttonMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonVendas);
            this.Controls.Add(this.buttonFornecedor);
            this.Controls.Add(this.buttonProduto);
            this.Controls.Add(this.buttonCliente);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button buttonCliente;
        private Button buttonProduto;
        private Button buttonFornecedor;
        private Button buttonVendas;
        private Label label2;
        private PictureBox pictureBox1;
        private Button buttonMarca;
    }
}