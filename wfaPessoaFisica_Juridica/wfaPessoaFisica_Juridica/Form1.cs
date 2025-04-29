using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaPessoaFisica_Juridica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void radioButtonPFisica_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBoxCPFCNPJ.Mask = "000,000,000-00"; // Cria a maskara para CPF

            // Altera os labels para receber os textos de CNPJ
            labelCPFCNPJ.Text = "CPF";
        }

        private void radioButtonPJuridica_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBoxCPFCNPJ.Mask = "00,000,000/0000-00"; // Cria a maskara para CPF

            // Altera os labels para receber os textos de CNPJ
            labelCPFCNPJ.Text = "CNPJ";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
