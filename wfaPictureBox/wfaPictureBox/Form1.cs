using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaPictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            picBoxImagens.Image = Properties.Resources.branco;
        }

        private void rbCirculo_CheckedChanged(object sender, EventArgs e)
        {
            picBoxImagens.Image = Properties.Resources.circulo;
        }
    }
}
