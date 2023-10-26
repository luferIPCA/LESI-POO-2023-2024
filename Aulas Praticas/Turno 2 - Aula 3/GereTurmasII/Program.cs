using System;
using TurmasDLL;
using AlunoDLL;

namespace GereTurmasII
{
    class Program
    {
        static void Main(string[] args)
        {

            Turma t1 = new Turma();
            Aluno a1 = new Aluno(12,"Maria");
            Aluno a2 = new Aluno(13, "Manuel");
            Console.WriteLine("Ficha de Aluno:" + a1.ToString());

            t1.InsereAlunoTurma(a1);
            t1.InsereAlunoTurma(a2);

            Console.WriteLine("Turma:");
            t1.MostraTurma();
            
        }
    }
}
