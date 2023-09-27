using System.Reflection.Emit;

namespace Questao_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Criar instâncias de turmas e alunos
            Turma turma1 = new Turma();
            turma1.Alunos.Add(new Aluno("João", 18, 8.5));
            turma1.Alunos.Add(new Aluno("Maria", 19, 9.0));

            Turma turma2 = new Turma();
            turma2.Alunos.Add(new Aluno("Pedro", 20, 7.0));
            turma2.Alunos.Add(new Aluno("Ana", 21, 8.0));

            // Colocar as turmas em uma lista
            List<Turma> turmas = new List<Turma> { turma1, turma2 };

            // Chamar o método de classe para contar o número total de alunos
            int totalAlunos = Turma.ContarAlunos(turmas);

            // Exibir o resultado na label
            label1.Text = "Total de Alunos: " + totalAlunos.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}