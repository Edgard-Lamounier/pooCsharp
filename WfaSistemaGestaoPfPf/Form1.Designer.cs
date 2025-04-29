namespace WfaSistemaGestaoPfPf
{
    partial class Form1
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
            this.rbPf = new System.Windows.Forms.RadioButton();
            this.rbPj = new System.Windows.Forms.RadioButton();
            this.lblCpfCnpj = new System.Windows.Forms.Label();
            this.mtbCpfCnpj = new System.Windows.Forms.MaskedTextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.tbQtdFilhosFuncionarios = new System.Windows.Forms.TextBox();
            this.lblQtdFilhosFuncionarios = new System.Windows.Forms.Label();
            this.tbSalarioFaturamento = new System.Windows.Forms.TextBox();
            this.lblSalarioFaturamento = new System.Windows.Forms.Label();
            this.tbNomeFantasia = new System.Windows.Forms.TextBox();
            this.lblNomeFantasia = new System.Windows.Forms.Label();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.lvPf = new System.Windows.Forms.ListView();
            this.lvPj = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // rbPf
            // 
            this.rbPf.AutoSize = true;
            this.rbPf.Location = new System.Drawing.Point(51, 12);
            this.rbPf.Name = "rbPf";
            this.rbPf.Size = new System.Drawing.Size(155, 29);
            this.rbPf.TabIndex = 0;
            this.rbPf.TabStop = true;
            this.rbPf.Text = "Pessoa Fisica";
            this.rbPf.UseVisualStyleBackColor = true;
            this.rbPf.CheckedChanged += new System.EventHandler(this.rbPf_CheckedChanged);
            // 
            // rbPj
            // 
            this.rbPj.AutoSize = true;
            this.rbPj.Location = new System.Drawing.Point(247, 12);
            this.rbPj.Name = "rbPj";
            this.rbPj.Size = new System.Drawing.Size(172, 29);
            this.rbPj.TabIndex = 1;
            this.rbPj.TabStop = true;
            this.rbPj.Text = "Pessoa Juridica";
            this.rbPj.UseVisualStyleBackColor = true;
            this.rbPj.CheckedChanged += new System.EventHandler(this.rbPj_CheckedChanged);
            // 
            // lblCpfCnpj
            // 
            this.lblCpfCnpj.Location = new System.Drawing.Point(20, 56);
            this.lblCpfCnpj.Name = "lblCpfCnpj";
            this.lblCpfCnpj.Size = new System.Drawing.Size(184, 30);
            this.lblCpfCnpj.TabIndex = 2;
            this.lblCpfCnpj.Text = "CPF";
            this.lblCpfCnpj.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // mtbCpfCnpj
            // 
            this.mtbCpfCnpj.Location = new System.Drawing.Point(219, 57);
            this.mtbCpfCnpj.Name = "mtbCpfCnpj";
            this.mtbCpfCnpj.Size = new System.Drawing.Size(703, 30);
            this.mtbCpfCnpj.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.Location = new System.Drawing.Point(20, 117);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(184, 30);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(219, 117);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(703, 30);
            this.tbNome.TabIndex = 5;
            // 
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(219, 174);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(703, 30);
            this.tbCidade.TabIndex = 7;
            // 
            // lblCidade
            // 
            this.lblCidade.Location = new System.Drawing.Point(15, 174);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(189, 30);
            this.lblCidade.TabIndex = 6;
            this.lblCidade.Text = "Cidade";
            this.lblCidade.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbQtdFilhosFuncionarios
            // 
            this.tbQtdFilhosFuncionarios.Location = new System.Drawing.Point(219, 231);
            this.tbQtdFilhosFuncionarios.Name = "tbQtdFilhosFuncionarios";
            this.tbQtdFilhosFuncionarios.Size = new System.Drawing.Size(703, 30);
            this.tbQtdFilhosFuncionarios.TabIndex = 9;
            this.tbQtdFilhosFuncionarios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQtdFilhosFuncionarios_KeyPress);
            // 
            // lblQtdFilhosFuncionarios
            // 
            this.lblQtdFilhosFuncionarios.Location = new System.Drawing.Point(15, 231);
            this.lblQtdFilhosFuncionarios.Name = "lblQtdFilhosFuncionarios";
            this.lblQtdFilhosFuncionarios.Size = new System.Drawing.Size(189, 30);
            this.lblQtdFilhosFuncionarios.TabIndex = 8;
            this.lblQtdFilhosFuncionarios.Text = "Qtd Filhos";
            this.lblQtdFilhosFuncionarios.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbSalarioFaturamento
            // 
            this.tbSalarioFaturamento.Location = new System.Drawing.Point(219, 293);
            this.tbSalarioFaturamento.Name = "tbSalarioFaturamento";
            this.tbSalarioFaturamento.Size = new System.Drawing.Size(703, 30);
            this.tbSalarioFaturamento.TabIndex = 11;
            this.tbSalarioFaturamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSalarioFaturamento_KeyPress);
            // 
            // lblSalarioFaturamento
            // 
            this.lblSalarioFaturamento.Location = new System.Drawing.Point(15, 293);
            this.lblSalarioFaturamento.Name = "lblSalarioFaturamento";
            this.lblSalarioFaturamento.Size = new System.Drawing.Size(189, 30);
            this.lblSalarioFaturamento.TabIndex = 10;
            this.lblSalarioFaturamento.Text = "Salario";
            this.lblSalarioFaturamento.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbNomeFantasia
            // 
            this.tbNomeFantasia.Location = new System.Drawing.Point(219, 351);
            this.tbNomeFantasia.Name = "tbNomeFantasia";
            this.tbNomeFantasia.Size = new System.Drawing.Size(703, 30);
            this.tbNomeFantasia.TabIndex = 13;
            // 
            // lblNomeFantasia
            // 
            this.lblNomeFantasia.Location = new System.Drawing.Point(15, 351);
            this.lblNomeFantasia.Name = "lblNomeFantasia";
            this.lblNomeFantasia.Size = new System.Drawing.Size(184, 30);
            this.lblNomeFantasia.TabIndex = 12;
            this.lblNomeFantasia.Text = "Nome Fantasia";
            this.lblNomeFantasia.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(390, 402);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(121, 41);
            this.btCadastrar.TabIndex = 14;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(542, 402);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(121, 41);
            this.btLimpar.TabIndex = 15;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // lvPf
            // 
            this.lvPf.HideSelection = false;
            this.lvPf.Location = new System.Drawing.Point(20, 468);
            this.lvPf.Name = "lvPf";
            this.lvPf.Size = new System.Drawing.Size(927, 97);
            this.lvPf.TabIndex = 16;
            this.lvPf.UseCompatibleStateImageBehavior = false;
            // 
            // lvPj
            // 
            this.lvPj.HideSelection = false;
            this.lvPj.Location = new System.Drawing.Point(20, 589);
            this.lvPj.Name = "lvPj";
            this.lvPj.Size = new System.Drawing.Size(927, 97);
            this.lvPj.TabIndex = 17;
            this.lvPj.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 731);
            this.Controls.Add(this.lvPj);
            this.Controls.Add(this.lvPf);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.tbNomeFantasia);
            this.Controls.Add(this.lblNomeFantasia);
            this.Controls.Add(this.tbSalarioFaturamento);
            this.Controls.Add(this.lblSalarioFaturamento);
            this.Controls.Add(this.tbQtdFilhosFuncionarios);
            this.Controls.Add(this.lblQtdFilhosFuncionarios);
            this.Controls.Add(this.tbCidade);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.mtbCpfCnpj);
            this.Controls.Add(this.lblCpfCnpj);
            this.Controls.Add(this.rbPj);
            this.Controls.Add(this.rbPf);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Sistema de Gestão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbPf;
        private System.Windows.Forms.RadioButton rbPj;
        private System.Windows.Forms.Label lblCpfCnpj;
        private System.Windows.Forms.MaskedTextBox mtbCpfCnpj;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox tbQtdFilhosFuncionarios;
        private System.Windows.Forms.Label lblQtdFilhosFuncionarios;
        private System.Windows.Forms.TextBox tbSalarioFaturamento;
        private System.Windows.Forms.Label lblSalarioFaturamento;
        private System.Windows.Forms.TextBox tbNomeFantasia;
        private System.Windows.Forms.Label lblNomeFantasia;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.ListView lvPf;
        private System.Windows.Forms.ListView lvPj;
    }
}

