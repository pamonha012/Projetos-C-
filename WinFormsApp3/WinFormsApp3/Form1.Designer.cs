namespace WinFormsApp3
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
            this.components = new System.ComponentModel.Container();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.labelHora = new System.Windows.Forms.Label();
            this.groupBoxDataAtual = new System.Windows.Forms.GroupBox();
            this.labelData = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelCalendario = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelComboBox2 = new System.Windows.Forms.Label();
            this.labelComboBox = new System.Windows.Forms.Label();
            this.comboBoxBairros = new System.Windows.Forms.ComboBox();
            this.comboBoxNomes = new System.Windows.Forms.ComboBox();
            this.groupBoxCheckBox = new System.Windows.Forms.GroupBox();
            this.labelCheckBox = new System.Windows.Forms.Label();
            this.checkBoxFemi = new System.Windows.Forms.CheckBox();
            this.checkBoxMascu = new System.Windows.Forms.CheckBox();
            this.groupBoxRadioButton = new System.Windows.Forms.GroupBox();
            this.labelRadioButton = new System.Windows.Forms.Label();
            this.radioButtonCorPreta = new System.Windows.Forms.RadioButton();
            this.radioButtonCorBranca = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelDia = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox6.SuspendLayout();
            this.groupBoxDataAtual.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxCheckBox.SuspendLayout();
            this.groupBoxRadioButton.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.labelHora);
            this.groupBox6.Location = new System.Drawing.Point(401, 408);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(272, 121);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hora";
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Location = new System.Drawing.Point(8, 49);
            this.labelHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(0, 21);
            this.labelHora.TabIndex = 0;
            // 
            // groupBoxDataAtual
            // 
            this.groupBoxDataAtual.Controls.Add(this.labelData);
            this.groupBoxDataAtual.Location = new System.Drawing.Point(401, 279);
            this.groupBoxDataAtual.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxDataAtual.Name = "groupBoxDataAtual";
            this.groupBoxDataAtual.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxDataAtual.Size = new System.Drawing.Size(272, 121);
            this.groupBoxDataAtual.TabIndex = 12;
            this.groupBoxDataAtual.TabStop = false;
            this.groupBoxDataAtual.Text = "Data de hoje ";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(8, 41);
            this.labelData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(0, 21);
            this.labelData.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelCalendario);
            this.groupBox4.Controls.Add(this.monthCalendar);
            this.groupBox4.Location = new System.Drawing.Point(18, 219);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(295, 310);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "MonthCalendar";
            // 
            // labelCalendario
            // 
            this.labelCalendario.AutoSize = true;
            this.labelCalendario.Location = new System.Drawing.Point(8, 280);
            this.labelCalendario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCalendario.Name = "labelCalendario";
            this.labelCalendario.Size = new System.Drawing.Size(0, 21);
            this.labelCalendario.TabIndex = 1;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(8, 41);
            this.monthCalendar.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelComboBox2);
            this.groupBox3.Controls.Add(this.labelComboBox);
            this.groupBox3.Controls.Add(this.comboBoxBairros);
            this.groupBox3.Controls.Add(this.comboBoxNomes);
            this.groupBox3.Location = new System.Drawing.Point(477, 44);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(196, 227);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ComboBox";
            // 
            // labelComboBox2
            // 
            this.labelComboBox2.AutoSize = true;
            this.labelComboBox2.Location = new System.Drawing.Point(8, 185);
            this.labelComboBox2.Name = "labelComboBox2";
            this.labelComboBox2.Size = new System.Drawing.Size(0, 21);
            this.labelComboBox2.TabIndex = 3;
            this.labelComboBox2.Click += new System.EventHandler(this.labelComboBox2_Click);
            // 
            // labelComboBox
            // 
            this.labelComboBox.AutoSize = true;
            this.labelComboBox.Location = new System.Drawing.Point(8, 134);
            this.labelComboBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelComboBox.Name = "labelComboBox";
            this.labelComboBox.Size = new System.Drawing.Size(0, 21);
            this.labelComboBox.TabIndex = 2;
            // 
            // comboBoxBairros
            // 
            this.comboBoxBairros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBairros.FormattingEnabled = true;
            this.comboBoxBairros.Items.AddRange(new object[] {
            "Alexandre Balbo II",
            "Jardim Sampaio",
            "Campos Elísios ",
            "Jardim Paulista "});
            this.comboBoxBairros.Location = new System.Drawing.Point(8, 90);
            this.comboBoxBairros.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxBairros.Name = "comboBoxBairros";
            this.comboBoxBairros.Size = new System.Drawing.Size(154, 29);
            this.comboBoxBairros.TabIndex = 1;
            this.comboBoxBairros.SelectedIndexChanged += new System.EventHandler(this.comboBoxBairros_SelectedIndexChanged);
            // 
            // comboBoxNomes
            // 
            this.comboBoxNomes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNomes.FormattingEnabled = true;
            this.comboBoxNomes.Items.AddRange(new object[] {
            "Ana Maria",
            "Beto",
            "Carlos ",
            "Felipe",
            "Guilherme"});
            this.comboBoxNomes.Location = new System.Drawing.Point(8, 41);
            this.comboBoxNomes.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxNomes.Name = "comboBoxNomes";
            this.comboBoxNomes.Size = new System.Drawing.Size(154, 29);
            this.comboBoxNomes.TabIndex = 0;
            this.comboBoxNomes.SelectedIndexChanged += new System.EventHandler(this.comboBoxNomes_SelectedIndexChanged);
            // 
            // groupBoxCheckBox
            // 
            this.groupBoxCheckBox.Controls.Add(this.labelCheckBox);
            this.groupBoxCheckBox.Controls.Add(this.checkBoxFemi);
            this.groupBoxCheckBox.Controls.Add(this.checkBoxMascu);
            this.groupBoxCheckBox.Location = new System.Drawing.Point(247, 44);
            this.groupBoxCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxCheckBox.Name = "groupBoxCheckBox";
            this.groupBoxCheckBox.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxCheckBox.Size = new System.Drawing.Size(196, 160);
            this.groupBoxCheckBox.TabIndex = 9;
            this.groupBoxCheckBox.TabStop = false;
            this.groupBoxCheckBox.Text = "CheckBox";
            // 
            // labelCheckBox
            // 
            this.labelCheckBox.AutoSize = true;
            this.labelCheckBox.Location = new System.Drawing.Point(8, 122);
            this.labelCheckBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCheckBox.Name = "labelCheckBox";
            this.labelCheckBox.Size = new System.Drawing.Size(0, 21);
            this.labelCheckBox.TabIndex = 2;
            // 
            // checkBoxFemi
            // 
            this.checkBoxFemi.AutoSize = true;
            this.checkBoxFemi.Location = new System.Drawing.Point(8, 84);
            this.checkBoxFemi.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxFemi.Name = "checkBoxFemi";
            this.checkBoxFemi.Size = new System.Drawing.Size(94, 25);
            this.checkBoxFemi.TabIndex = 1;
            this.checkBoxFemi.Text = "Feminino";
            this.checkBoxFemi.UseVisualStyleBackColor = true;
            this.checkBoxFemi.CheckedChanged += new System.EventHandler(this.checkBoxFemi_CheckedChanged);
            // 
            // checkBoxMascu
            // 
            this.checkBoxMascu.AutoSize = true;
            this.checkBoxMascu.Location = new System.Drawing.Point(8, 41);
            this.checkBoxMascu.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxMascu.Name = "checkBoxMascu";
            this.checkBoxMascu.Size = new System.Drawing.Size(100, 25);
            this.checkBoxMascu.TabIndex = 0;
            this.checkBoxMascu.Text = "Masculino";
            this.checkBoxMascu.UseVisualStyleBackColor = true;
            this.checkBoxMascu.CheckedChanged += new System.EventHandler(this.checkBoxMascu_CheckedChanged);
            // 
            // groupBoxRadioButton
            // 
            this.groupBoxRadioButton.Controls.Add(this.labelRadioButton);
            this.groupBoxRadioButton.Controls.Add(this.radioButtonCorPreta);
            this.groupBoxRadioButton.Controls.Add(this.radioButtonCorBranca);
            this.groupBoxRadioButton.Location = new System.Drawing.Point(18, 44);
            this.groupBoxRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxRadioButton.Name = "groupBoxRadioButton";
            this.groupBoxRadioButton.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxRadioButton.Size = new System.Drawing.Size(196, 160);
            this.groupBoxRadioButton.TabIndex = 8;
            this.groupBoxRadioButton.TabStop = false;
            this.groupBoxRadioButton.Text = "RadioButton";
            // 
            // labelRadioButton
            // 
            this.labelRadioButton.AutoSize = true;
            this.labelRadioButton.Location = new System.Drawing.Point(8, 122);
            this.labelRadioButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRadioButton.Name = "labelRadioButton";
            this.labelRadioButton.Size = new System.Drawing.Size(0, 21);
            this.labelRadioButton.TabIndex = 2;
            // 
            // radioButtonCorPreta
            // 
            this.radioButtonCorPreta.AutoSize = true;
            this.radioButtonCorPreta.Location = new System.Drawing.Point(8, 83);
            this.radioButtonCorPreta.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonCorPreta.Name = "radioButtonCorPreta";
            this.radioButtonCorPreta.Size = new System.Drawing.Size(65, 25);
            this.radioButtonCorPreta.TabIndex = 1;
            this.radioButtonCorPreta.TabStop = true;
            this.radioButtonCorPreta.Text = "Preto";
            this.radioButtonCorPreta.UseVisualStyleBackColor = true;
            this.radioButtonCorPreta.CheckedChanged += new System.EventHandler(this.radioButtonCorPreta_CheckedChanged);
            // 
            // radioButtonCorBranca
            // 
            this.radioButtonCorBranca.AutoSize = true;
            this.radioButtonCorBranca.Location = new System.Drawing.Point(8, 39);
            this.radioButtonCorBranca.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonCorBranca.Name = "radioButtonCorBranca";
            this.radioButtonCorBranca.Size = new System.Drawing.Size(76, 25);
            this.radioButtonCorBranca.TabIndex = 0;
            this.radioButtonCorBranca.TabStop = true;
            this.radioButtonCorBranca.Text = "Branco";
            this.radioButtonCorBranca.UseVisualStyleBackColor = true;
            this.radioButtonCorBranca.CheckedChanged += new System.EventHandler(this.radioButtonCorBranca_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ferramentas";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelDia,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabelHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 608);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(696, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabel1.Text = "Hoje é:";
            // 
            // toolStripStatusLabelDia
            // 
            this.toolStripStatusLabelDia.Name = "toolStripStatusLabelDia";
            this.toolStripStatusLabelDia.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusLabelDia.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(52, 17);
            this.toolStripStatusLabel3.Text = " |   E são:";
            // 
            // toolStripStatusLabelHora
            // 
            this.toolStripStatusLabelHora.Name = "toolStripStatusLabelHora";
            this.toolStripStatusLabelHora.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 630);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBoxDataAtual);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxCheckBox);
            this.Controls.Add(this.groupBoxRadioButton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projeto Ferramentas";
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBoxDataAtual.ResumeLayout(false);
            this.groupBoxDataAtual.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxCheckBox.ResumeLayout(false);
            this.groupBoxCheckBox.PerformLayout();
            this.groupBoxRadioButton.ResumeLayout(false);
            this.groupBoxRadioButton.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox6;
        private Label labelHora;
        private GroupBox groupBoxDataAtual;
        private Label labelData;
        private GroupBox groupBox4;
        private Label labelCalendario;
        private MonthCalendar monthCalendar;
        private GroupBox groupBox3;
        private Label labelComboBox;
        private ComboBox comboBoxBairros;
        private ComboBox comboBoxNomes;
        private GroupBox groupBoxCheckBox;
        private Label labelCheckBox;
        private CheckBox checkBoxFemi;
        private CheckBox checkBoxMascu;
        private GroupBox groupBoxRadioButton;
        private Label labelRadioButton;
        private RadioButton radioButtonCorPreta;
        private RadioButton radioButtonCorBranca;
        private Label label1;
        private Label labelComboBox2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabelDia;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabelHora;
        private System.Windows.Forms.Timer timer1;
    }
}