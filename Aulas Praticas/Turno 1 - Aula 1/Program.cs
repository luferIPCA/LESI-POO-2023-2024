/**
 * lufer
 * lufer@ipca.pt
 * 12-10-2023
 * Gestão de um turno de POO-LESI
 * */

using System;

namespace Aula_1_Turno1
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno a1 = new Aluno("Jose", 27);
            Aluno a2 = new Aluno(28, "Maria");
            Aluno a3 = new Aluno();

            Console.WriteLine("Nome:" + a1.Nome);


            //Turma
            Turma t1 = new Turma();
            t1.AtribuiProfessorTurma("Paulo", 3);
            t1.InsereAlunoTurma("jose", 27);

            Turma t2 = new Turma(49);
            t2.AtribuiProfessorTurma("Joaquim", 7);
            t2.InsereAlunoTurma(a2);

            Turma t3 = new Turma(50,"lufer",5);


            Console.ReadKey();
        }
    }
}
