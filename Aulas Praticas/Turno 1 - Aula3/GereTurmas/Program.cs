using System;
using Pessoas;
using Turmas;
using InputOutput;

namespace GereTurmas
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();
            Professor p = new Professor();

            //a.MostraAluno();
            Console.WriteLine("Ficha de Aluno: " + a.ToString());

            Turma t = new Turma(10, "lufer", 5);
            t.InsereAlunoTurma(a);

            Console.WriteLine("Turma:");
            t.MostraAlunosTurma();

            IO.MostraAluno(a);
            
        }
    }
}
