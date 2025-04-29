using awfRegistroEscolar.Modelos;

namespace awfRegistroEscolar
{
    public partial class Form1 : Form
    {
        private List<Curso> _cursos;
        private List<Materia> _materias;
        private List<Aluno> _alunos;


        public Form1()
        {
            this._cursos = new List<Curso>();
            this._materias = new List<Materia>();
            this._alunos = new List<Aluno>();

            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this._materias.Add(new Materia(this.tbMateriaNome.Text, this.tbMateriaCodigo.Text));
            //this.rtbMaterias.Text = this._materias.ToString();

            MessageBox.Show("Materia registrada com sucesso!");
        }

        private void btAlunoRegistrar_Click(object sender, EventArgs e)
        {
            //this._alunos.Add(new Aluno(this.tbAlunoNome.Text, this.tbAlunoCPF.Text, this.tbAlunoNMatricula.Text, this.tbAlunoCurso.Text));
            //this.rtbAlunos.Text = this._alunos.ToString();

            MessageBox.Show("Aluno registrada com sucesso!");
        }

        private void labPeriodoAluno_Click(object sender, EventArgs e)
        {

        }

        private void tbAlunoPeriodo_TextChanged(object sender, EventArgs e)
        {
        }

        private void rtbMaterias_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private Curso ConsultarCurso(string codigoCurso)
        {
            Curso curso;
            int qtd = this._cursos.Count;
            for (int i = 0; i < qtd; i++)
            {
                curso = this._cursos[i];
                if (curso.Codigo.Equals(codigoCurso))
                    return curso;
            }

            return null;
        }

        private Materia ConsultarMateria(string codigoMateria)
        {
            Materia materia;
            int qtd = this._materias.Count;
            for (int i = 0; i < qtd; i++)
            {
                materia = this._materias[i];
                if (materia.Codigo.Equals(codigoMateria))
                    return materia;
            }

            return null;
        }

        private Aluno ConsultarAluno(string matriculaAluno)
        {
            Aluno aluno;
            int qtd = this._alunos.Count;
            for (int i = 0; i < qtd; i++)
            {
                aluno = this._alunos[i];
                if (aluno.Matricula.Equals(matriculaAluno))
                    return aluno;
            }

            return null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.ConsultarMateria(tbMateriaCodigo.Text) != null)
            {
                this.lbMateriaResultadoCadastro.Text = "Não foi possivel cadastrar matéria.";
                return;
            }

            Curso curso = this.ConsultarCurso(this.tbMateriaCodigoCurso.Text);
            if (curso == null)
            {
                this.lbMateriaResultadoCadastro.Text = "Não foi possivel encontrar curso.";
                return;
            }

            this._materias.Add(
                new Materia(this.tbMateriaNome.Text, this.tbMateriaCodigo.Text, curso));
            this.lbMateriaResultadoCadastro.Text = "Matéria Cadastrada com sucesso.";
        }

        private void btCursoSubmeterCadastro_Click(object sender, EventArgs e)
        {
            if (this.ConsultarCurso(this.tbCursoCodigo.Text) != null)
            {
                this.lbCursoResultadoCadastro.Text = "Não foi possivel cadastrar curso.";
                return;
            }

            this._cursos.Add(
                new Curso(this.tbCursoNome.Text, this.tbCursoCodigo.Text));
            this.lbCursoResultadoCadastro.Text = "Curso Cadastrado com sucesso.";
        }

        private void btAlunoSubmeterCadastro_Click(object sender, EventArgs e)
        {

            if (this.ConsultarAluno(this.tbAlunoMatricula.Text) != null)
            {
                this.lbAlunoResultadoCadastrar.Text = "Não foi possivel cadastrar aluno.";
                return;
            }

            Curso curso = ConsultarCurso(this.tbAlunoCodigoCurso.Text);
            if (curso == null)
            {
                this.lbAlunoResultadoCadastrar.Text = "Não foi possivel encontrar curso.";
                return;
            }

            this._alunos.Add(
                new Aluno(this.tbAlunoNome.Text, this.tbAlunoCPF.Text, this.tbAlunoMatricula.Text, curso));
            this.lbAlunoResultadoCadastrar.Text = "Aluno cadastrado com sucesso.";
        }

        private void btAlunoSubmeterMateria_Click(object sender, EventArgs e)
        {
            Aluno aluno = this.ConsultarAluno(this.tbAlunoMatriculaAluno.Text);
            if (aluno == null)
            {
                this.lbAlunoResultadoVincularMateria.Text = "Não foi possivel encontrar aluno.";
                return;
            }

            Materia materia = this.ConsultarMateria(this.tbAlunoCodigoMateria.Text);
            if (materia == null)
            {
                this.lbAlunoResultadoVincularMateria.Text = "Não foi possivel encontrar materia.";
                return;
            }

            aluno.VincularMateria(materia);
            this.lbAlunoResultadoVincularMateria.Text = "Aluno vinculado a matéria com sucesso.";

        }

        private void rtbAlunos_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btAlunoConsulta_Click(object sender, EventArgs e)
        {
            Aluno aluno = this.ConsultarAluno(this.tbAlunoMatriculaConsulta.Text);
            if (aluno == null)
            {
                this.rtbAluno.Text = "Não foi possivel encontrar aluno.";
                return;
            }

            this.rtbAluno.Text = aluno.ToString();
        }

        private void rtbAlunos_TextChanged_1(object sender, EventArgs e)
        {
            this.rtbAlunos.Text = this._alunos.ToString();
        }

        private void rtbCursos_TextChanged(object sender, EventArgs e)
        {
            this.rtbCursos.Text = this._cursos.ToString();
        }

        private void tbcRegistro_Selecionada(object sender, TabControlEventArgs e)
        {
            int qtd;

            qtd = this._alunos.Count;
            for (int i = 0; i < qtd; i++)
            {
                this.rtbAlunos.Text += "# " + this._alunos[i].ToString() + "\n";
            }

            qtd = this._materias.Count;
            for (int i = 0; i < qtd; i++)
            {
                this.rtbMaterias.Text += "# " + this._materias[i].ToString() + "\n";
            }

            qtd = this._cursos.Count;
            for (int i = 0; i < qtd; i++)
            {
                this.rtbCursos.Text += "# " + this._cursos[i].ToString() + "\n";
            }
        }
    } // end : class (Form1)

} // end : namespace