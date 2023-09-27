using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao_3
{
    using System.Collections.Generic;

    public class Turma
    {
        public List<Aluno> Alunos { get; set; }

        public Turma()
        {
            Alunos = new List<Aluno>();
        }

        public static int ContarAlunos(List<Turma> turmas)
        {
            int totalAlunos = 0;
            foreach (Turma turma in turmas)
            {
                totalAlunos += turma.Alunos.Count;
            }
            return totalAlunos;
        }
    }
}
