namespace wfaPessoaFisica_Juridica
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCPFCNPJ = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonPFisica = new System.Windows.Forms.RadioButton();
            this.radioButtonPJuridica = new System.Windows.Forms.RadioButton();
            this.maskedTextBoxCPFCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelCPFCNPJ
            // 
            this.labelCPFCNPJ.AutoSize = true;
            this.labelCPFCNPJ.Location = new System.Drawing.Point(177, 115);
            this.labelCPFCNPJ.Name = "labelCPFCNPJ";
            this.labelCPFCNPJ.Size = new System.Drawing.Size(60, 25);
            this.labelCPFCNPJ.TabIndex = 0;
            this.labelCPFCNPJ.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // radioButtonPFisica
            // 
            this.radioButtonPFisica.AutoSize = true;
            this.radioButtonPFisica.Location = new System.Drawing.Point(63, 31);
            this.radioButtonPFisica.Name = "radioButtonPFisica";
            this.radioButtonPFisica.Size = new System.Drawing.Size(178, 29);
            this.radioButtonPFisica.TabIndex = 2;
            this.radioButtonPFisica.TabStop = true;
            this.radioButtonPFisica.Text = "Pessoa Física";
            this.radioButtonPFisica.UseVisualStyleBackColor = true;
            this.radioButtonPFisica.CheckedChanged += new System.EventHandler(this.radioButtonPFisica_CheckedChanged);
            // 
            // radioButtonPJuridica
            // 
            this.radioButtonPJuridica.AutoSize = true;
            this.radioButtonPJuridica.Location = new System.Drawing.Point(379, 31);
            this.radioButtonPJuridica.Name = "radioButtonPJuridica";
            this.radioButtonPJuridica.Size = new System.Drawing.Size(196, 29);
            this.radioButtonPJuridica.TabIndex = 3;
            this.radioButtonPJuridica.TabStop = true;
            this.radioButtonPJuridica.Text = "Pessoa Jurídica";
            this.radioButtonPJuridica.UseVisualStyleBackColor = true;
            this.radioButtonPJuridica.CheckedChanged += new System.EventHandler(this.radioButtonPJuridica_CheckedChanged);
            // 
            // maskedTextBoxCPFCNPJ
            // 
            this.maskedTextBoxCPFCNPJ.Location = new System.Drawing.Point(270, 115);
            this.maskedTextBoxCPFCNPJ.Name = "maskedTextBoxCPFCNPJ";
            this.maskedTextBoxCPFCNPJ.Size = new System.Drawing.Size(744, 31);
            this.maskedTextBoxCPFCNPJ.TabIndex = 4;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(270, 193);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(744, 31);
            this.textBoxNome.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Qtd Filhos:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(270, 284);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(755, 31);
            this.textBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 757);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.maskedTextBoxCPFCNPJ);
            this.Controls.Add(this.radioButtonPJuridica);
            this.Controls.Add(this.radioButtonPFisica);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCPFCNPJ);
            this.Name = "Form1";
            this.Text = "CADASTRO - PESSOA FÍSICA & JURÍDICA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCPFCNPJ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonPFisica;
        private System.Windows.Forms.RadioButton radioButtonPJuridica;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCPFCNPJ;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

