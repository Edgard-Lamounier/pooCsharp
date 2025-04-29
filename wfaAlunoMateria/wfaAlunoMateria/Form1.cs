using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaAlunoMateria
{
    public partial class Form1 : Form
    {
        Aluno[]  arrayAlunos = new Aluno[100];
        int contAlunos = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void buttonGRAVAR_ALUNO_MouseClick(object sender, MouseEventArgs e)
        {
            Aluno a = new Aluno();
            a.Nome = textBoxNome_Aluno.Text;
            a.Numero_matricula = textBoxNroMatricula.Text;
            a.Periodo = Convert.ToInt32(textBoxPeriodo.Text);

            arrayAlunos[contAlunos] = a;
            contAlunos++;

            MessageBox.Show("Aluno cadastrado com sucesso!");
        }

        // botão OK de relatório
        private void button1_Click(object sender, EventArgs e)
        {
            string relatorio = " ";
            //MessageBox.Show(arrayAlunos.Length.ToString());

            for (int i = 0; i < contAlunos; i++)
            {
                relatorio = relatorio + arrayAlunos[i].Nome + " "
                                      + arrayAlunos[i].Numero_matricula + " "
                                      + arrayAlunos[i].Periodo.ToString() + " " + "\n";
            }
            rtbREL.Text = relatorio;
            Console.WriteLine(relatorio);
        }
    }
}
