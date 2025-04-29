
namespace WfaCalAreaPerimetro
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
            this.pbImagens = new System.Windows.Forms.PictureBox();
            this.rbQuadrado = new System.Windows.Forms.RadioButton();
            this.lblLadoQuadrado = new System.Windows.Forms.Label();
            this.tbLadoQuadrado = new System.Windows.Forms.TextBox();
            this.btArea = new System.Windows.Forms.Button();
            this.rbRetangulo = new System.Windows.Forms.RadioButton();
            this.rbTriangulo = new System.Windows.Forms.RadioButton();
            this.rbCirculo = new System.Windows.Forms.RadioButton();
            this.tbBaseRetangulo = new System.Windows.Forms.TextBox();
            this.lblBaseRetangulo = new System.Windows.Forms.Label();
            this.tbAlturaRetangulo = new System.Windows.Forms.TextBox();
            this.lblAlturaRetangulo = new System.Windows.Forms.Label();
            this.tbAlturaTriangulo = new System.Windows.Forms.TextBox();
            this.lblAlturaTriangulo = new System.Windows.Forms.Label();
            this.tbBaseTriangulo = new System.Windows.Forms.TextBox();
            this.lblBaseTriangulo = new System.Windows.Forms.Label();
            this.tbRaio = new System.Windows.Forms.TextBox();
            this.lblRaio = new System.Windows.Forms.Label();
            this.pnlQuadrado = new System.Windows.Forms.Panel();
            this.pnlRetangulo = new System.Windows.Forms.Panel();
            this.pnlTriangulo = new System.Windows.Forms.Panel();
            this.pnlCirculo = new System.Windows.Forms.Panel();
            this.listViewArea = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagens)).BeginInit();
            this.pnlQuadrado.SuspendLayout();
            this.pnlRetangulo.SuspendLayout();
            this.pnlTriangulo.SuspendLayout();
            this.pnlCirculo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbImagens
            // 
            this.pbImagens.Location = new System.Drawing.Point(25, 21);
            this.pbImagens.Name = "pbImagens";
            this.pbImagens.Size = new System.Drawing.Size(355, 278);
            this.pbImagens.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagens.TabIndex = 0;
            this.pbImagens.TabStop = false;
            // 
            // rbQuadrado
            // 
            this.rbQuadrado.AutoSize = true;
            this.rbQuadrado.Location = new System.Drawing.Point(437, 35);
            this.rbQuadrado.Name = "rbQuadrado";
            this.rbQuadrado.Size = new System.Drawing.Size(89, 20);
            this.rbQuadrado.TabIndex = 5;
            this.rbQuadrado.TabStop = true;
            this.rbQuadrado.Text = "Quadrado";
            this.rbQuadrado.UseVisualStyleBackColor = true;
            this.rbQuadrado.CheckedChanged += new System.EventHandler(this.rbQuadrado_CheckedChanged);
            // 
            // lblLadoQuadrado
            // 
            this.lblLadoQuadrado.AutoSize = true;
            this.lblLadoQuadrado.Location = new System.Drawing.Point(20, 26);
            this.lblLadoQuadrado.Name = "lblLadoQuadrado";
            this.lblLadoQuadrado.Size = new System.Drawing.Size(38, 16);
            this.lblLadoQuadrado.TabIndex = 2;
            this.lblLadoQuadrado.Text = "Lado";
            // 
            // tbLadoQuadrado
            // 
            this.tbLadoQuadrado.Location = new System.Drawing.Point(81, 26);
            this.tbLadoQuadrado.Name = "tbLadoQuadrado";
            this.tbLadoQuadrado.Size = new System.Drawing.Size(248, 22);
            this.tbLadoQuadrado.TabIndex = 3;
            // 
            // btArea
            // 
            this.btArea.Location = new System.Drawing.Point(437, 326);
            this.btArea.Name = "btArea";
            this.btArea.Size = new System.Drawing.Size(75, 32);
            this.btArea.TabIndex = 1;
            this.btArea.Text = "Area";
            this.btArea.UseVisualStyleBackColor = true;
            this.btArea.Click += new System.EventHandler(this.btArea_Click);
            // 
            // rbRetangulo
            // 
            this.rbRetangulo.AutoSize = true;
            this.rbRetangulo.Location = new System.Drawing.Point(437, 97);
            this.rbRetangulo.Name = "rbRetangulo";
            this.rbRetangulo.Size = new System.Drawing.Size(90, 20);
            this.rbRetangulo.TabIndex = 6;
            this.rbRetangulo.TabStop = true;
            this.rbRetangulo.Text = "Retangulo";
            this.rbRetangulo.UseVisualStyleBackColor = true;
            this.rbRetangulo.CheckedChanged += new System.EventHandler(this.rbRetangulo_CheckedChanged);
            // 
            // rbTriangulo
            // 
            this.rbTriangulo.AutoSize = true;
            this.rbTriangulo.Location = new System.Drawing.Point(437, 159);
            this.rbTriangulo.Name = "rbTriangulo";
            this.rbTriangulo.Size = new System.Drawing.Size(85, 20);
            this.rbTriangulo.TabIndex = 7;
            this.rbTriangulo.TabStop = true;
            this.rbTriangulo.Text = "Triangulo";
            this.rbTriangulo.UseVisualStyleBackColor = true;
            this.rbTriangulo.CheckedChanged += new System.EventHandler(this.rbTriangulo_CheckedChanged);
            // 
            // rbCirculo
            // 
            this.rbCirculo.AutoSize = true;
            this.rbCirculo.Location = new System.Drawing.Point(437, 223);
            this.rbCirculo.Name = "rbCirculo";
            this.rbCirculo.Size = new System.Drawing.Size(69, 20);
            this.rbCirculo.TabIndex = 8;
            this.rbCirculo.TabStop = true;
            this.rbCirculo.Text = "Circulo";
            this.rbCirculo.UseVisualStyleBackColor = true;
            this.rbCirculo.CheckedChanged += new System.EventHandler(this.rbCirculo_CheckedChanged);
            // 
            // tbBaseRetangulo
            // 
            this.tbBaseRetangulo.Location = new System.Drawing.Point(81, 27);
            this.tbBaseRetangulo.Name = "tbBaseRetangulo";
            this.tbBaseRetangulo.Size = new System.Drawing.Size(248, 22);
            this.tbBaseRetangulo.TabIndex = 10;
            // 
            // lblBaseRetangulo
            // 
            this.lblBaseRetangulo.AutoSize = true;
            this.lblBaseRetangulo.Location = new System.Drawing.Point(20, 27);
            this.lblBaseRetangulo.Name = "lblBaseRetangulo";
            this.lblBaseRetangulo.Size = new System.Drawing.Size(39, 16);
            this.lblBaseRetangulo.TabIndex = 9;
            this.lblBaseRetangulo.Text = "Base";
            // 
            // tbAlturaRetangulo
            // 
            this.tbAlturaRetangulo.Location = new System.Drawing.Point(81, 79);
            this.tbAlturaRetangulo.Name = "tbAlturaRetangulo";
            this.tbAlturaRetangulo.Size = new System.Drawing.Size(248, 22);
            this.tbAlturaRetangulo.TabIndex = 12;
            // 
            // lblAlturaRetangulo
            // 
            this.lblAlturaRetangulo.AutoSize = true;
            this.lblAlturaRetangulo.Location = new System.Drawing.Point(20, 79);
            this.lblAlturaRetangulo.Name = "lblAlturaRetangulo";
            this.lblAlturaRetangulo.Size = new System.Drawing.Size(41, 16);
            this.lblAlturaRetangulo.TabIndex = 11;
            this.lblAlturaRetangulo.Text = "Altura";
            // 
            // tbAlturaTriangulo
            // 
            this.tbAlturaTriangulo.Location = new System.Drawing.Point(81, 73);
            this.tbAlturaTriangulo.Name = "tbAlturaTriangulo";
            this.tbAlturaTriangulo.Size = new System.Drawing.Size(248, 22);
            this.tbAlturaTriangulo.TabIndex = 16;
            // 
            // lblAlturaTriangulo
            // 
            this.lblAlturaTriangulo.AutoSize = true;
            this.lblAlturaTriangulo.Location = new System.Drawing.Point(20, 73);
            this.lblAlturaTriangulo.Name = "lblAlturaTriangulo";
            this.lblAlturaTriangulo.Size = new System.Drawing.Size(41, 16);
            this.lblAlturaTriangulo.TabIndex = 15;
            this.lblAlturaTriangulo.Text = "Altura";
            // 
            // tbBaseTriangulo
            // 
            this.tbBaseTriangulo.Location = new System.Drawing.Point(81, 21);
            this.tbBaseTriangulo.Name = "tbBaseTriangulo";
            this.tbBaseTriangulo.Size = new System.Drawing.Size(248, 22);
            this.tbBaseTriangulo.TabIndex = 14;
            // 
            // lblBaseTriangulo
            // 
            this.lblBaseTriangulo.AutoSize = true;
            this.lblBaseTriangulo.Location = new System.Drawing.Point(20, 21);
            this.lblBaseTriangulo.Name = "lblBaseTriangulo";
            this.lblBaseTriangulo.Size = new System.Drawing.Size(39, 16);
            this.lblBaseTriangulo.TabIndex = 13;
            this.lblBaseTriangulo.Text = "Base";
            // 
            // tbRaio
            // 
            this.tbRaio.Location = new System.Drawing.Point(66, 11);
            this.tbRaio.Name = "tbRaio";
            this.tbRaio.Size = new System.Drawing.Size(248, 22);
            this.tbRaio.TabIndex = 18;
            // 
            // lblRaio
            // 
            this.lblRaio.AutoSize = true;
            this.lblRaio.Location = new System.Drawing.Point(17, 17);
            this.lblRaio.Name = "lblRaio";
            this.lblRaio.Size = new System.Drawing.Size(36, 16);
            this.lblRaio.TabIndex = 17;
            this.lblRaio.Text = "Raio";
            // 
            // pnlQuadrado
            // 
            this.pnlQuadrado.Controls.Add(this.tbLadoQuadrado);
            this.pnlQuadrado.Controls.Add(this.lblLadoQuadrado);
            this.pnlQuadrado.Location = new System.Drawing.Point(28, 319);
            this.pnlQuadrado.Name = "pnlQuadrado";
            this.pnlQuadrado.Size = new System.Drawing.Size(345, 118);
            this.pnlQuadrado.TabIndex = 19;
            // 
            // pnlRetangulo
            // 
            this.pnlRetangulo.Controls.Add(this.tbBaseRetangulo);
            this.pnlRetangulo.Controls.Add(this.lblBaseRetangulo);
            this.pnlRetangulo.Controls.Add(this.lblAlturaRetangulo);
            this.pnlRetangulo.Controls.Add(this.tbAlturaRetangulo);
            this.pnlRetangulo.Location = new System.Drawing.Point(33, 319);
            this.pnlRetangulo.Name = "pnlRetangulo";
            this.pnlRetangulo.Size = new System.Drawing.Size(345, 118);
            this.pnlRetangulo.TabIndex = 20;
            // 
            // pnlTriangulo
            // 
            this.pnlTriangulo.Controls.Add(this.tbBaseTriangulo);
            this.pnlTriangulo.Controls.Add(this.lblBaseTriangulo);
            this.pnlTriangulo.Controls.Add(this.lblAlturaTriangulo);
            this.pnlTriangulo.Controls.Add(this.tbAlturaTriangulo);
            this.pnlTriangulo.Location = new System.Drawing.Point(28, 316);
            this.pnlTriangulo.Name = "pnlTriangulo";
            this.pnlTriangulo.Size = new System.Drawing.Size(352, 118);
            this.pnlTriangulo.TabIndex = 20;
            // 
            // pnlCirculo
            // 
            this.pnlCirculo.Controls.Add(this.tbRaio);
            this.pnlCirculo.Controls.Add(this.lblRaio);
            this.pnlCirculo.Location = new System.Drawing.Point(28, 313);
            this.pnlCirculo.Name = "pnlCirculo";
            this.pnlCirculo.Size = new System.Drawing.Size(352, 118);
            this.pnlCirculo.TabIndex = 21;
            // 
            // listViewArea
            // 
            this.listViewArea.HideSelection = false;
            this.listViewArea.Location = new System.Drawing.Point(28, 462);
            this.listViewArea.Name = "listViewArea";
            this.listViewArea.Size = new System.Drawing.Size(688, 135);
            this.listViewArea.TabIndex = 22;
            this.listViewArea.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 614);
            this.Controls.Add(this.listViewArea);
            this.Controls.Add(this.pnlCirculo);
            this.Controls.Add(this.pnlTriangulo);
            this.Controls.Add(this.pnlQuadrado);
            this.Controls.Add(this.pnlRetangulo);
            this.Controls.Add(this.rbCirculo);
            this.Controls.Add(this.rbTriangulo);
            this.Controls.Add(this.rbRetangulo);
            this.Controls.Add(this.btArea);
            this.Controls.Add(this.rbQuadrado);
            this.Controls.Add(this.pbImagens);
            this.Name = "Form1";
            this.Text = "Cálculo de Área";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagens)).EndInit();
            this.pnlQuadrado.ResumeLayout(false);
            this.pnlQuadrado.PerformLayout();
            this.pnlRetangulo.ResumeLayout(false);
            this.pnlRetangulo.PerformLayout();
            this.pnlTriangulo.ResumeLayout(false);
            this.pnlTriangulo.PerformLayout();
            this.pnlCirculo.ResumeLayout(false);
            this.pnlCirculo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagens;
        private System.Windows.Forms.RadioButton rbQuadrado;
        private System.Windows.Forms.Label lblLadoQuadrado;
        private System.Windows.Forms.TextBox tbLadoQuadrado;
        private System.Windows.Forms.Button btArea;
        private System.Windows.Forms.RadioButton rbRetangulo;
        private System.Windows.Forms.RadioButton rbTriangulo;
        private System.Windows.Forms.RadioButton rbCirculo;
        private System.Windows.Forms.TextBox tbBaseRetangulo;
        private System.Windows.Forms.Label lblBaseRetangulo;
        private System.Windows.Forms.TextBox tbAlturaRetangulo;
        private System.Windows.Forms.Label lblAlturaRetangulo;
        private System.Windows.Forms.TextBox tbAlturaTriangulo;
        private System.Windows.Forms.Label lblAlturaTriangulo;
        private System.Windows.Forms.TextBox tbBaseTriangulo;
        private System.Windows.Forms.Label lblBaseTriangulo;
        private System.Windows.Forms.TextBox tbRaio;
        private System.Windows.Forms.Label lblRaio;
        private System.Windows.Forms.Panel pnlQuadrado;
        private System.Windows.Forms.Panel pnlRetangulo;
        private System.Windows.Forms.Panel pnlTriangulo;
        private System.Windows.Forms.Panel pnlCirculo;
        private System.Windows.Forms.ListView listViewArea;
    }
}

