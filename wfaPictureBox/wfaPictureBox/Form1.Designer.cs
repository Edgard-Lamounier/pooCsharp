namespace wfaPictureBox
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
            this.picBoxImagens = new System.Windows.Forms.PictureBox();
            this.rbCirculo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImagens)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxImagens
            // 
            this.picBoxImagens.Image = global::wfaPictureBox.Properties.Resources.branco;
            this.picBoxImagens.Location = new System.Drawing.Point(60, 44);
            this.picBoxImagens.Name = "picBoxImagens";
            this.picBoxImagens.Size = new System.Drawing.Size(511, 525);
            this.picBoxImagens.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxImagens.TabIndex = 0;
            this.picBoxImagens.TabStop = false;
            // 
            // rbCirculo
            // 
            this.rbCirculo.AutoSize = true;
            this.rbCirculo.Location = new System.Drawing.Point(644, 102);
            this.rbCirculo.Name = "rbCirculo";
            this.rbCirculo.Size = new System.Drawing.Size(110, 29);
            this.rbCirculo.TabIndex = 1;
            this.rbCirculo.Text = "Circulo";
            this.rbCirculo.UseVisualStyleBackColor = true;
            this.rbCirculo.CheckedChanged += new System.EventHandler(this.rbCirculo_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 592);
            this.Controls.Add(this.rbCirculo);
            this.Controls.Add(this.picBoxImagens);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImagens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxImagens;
        private System.Windows.Forms.RadioButton rbCirculo;
    }
}

