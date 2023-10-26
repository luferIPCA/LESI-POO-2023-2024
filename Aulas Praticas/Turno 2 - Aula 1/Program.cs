/*
 * lufer
 * lufer@ipca.pt
 * 12-10-2023
 * Sistema de Gestão de Turma do 2º turno de LESI
 * */

namespace Aula_1___Turno_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno a1 = new Aluno();
            a1.Nome = string.Empty; //""
            a1.Numero = 12;
            //a1.nome = "Ola";  //ERRO: Porquê?

            Aluno a2 = new Aluno("João", 23);

            Aluno a3 = new Aluno(123, "Maria");

            Turma t1 = new Turma();
            t1.InsereAlunoTurma(a1);

            Turma t2 = new Turma(300);
            t2.InsereAlunoTurma(a1);

            Turma t3 = new Turma(30);

            bool r = t3.InsereAlunoTurma(a1);   


        }
    }
}
