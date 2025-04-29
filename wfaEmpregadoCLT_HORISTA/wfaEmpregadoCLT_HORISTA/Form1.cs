using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaEmpregadoCLT_HORISTA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbCLT_CheckedChanged(object sender, EventArgs e)
        {
            mtbCPF.Mask = "000,000,000-00"; // Cria a maskara para CPF

            lbSalarioMensal.Visible = true;
            tbSalarioMensal.Visible = true;

            lbNroHoras.Visible = false;
            lbPrecoHora.Visible = false;
            tbNroHoras.Visible = false;
            tbPrecoHora.Visible = false;
        }

        private void rbHorista_CheckedChanged(object sender, EventArgs e)
        {
            mtbCPF.Mask = "000,000,000-00"; // Cria a maskara para CPF

            lbSalarioMensal.Visible = false;
            tbSalarioMensal.Visible = false;

            lbNroHoras.Visible = true;
            lbPrecoHora.Visible = true;
            tbNroHoras.Visible = true;
            tbPrecoHora.Visible = true;
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            if (rbCLT.Checked == true)
            {
                // cria um objeto CLT
                EmpregadoCLT clt = new EmpregadoCLT(tbPrimeiroNome.Text, tbSegundoNome.Text,
                    mtbCPF.Text, Convert.ToDouble(tbSalarioMensal.Text));

                double sal_liquido = clt.getSalLiquido();

                MessageBox.Show("Dados Cadastrados com Sucesso!", Convert.ToString(sal_liquido), 
                                          MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else if (rbHorista.Checked == true)
            {
                // cria o objeto Horista
                EmpregadoHORISTA hora = new EmpregadoHORISTA(tbPrimeiroNome.Text, tbSegundoNome.Text,
                    mtbCPF.Text, Convert.ToInt32(tbNroHoras.Text), Convert.ToDouble(tbPrecoHora.Text));

                double sal_liquido = hora.getSalLiquido();
                MessageBox.Show("Dados Cadastrados com Sucesso!", Convert.ToString(sal_liquido), 
                                          MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
