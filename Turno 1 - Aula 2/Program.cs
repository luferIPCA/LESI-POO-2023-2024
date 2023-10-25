/*
 * 
 * */
using System;

namespace Turno_1___Aula_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine("Int={0}", x);

            Aluno a3 = new Aluno();
            Console.WriteLine(a3.ToString()); ;

            #region AbordagemAluno
            //ESTA ABORDAGEM È DISCUTÌVEL!!!

            Console.WriteLine("Total de alunos: {0}", Aluno.totAlunos);

            Aluno a1 = new Aluno(12,"Maria");
            Console.WriteLine("Total de alunos: {0}", Aluno.totAlunos);
            
            //a1.InsereAluno();
            Aluno.InsereAluno(a1);

            Aluno a2 = new Aluno(13, "Manuel");
            Aluno.InsereAluno(a2);
            
            //Mostrar turma
            foreach(Aluno a in Aluno.AlunosTurma)
            {
                if (a == null) continue;
                Console.WriteLine("Aluno:" + a.Nome);
            }

            //Console.WriteLine($"Total de alunos: a1.totAlunos");
            Console.WriteLine("Total de alunos: {0}",Aluno.totAlunos);

            #endregion

            #region AbordagemTurma
            //Existem classe Turma e Aluno: BOA ABORDAGEM!!!
            Turma t1 = new Turma();
            t1.InsereAlunoTurma(a1);
            t1.InsereAlunoTurma(a2);
            t1.MostraAlunosTurma();

            #endregion

        }
    }
}
