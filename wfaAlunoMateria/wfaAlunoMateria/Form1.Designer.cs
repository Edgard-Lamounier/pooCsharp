namespace wfaAlunoMateria
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonGRAVAR_ALUNO = new System.Windows.Forms.Button();
            this.textBoxPeriodo = new System.Windows.Forms.TextBox();
            this.textBoxNroMatricula = new System.Windows.Forms.TextBox();
            this.textBoxNome_Aluno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.rtbREL = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(49, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(689, 344);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.buttonGRAVAR_ALUNO);
            this.tabPage1.Controls.Add(this.textBoxPeriodo);
            this.tabPage1.Controls.Add(this.textBoxNroMatricula);
            this.tabPage1.Controls.Add(this.textBoxNome_Aluno);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(681, 315);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ALUNO";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // buttonGRAVAR_ALUNO
            // 
            this.buttonGRAVAR_ALUNO.Location = new System.Drawing.Point(461, 159);
            this.buttonGRAVAR_ALUNO.Name = "buttonGRAVAR_ALUNO";
            this.buttonGRAVAR_ALUNO.Size = new System.Drawing.Size(113, 61);
            this.buttonGRAVAR_ALUNO.TabIndex = 6;
            this.buttonGRAVAR_ALUNO.Text = "GRAVAR";
            this.buttonGRAVAR_ALUNO.UseVisualStyleBackColor = true;
            this.buttonGRAVAR_ALUNO.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonGRAVAR_ALUNO_MouseClick);
            // 
            // textBoxPeriodo
            // 
            this.textBoxPeriodo.Location = new System.Drawing.Point(135, 198);
            this.textBoxPeriodo.Name = "textBoxPeriodo";
            this.textBoxPeriodo.Size = new System.Drawing.Size(245, 22);
            this.textBoxPeriodo.TabIndex = 5;
            // 
            // textBoxNroMatricula
            // 
            this.textBoxNroMatricula.Location = new System.Drawing.Point(162, 123);
            this.textBoxNroMatricula.Name = "textBoxNroMatricula";
            this.textBoxNroMatricula.Size = new System.Drawing.Size(213, 22);
            this.textBoxNroMatricula.TabIndex = 4;
            // 
            // textBoxNome_Aluno
            // 
            this.textBoxNome_Aluno.Location = new System.Drawing.Point(135, 58);
            this.textBoxNome_Aluno.Name = "textBoxNome_Aluno";
            this.textBoxNome_Aluno.Size = new System.Drawing.Size(240, 22);
            this.textBoxNome_Aluno.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Período:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nro. Matricula:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.MistyRose;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(681, 315);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MATÉRIA";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(681, 315);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "MATRÍCULA";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.rtbREL);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(681, 315);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "RELATÓRIO";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(550, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtbREL
            // 
            this.rtbREL.Location = new System.Drawing.Point(34, 45);
            this.rtbREL.Name = "rtbREL";
            this.rtbREL.Size = new System.Drawing.Size(498, 231);
            this.rtbREL.TabIndex = 1;
            this.rtbREL.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Cadastro de Alunos e Matérias";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button buttonGRAVAR_ALUNO;
        private System.Windows.Forms.TextBox textBoxPeriodo;
        private System.Windows.Forms.TextBox textBoxNroMatricula;
        private System.Windows.Forms.TextBox textBoxNome_Aluno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtbREL;
    }
}

