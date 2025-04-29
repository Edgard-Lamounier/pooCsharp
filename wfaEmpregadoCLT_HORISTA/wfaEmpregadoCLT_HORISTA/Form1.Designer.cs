namespace wfaEmpregadoCLT_HORISTA
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
            this.rbCLT = new System.Windows.Forms.RadioButton();
            this.rbHorista = new System.Windows.Forms.RadioButton();
            this.lbPrimeiroNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.lbCpf = new System.Windows.Forms.Label();
            this.tbPrimeiroNome = new System.Windows.Forms.TextBox();
            this.tbSegundoNome = new System.Windows.Forms.TextBox();
            this.lbSalarioMensal = new System.Windows.Forms.Label();
            this.tbSalarioMensal = new System.Windows.Forms.TextBox();
            this.lbNroHoras = new System.Windows.Forms.Label();
            this.tbNroHoras = new System.Windows.Forms.TextBox();
            this.lbPrecoHora = new System.Windows.Forms.Label();
            this.tbPrecoHora = new System.Windows.Forms.TextBox();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbCLT
            // 
            this.rbCLT.AutoSize = true;
            this.rbCLT.Location = new System.Drawing.Point(45, 40);
            this.rbCLT.Name = "rbCLT";
            this.rbCLT.Size = new System.Drawing.Size(131, 20);
            this.rbCLT.TabIndex = 0;
            this.rbCLT.TabStop = true;
            this.rbCLT.Text = "Empregado CLT ";
            this.rbCLT.UseVisualStyleBackColor = true;
            this.rbCLT.CheckedChanged += new System.EventHandler(this.rbCLT_CheckedChanged);
            // 
            // rbHorista
            // 
            this.rbHorista.AutoSize = true;
            this.rbHorista.Location = new System.Drawing.Point(244, 40);
            this.rbHorista.Name = "rbHorista";
            this.rbHorista.Size = new System.Drawing.Size(163, 20);
            this.rbHorista.TabIndex = 1;
            this.rbHorista.TabStop = true;
            this.rbHorista.Text = "Empregado HORISTA";
            this.rbHorista.UseVisualStyleBackColor = true;
            this.rbHorista.CheckedChanged += new System.EventHandler(this.rbHorista_CheckedChanged);
            // 
            // lbPrimeiroNome
            // 
            this.lbPrimeiroNome.AutoSize = true;
            this.lbPrimeiroNome.Location = new System.Drawing.Point(58, 100);
            this.lbPrimeiroNome.Name = "lbPrimeiroNome";
            this.lbPrimeiroNome.Size = new System.Drawing.Size(100, 16);
            this.lbPrimeiroNome.TabIndex = 2;
            this.lbPrimeiroNome.Text = "Primeiro Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Segundo Nome:";
            // 
            // mtbCPF
            // 
            this.mtbCPF.Location = new System.Drawing.Point(196, 191);
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(335, 22);
            this.mtbCPF.TabIndex = 4;
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Location = new System.Drawing.Point(111, 194);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(36, 16);
            this.lbCpf.TabIndex = 5;
            this.lbCpf.Text = "CPF:";
            // 
            // tbPrimeiroNome
            // 
            this.tbPrimeiroNome.Location = new System.Drawing.Point(196, 97);
            this.tbPrimeiroNome.Name = "tbPrimeiroNome";
            this.tbPrimeiroNome.Size = new System.Drawing.Size(338, 22);
            this.tbPrimeiroNome.TabIndex = 6;
            // 
            // tbSegundoNome
            // 
            this.tbSegundoNome.Location = new System.Drawing.Point(196, 149);
            this.tbSegundoNome.Name = "tbSegundoNome";
            this.tbSegundoNome.Size = new System.Drawing.Size(337, 22);
            this.tbSegundoNome.TabIndex = 7;
            // 
            // lbSalarioMensal
            // 
            this.lbSalarioMensal.AutoSize = true;
            this.lbSalarioMensal.Location = new System.Drawing.Point(58, 243);
            this.lbSalarioMensal.Name = "lbSalarioMensal";
            this.lbSalarioMensal.Size = new System.Drawing.Size(100, 16);
            this.lbSalarioMensal.TabIndex = 8;
            this.lbSalarioMensal.Text = "Salario Mensal:";
            // 
            // tbSalarioMensal
            // 
            this.tbSalarioMensal.Location = new System.Drawing.Point(196, 240);
            this.tbSalarioMensal.Name = "tbSalarioMensal";
            this.tbSalarioMensal.Size = new System.Drawing.Size(338, 22);
            this.tbSalarioMensal.TabIndex = 9;
            // 
            // lbNroHoras
            // 
            this.lbNroHoras.AutoSize = true;
            this.lbNroHoras.Location = new System.Drawing.Point(77, 300);
            this.lbNroHoras.Name = "lbNroHoras";
            this.lbNroHoras.Size = new System.Drawing.Size(72, 16);
            this.lbNroHoras.TabIndex = 10;
            this.lbNroHoras.Text = "Nro Horas:";
            // 
            // tbNroHoras
            // 
            this.tbNroHoras.Location = new System.Drawing.Point(196, 300);
            this.tbNroHoras.Name = "tbNroHoras";
            this.tbNroHoras.Size = new System.Drawing.Size(335, 22);
            this.tbNroHoras.TabIndex = 11;
            // 
            // lbPrecoHora
            // 
            this.lbPrecoHora.AutoSize = true;
            this.lbPrecoHora.Location = new System.Drawing.Point(76, 363);
            this.lbPrecoHora.Name = "lbPrecoHora";
            this.lbPrecoHora.Size = new System.Drawing.Size(82, 16);
            this.lbPrecoHora.TabIndex = 12;
            this.lbPrecoHora.Text = "Preço Hora: ";
            // 
            // tbPrecoHora
            // 
            this.tbPrecoHora.Location = new System.Drawing.Point(196, 363);
            this.tbPrecoHora.Name = "tbPrecoHora";
            this.tbPrecoHora.Size = new System.Drawing.Size(338, 22);
            this.tbPrecoHora.TabIndex = 13;
            this.tbPrecoHora.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(196, 438);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(127, 51);
            this.btCadastrar.TabIndex = 14;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 527);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.tbPrecoHora);
            this.Controls.Add(this.lbPrecoHora);
            this.Controls.Add(this.tbNroHoras);
            this.Controls.Add(this.lbNroHoras);
            this.Controls.Add(this.tbSalarioMensal);
            this.Controls.Add(this.lbSalarioMensal);
            this.Controls.Add(this.tbSegundoNome);
            this.Controls.Add(this.tbPrimeiroNome);
            this.Controls.Add(this.lbCpf);
            this.Controls.Add(this.mtbCPF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPrimeiroNome);
            this.Controls.Add(this.rbHorista);
            this.Controls.Add(this.rbCLT);
            this.Name = "Form1";
            this.Text = "Cadastro de Empregados";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbCLT;
        private System.Windows.Forms.RadioButton rbHorista;
        private System.Windows.Forms.Label lbPrimeiroNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.TextBox tbPrimeiroNome;
        private System.Windows.Forms.TextBox tbSegundoNome;
        private System.Windows.Forms.Label lbSalarioMensal;
        private System.Windows.Forms.TextBox tbSalarioMensal;
        private System.Windows.Forms.Label lbNroHoras;
        private System.Windows.Forms.TextBox tbNroHoras;
        private System.Windows.Forms.Label lbPrecoHora;
        private System.Windows.Forms.TextBox tbPrecoHora;
        private System.Windows.Forms.Button btCadastrar;
    }
}

